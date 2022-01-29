namespace ffm
{
    partial class Admin
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ImageBut = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.DESbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PRICEbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.STOCKbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookNAMEbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookIDbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ImageBut);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.DESbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PRICEbox);
            this.panel1.Controls.Add(this.STOCKbox);
            this.panel1.Controls.Add(this.BookNAMEbox);
            this.panel1.Controls.Add(this.BookIDbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 425);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1044, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 41);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(597, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 25);
            this.button5.TabIndex = 37;
            this.button5.Text = "DELETE CATEGORY";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(476, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 25);
            this.button2.TabIndex = 34;
            this.button2.Text = "ADD CATEGORY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(448, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 40);
            this.label6.TabIndex = 31;
            this.label6.Text = "ADMIN PORTAL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ImageBut
            // 
            this.ImageBut.BackColor = System.Drawing.Color.Navy;
            this.ImageBut.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.ImageBut.ForeColor = System.Drawing.Color.White;
            this.ImageBut.Location = new System.Drawing.Point(930, 281);
            this.ImageBut.Name = "ImageBut";
            this.ImageBut.Size = new System.Drawing.Size(121, 27);
            this.ImageBut.TabIndex = 30;
            this.ImageBut.Text = "Upload Image";
            this.ImageBut.UseVisualStyleBackColor = false;
            this.ImageBut.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(864, 60);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(239, 215);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // DESbox
            // 
            this.DESbox.Animated = true;
            this.DESbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.DESbox.AutoSize = true;
            this.DESbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DESbox.BorderColor = System.Drawing.Color.White;
            this.DESbox.BorderRadius = 10;
            this.DESbox.BorderThickness = 0;
            this.DESbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DESbox.DefaultText = "";
            this.DESbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DESbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DESbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DESbox.DisabledState.Parent = this.DESbox;
            this.DESbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DESbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DESbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESbox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.DESbox.FocusedState.Parent = this.DESbox;
            this.DESbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DESbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DESbox.HoverState.Parent = this.DESbox;
            this.DESbox.Location = new System.Drawing.Point(12, 261);
            this.DESbox.Multiline = true;
            this.DESbox.Name = "DESbox";
            this.DESbox.PasswordChar = '\0';
            this.DESbox.PlaceholderForeColor = System.Drawing.Color.Navy;
            this.DESbox.PlaceholderText = "";
            this.DESbox.SelectedText = "";
            this.DESbox.ShadowDecoration.Parent = this.DESbox;
            this.DESbox.Size = new System.Drawing.Size(240, 119);
            this.DESbox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "DESCRIPTION";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookID,
            this.BookName,
            this.Category,
            this.Stock,
            this.Price,
            this.Description,
            this.Image});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(258, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 322);
            this.listView1.TabIndex = 26;
            this.listView1.TileSize = new System.Drawing.Size(168, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BookID
            // 
            this.BookID.Text = "Book ID";
            this.BookID.Width = 93;
            // 
            // BookName
            // 
            this.BookName.Text = "Book Name";
            this.BookName.Width = 97;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 140;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 53;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 47;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 99;
            // 
            // Image
            // 
            this.Image.Text = "Image";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Navy;
            this.Edit.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(366, 388);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(104, 25);
            this.Edit.TabIndex = 24;
            this.Edit.Text = "UPDATE ITEM";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Navy;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(733, 388);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 25);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "DELETE ITEM";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(275, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "ADD ITEM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PRICEbox
            // 
            this.PRICEbox.Animated = true;
            this.PRICEbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.PRICEbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PRICEbox.BorderColor = System.Drawing.Color.White;
            this.PRICEbox.BorderRadius = 5;
            this.PRICEbox.BorderThickness = 0;
            this.PRICEbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PRICEbox.DefaultText = "";
            this.PRICEbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PRICEbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PRICEbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PRICEbox.DisabledState.Parent = this.PRICEbox;
            this.PRICEbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PRICEbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PRICEbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PRICEbox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.PRICEbox.FocusedState.Parent = this.PRICEbox;
            this.PRICEbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PRICEbox.ForeColor = System.Drawing.Color.Navy;
            this.PRICEbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PRICEbox.HoverState.Parent = this.PRICEbox;
            this.PRICEbox.Location = new System.Drawing.Point(56, 187);
            this.PRICEbox.Name = "PRICEbox";
            this.PRICEbox.PasswordChar = '\0';
            this.PRICEbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.PRICEbox.PlaceholderText = "Price";
            this.PRICEbox.SelectedText = "";
            this.PRICEbox.ShadowDecoration.Parent = this.PRICEbox;
            this.PRICEbox.Size = new System.Drawing.Size(149, 27);
            this.PRICEbox.TabIndex = 21;
            // 
            // STOCKbox
            // 
            this.STOCKbox.Animated = true;
            this.STOCKbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.STOCKbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.STOCKbox.BorderColor = System.Drawing.Color.White;
            this.STOCKbox.BorderRadius = 5;
            this.STOCKbox.BorderThickness = 0;
            this.STOCKbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.STOCKbox.DefaultText = "";
            this.STOCKbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STOCKbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STOCKbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STOCKbox.DisabledState.Parent = this.STOCKbox;
            this.STOCKbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STOCKbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.STOCKbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STOCKbox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.STOCKbox.FocusedState.Parent = this.STOCKbox;
            this.STOCKbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STOCKbox.ForeColor = System.Drawing.Color.Navy;
            this.STOCKbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STOCKbox.HoverState.Parent = this.STOCKbox;
            this.STOCKbox.Location = new System.Drawing.Point(56, 153);
            this.STOCKbox.Name = "STOCKbox";
            this.STOCKbox.PasswordChar = '\0';
            this.STOCKbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.STOCKbox.PlaceholderText = "Stock";
            this.STOCKbox.SelectedText = "";
            this.STOCKbox.ShadowDecoration.Parent = this.STOCKbox;
            this.STOCKbox.Size = new System.Drawing.Size(149, 27);
            this.STOCKbox.TabIndex = 20;
            this.STOCKbox.TextChanged += new System.EventHandler(this.MILESbox_TextChanged);
            // 
            // BookNAMEbox
            // 
            this.BookNAMEbox.Animated = true;
            this.BookNAMEbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.BookNAMEbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BookNAMEbox.BorderColor = System.Drawing.Color.White;
            this.BookNAMEbox.BorderRadius = 5;
            this.BookNAMEbox.BorderThickness = 0;
            this.BookNAMEbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookNAMEbox.DefaultText = "";
            this.BookNAMEbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookNAMEbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookNAMEbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookNAMEbox.DisabledState.Parent = this.BookNAMEbox;
            this.BookNAMEbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookNAMEbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookNAMEbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookNAMEbox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.BookNAMEbox.FocusedState.Parent = this.BookNAMEbox;
            this.BookNAMEbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BookNAMEbox.ForeColor = System.Drawing.Color.Navy;
            this.BookNAMEbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookNAMEbox.HoverState.Parent = this.BookNAMEbox;
            this.BookNAMEbox.Location = new System.Drawing.Point(56, 93);
            this.BookNAMEbox.Name = "BookNAMEbox";
            this.BookNAMEbox.PasswordChar = '\0';
            this.BookNAMEbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookNAMEbox.PlaceholderText = "Book Name";
            this.BookNAMEbox.SelectedText = "";
            this.BookNAMEbox.ShadowDecoration.Parent = this.BookNAMEbox;
            this.BookNAMEbox.Size = new System.Drawing.Size(149, 27);
            this.BookNAMEbox.TabIndex = 19;
            this.BookNAMEbox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // BookIDbox
            // 
            this.BookIDbox.Animated = true;
            this.BookIDbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.BookIDbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BookIDbox.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.BookIDbox.BorderRadius = 5;
            this.BookIDbox.BorderThickness = 0;
            this.BookIDbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookIDbox.DefaultText = "";
            this.BookIDbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookIDbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookIDbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookIDbox.DisabledState.Parent = this.BookIDbox;
            this.BookIDbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookIDbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookIDbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookIDbox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.BookIDbox.FocusedState.Parent = this.BookIDbox;
            this.BookIDbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BookIDbox.ForeColor = System.Drawing.Color.Navy;
            this.BookIDbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookIDbox.HoverState.Parent = this.BookIDbox;
            this.BookIDbox.Location = new System.Drawing.Point(56, 60);
            this.BookIDbox.Name = "BookIDbox";
            this.BookIDbox.PasswordChar = '\0';
            this.BookIDbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookIDbox.PlaceholderText = "Book ID";
            this.BookIDbox.SelectedText = "";
            this.BookIDbox.ShadowDecoration.Parent = this.BookIDbox;
            this.BookIDbox.Size = new System.Drawing.Size(149, 27);
            this.BookIDbox.TabIndex = 18;
            this.BookIDbox.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 425);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox STOCKbox;
        private Guna.UI2.WinForms.Guna2TextBox BookNAMEbox;
        private Guna.UI2.WinForms.Guna2TextBox BookIDbox;
        private Guna.UI2.WinForms.Guna2TextBox PRICEbox;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2TextBox DESbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ImageBut;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Image;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Description;
        protected internal System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}