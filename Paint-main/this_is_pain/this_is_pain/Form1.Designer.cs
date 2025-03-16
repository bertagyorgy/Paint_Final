namespace this_is_pain
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.pictureBoxElore = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.pictureBoxVissza = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_selection = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackbar1 = new System.Windows.Forms.TrackBar();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésmáskéntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyomtatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivágásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beillesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nézetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rácsvonalakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBoxElore);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.pictureBoxVissza);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 750);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Location = new System.Drawing.Point(24, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 512);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.Black;
            this.btn_ellipse.Image = global::this_is_pain.Properties.Resources.ellipse;
            this.btn_ellipse.Location = new System.Drawing.Point(3, 295);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(68, 67);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipszis";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.Image = global::this_is_pain.Properties.Resources.color_wheel;
            this.btn_color.Location = new System.Drawing.Point(3, 3);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(68, 67);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Színek";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.Black;
            this.btn_pencil.Image = global::this_is_pain.Properties.Resources.pencil1;
            this.btn_pencil.Location = new System.Drawing.Point(3, 149);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(68, 67);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Ceruza";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.Black;
            this.btn_line.Image = global::this_is_pain.Properties.Resources.remove;
            this.btn_line.Location = new System.Drawing.Point(3, 441);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(68, 67);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Egyenes";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.Black;
            this.btn_eraser.Image = global::this_is_pain.Properties.Resources.eraser1;
            this.btn_eraser.Location = new System.Drawing.Point(3, 222);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(68, 67);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Radír";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.Black;
            this.btn_rect.Image = global::this_is_pain.Properties.Resources.rectangular_shape_outline;
            this.btn_rect.Location = new System.Drawing.Point(3, 368);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(68, 67);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Téglalap";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.Black;
            this.btn_fill.Image = global::this_is_pain.Properties.Resources.fill;
            this.btn_fill.Location = new System.Drawing.Point(3, 76);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(68, 67);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Kitöltés";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // pictureBoxElore
            // 
            this.pictureBoxElore.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxElore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxElore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.pictureBoxElore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.pictureBoxElore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxElore.ForeColor = System.Drawing.Color.Black;
            this.pictureBoxElore.Image = global::this_is_pain.Properties.Resources.redo_arrow_symbol;
            this.pictureBoxElore.Location = new System.Drawing.Point(68, 12);
            this.pictureBoxElore.Name = "pictureBoxElore";
            this.pictureBoxElore.Size = new System.Drawing.Size(61, 66);
            this.pictureBoxElore.TabIndex = 13;
            this.pictureBoxElore.Text = "Előre";
            this.pictureBoxElore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxElore.UseVisualStyleBackColor = false;
            this.pictureBoxElore.Click += new System.EventHandler(this.pictureBoxElore_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_color.Location = new System.Drawing.Point(24, 102);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(76, 26);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // pictureBoxVissza
            // 
            this.pictureBoxVissza.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxVissza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVissza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.pictureBoxVissza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.pictureBoxVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBoxVissza.ForeColor = System.Drawing.Color.Black;
            this.pictureBoxVissza.Image = global::this_is_pain.Properties.Resources.undo_circular_arrow;
            this.pictureBoxVissza.Location = new System.Drawing.Point(3, 12);
            this.pictureBoxVissza.Name = "pictureBoxVissza";
            this.pictureBoxVissza.Size = new System.Drawing.Size(61, 66);
            this.pictureBoxVissza.TabIndex = 12;
            this.pictureBoxVissza.Text = "Vissza";
            this.pictureBoxVissza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pictureBoxVissza.UseVisualStyleBackColor = false;
            this.pictureBoxVissza.Click += new System.EventHandler(this.pictureBoxVissza_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_selection);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackbar1);
            this.panel2.Controls.Add(this.color_picker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(132, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 99);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_selection
            // 
            this.btn_selection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_selection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_selection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selection.ForeColor = System.Drawing.Color.Black;
            this.btn_selection.Image = global::this_is_pain.Properties.Resources.shape__1_;
            this.btn_selection.Location = new System.Drawing.Point(438, 17);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(61, 66);
            this.btn_selection.TabIndex = 14;
            this.btn_selection.Text = "Kijelölés";
            this.btn_selection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_selection.UseVisualStyleBackColor = false;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(340, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vastagság";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackbar1
            // 
            this.trackbar1.Location = new System.Drawing.Point(316, 17);
            this.trackbar1.Minimum = 1;
            this.trackbar1.Name = "trackbar1";
            this.trackbar1.Size = new System.Drawing.Size(104, 45);
            this.trackbar1.TabIndex = 3;
            this.trackbar1.Value = 1;
            this.trackbar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::this_is_pain.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(15, 0);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(286, 99);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.szerkesztésToolStripMenuItem,
            this.nézetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.mentésmáskéntToolStripMenuItem,
            this.nyomtatásToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // mentésmáskéntToolStripMenuItem
            // 
            this.mentésmáskéntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMPToolStripMenuItem,
            this.jPEGToolStripMenuItem,
            this.pNGToolStripMenuItem});
            this.mentésmáskéntToolStripMenuItem.Name = "mentésmáskéntToolStripMenuItem";
            this.mentésmáskéntToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentésmáskéntToolStripMenuItem.Text = "Mentés másként";
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bMPToolStripMenuItem.Text = "BMP";
            this.bMPToolStripMenuItem.Click += new System.EventHandler(this.bMPToolStripMenuItem_Click);
            // 
            // jPEGToolStripMenuItem
            // 
            this.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem";
            this.jPEGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jPEGToolStripMenuItem.Text = "JPEG";
            this.jPEGToolStripMenuItem.Click += new System.EventHandler(this.jPEGToolStripMenuItem_Click);
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // nyomtatásToolStripMenuItem
            // 
            this.nyomtatásToolStripMenuItem.Name = "nyomtatásToolStripMenuItem";
            this.nyomtatásToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nyomtatásToolStripMenuItem.Text = "Nyomtatás";
            this.nyomtatásToolStripMenuItem.Click += new System.EventHandler(this.nyomtatásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kivágásToolStripMenuItem,
            this.másolásToolStripMenuItem,
            this.beillesztésToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // kivágásToolStripMenuItem
            // 
            this.kivágásToolStripMenuItem.Name = "kivágásToolStripMenuItem";
            this.kivágásToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.kivágásToolStripMenuItem.Text = "Kivágás";
            this.kivágásToolStripMenuItem.Click += new System.EventHandler(this.kivágásToolStripMenuItem_Click);
            // 
            // másolásToolStripMenuItem
            // 
            this.másolásToolStripMenuItem.Name = "másolásToolStripMenuItem";
            this.másolásToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.másolásToolStripMenuItem.Text = "Másolás";
            this.másolásToolStripMenuItem.Click += new System.EventHandler(this.másolásToolStripMenuItem_Click);
            // 
            // beillesztésToolStripMenuItem
            // 
            this.beillesztésToolStripMenuItem.Name = "beillesztésToolStripMenuItem";
            this.beillesztésToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.beillesztésToolStripMenuItem.Text = "Beillesztés";
            this.beillesztésToolStripMenuItem.Click += new System.EventHandler(this.beillesztésToolStripMenuItem_Click);
            // 
            // nézetToolStripMenuItem
            // 
            this.nézetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rácsvonalakToolStripMenuItem});
            this.nézetToolStripMenuItem.Name = "nézetToolStripMenuItem";
            this.nézetToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.nézetToolStripMenuItem.Text = "Nézet";
            // 
            // rácsvonalakToolStripMenuItem
            // 
            this.rácsvonalakToolStripMenuItem.CheckOnClick = true;
            this.rácsvonalakToolStripMenuItem.Name = "rácsvonalakToolStripMenuItem";
            this.rácsvonalakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rácsvonalakToolStripMenuItem.Text = "Rácsvonalak";
            this.rácsvonalakToolStripMenuItem.Click += new System.EventHandler(this.rácsvonalakToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(132, 123);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1175, 651);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(132, 758);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1175, 16);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1292, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 635);
            this.panel5.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 774);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.TrackBar trackbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pictureBoxElore;
        private System.Windows.Forms.Button pictureBoxVissza;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nézetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésmáskéntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyomtatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivágásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beillesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rácsvonalakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

