using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;

namespace this_is_pain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Height = 1080;
            this.Width = 1940;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            this.ControlBox = true;      // Fejléc és vezérlőgombok bekapcsolása
            this.MinimizeBox = true;     // 🔽 Tálcára tevés gomb engedélyezése
            this.MaximizeBox = true;
            pic.Paint += canvas_Paint;
            rácsvonalakToolStripMenuItem.Click += rácsvonalakToolStripMenuItem_Click;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private List<Bitmap> history = new List<Bitmap>();
        private int historyIndex = -1;
        private bool selecting = false;  // Jelzi, hogy folyamatban van-e a kijelölés
        private Rectangle selectionRect; // A kijelölés téglalapja
        private Pen selectionPen = new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }; // Szaggatott vonal
        private Bitmap copiedImage = null;  // Itt tároljuk az aktuálisan másolt képrészletet
        private Point pasteLocation;        // Itt tároljuk az egér helyzetét beillesztéshez
        private bool isPasting = false;     // Jelzi, hogy folyamatban van-e a beillesztés

        private bool isModified = false;
        private PrintDocument printDocument = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

            if (index == 6) // Ha a kijelölés aktív (6-os index, ezt a gombhoz kell majd állítani)
            {
                selecting = true;
                selectionRect = new Rectangle(e.X, e.Y, 0, 0);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    int dx = px.X - py.X;
                    int dy = px.Y - py.Y;
                    float distance = (float)Math.Sqrt(dx * dx + dy * dy);
                    float step = p.Width / 2;

                    if (distance > 0)
                    {
                        for (float i = 0; i <= distance; i += step)
                        {
                            float t = i / distance;
                            int x = (int)(py.X + t * dx);
                            int y = (int)(py.Y + t * dy);

                            g.FillEllipse(new SolidBrush(p.Color), x - p.Width / 2, y - p.Width / 2, p.Width, p.Width);
                        }
                    }

                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                if (index == 4)
                {
                    pic.Refresh();
                    int startX = Math.Min(cX, e.X);
                    int startY = Math.Min(cY, e.Y);
                    int width = Math.Abs(e.X - cX);
                    int height = Math.Abs(e.Y - cY);

                    using (Graphics tempG = pic.CreateGraphics())
                    {
                        tempG.DrawRectangle(p, startX, startY, width, height);
                    }
                }
                /*if (index == 4)
                {
                    pic.Refresh();
                    int startX = Math.Min(cX, e.X);
                    int startY = Math.Min(cY, e.Y);
                    int width = Math.Abs(e.X - cX);
                    int height = Math.Abs(e.Y - cY);

                    using (Graphics tempG = Graphics.FromImage(bm))
                    {
                        g.Clear(Color.White);
                        g.DrawImage(bm, 0, 0);
                        tempG.DrawRectangle(p, startX, startY, width, height);
                    }
                    pic.Image = bm;
                }*/
            }
            pic.Refresh();
            x = e.X;
            y = e.Y;

            sX = e.X - cX;
            sY = e.Y - cY;

            if (selecting)
            {
                int width = e.X - selectionRect.X;
                int height = e.Y - selectionRect.Y;
                selectionRect.Width = width;
                selectionRect.Height = height;
                pic.Refresh();
            }

            if (isPasting)
            {
                pasteLocation = e.Location;
                pic.Refresh();
            }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            int startX = Math.Min(cX, x);
            int startY = Math.Min(cY, y);
            int width = Math.Abs(x - cX);
            int height = Math.Abs(y - cY);

            if (index == 3)
            {
                g.DrawEllipse(p, startX, startY, width, height);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, startX, startY, width, height);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if (index == 6)
            {
                selecting = false;
                pic.Refresh();
                return;
            }

            SaveState();
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
            if (selecting)
            {
                e.Graphics.DrawRectangle(selectionPen, selectionRect);
            }
            if (isPasting)
            {
                e.Graphics.DrawImage(copiedImage, pasteLocation); // A másolt kép megjelenítése az egér pozíciójában
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color_ = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color_ == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color_, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color_, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color_, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color_, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
            if (isPasting)
            {
                g.DrawImage(copiedImage, pasteLocation); // Beillesztjük a másolt képet az egér pozíciójába
                isPasting = false; // Beillesztési mód kikapcsolása
                SaveState(); // A beillesztést mentjük a history listába
                pic.Refresh(); // Frissítjük a vásznat
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Rajzolj egy keretet a panel3 köré
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, panel3.Width - 1, panel3.Height - 1);
        }
        private void btn_selection_Click(object sender, EventArgs e)
        {
            index = 6; // A kijelölés aktiválása
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0) // Ha van érvényes kijelölés
            {
                copiedImage = bm.Clone(selectionRect, bm.PixelFormat); // Kép kivágása
            }
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            if (copiedImage != null) // Ha van másolt kép
            {
                selecting = false; // Kijelölést kikapcsoljuk
                pasteLocation = Point.Empty; // Alapértelmezett beillesztési pont
                isPasting = true; // Beillesztési mód aktiválása
                pic.Refresh(); // Frissítjük a vásznat
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }


        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0) // Ha van érvényes kijelölés
            {
                copiedImage = bm.Clone(selectionRect, bm.PixelFormat); // Kép kivágása
            }
        }

        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copiedImage != null) // Ha van másolt kép
            {
                selecting = false; // Kijelölést kikapcsoljuk
                pasteLocation = Point.Empty; // Alapértelmezett beillesztési pont
                isPasting = true; // Beillesztési mód aktiválása
                pic.Refresh(); // Frissítjük a vásznat
            }
        }

        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0) // Ha van érvényes kijelölés
            {
                // Kép kivágása és tárolása a copiedImage változóba
                copiedImage = bm.Clone(selectionRect, bm.PixelFormat);

                // Kijelölt terület kitöltése fehér színnel (vagy átlátszóval, ha támogatott)
                using (Graphics g = Graphics.FromImage(bm))
                {
                    g.FillRectangle(Brushes.White, selectionRect);
                }

                // Frissítjük a vásznat
                pic.Refresh();

                // Kijelölés megszüntetése
                selecting = false;
                selectionRect = Rectangle.Empty;

                // Mentjük az új állapotot a visszavonáshoz
                SaveState();
            }
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
        private void SaveImage(ImageFormat format, string extension)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = $"{extension.ToUpper()} (*.{extension})|*.{extension}";
                sfd.Title = $"Mentés {extension.ToUpper()} formátumban";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bm.Save(sfd.FileName, format);
                }
            }
        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage(ImageFormat.Bmp, "bmp");
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage(ImageFormat.Bmp, "jpg");
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage(ImageFormat.Bmp, "png");
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (bm != null)
            {
                e.Graphics.DrawImage(bm, e.MarginBounds);
            }
        }
        private void PrintImage()
        {
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void nyomtatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintImage();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (rácsvonalakToolStripMenuItem.Checked)
            {
                DrawGrid(e.Graphics);
            }
        }
        private void DrawGrid(Graphics g)
        {
            int gridSize = 20; // Rácsvonalak közötti távolság
            Pen gridPen = new Pen(Color.LightGray, 1); // Rács színe és vastagsága

            for (int x = 0; x < pic.Width; x += gridSize)
            {
                g.DrawLine(gridPen, x, 0, x, pic.Height);
            }

            for (int y = 0; y < pic.Height; y += gridSize)
            {
                g.DrawLine(gridPen, 0, y, pic.Width, y);
            }

            gridPen.Dispose();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rácsvonalakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rácsvonalakToolStripMenuItem.Checked = !rácsvonalakToolStripMenuItem.Checked;
            pic.Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float újVastagság = trackbar1.Value;
            p = new Pen(p.Color, újVastagság);
            Invalidate(); // újrarajzolja a formot
        }
        private void pictureBoxElore_Click(object sender, EventArgs e)
        {
            if (historyIndex < history.Count - 1)
            {
                historyIndex++;
                bm = (Bitmap)history[historyIndex].Clone();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }

        private void pictureBoxVissza_Click(object sender, EventArgs e)
        {
            if (historyIndex > 0)
            {
                historyIndex--;
                bm = (Bitmap)history[historyIndex].Clone();
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }

        private void SaveState()
        {
            // Ha visszaléptünk korábbi állapotokra és most új változtatás történik,
            // akkor töröljük a további állapotokat
            if (historyIndex < history.Count - 1)
            {
                history.RemoveRange(historyIndex + 1, history.Count - historyIndex - 1);
            }

            // Mentjük az aktuális képet a listába
            history.Add((Bitmap)bm.Clone());
            historyIndex = history.Count - 1;
            isModified = true;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isModified)
            {
                var result = MessageBox.Show("Szeretné menteni munkáját?", "Mentés", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var sfd = new SaveFileDialog();
                    sfd.Filter = "Image(.jpg)|*.jpg|(*.*|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                        btm.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            index = 1;
            SaveState();
        }
    }
}