namespace Gr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xStartPoint = new System.Windows.Forms.TextBox();
            this.yStartPoint = new System.Windows.Forms.TextBox();
            this.xEndPoint = new System.Windows.Forms.TextBox();
            this.yEndPoint = new System.Windows.Forms.TextBox();
            this.DDAButtom = new System.Windows.Forms.Button();
            this.BresenhmanButtom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.CircleButtom = new System.Windows.Forms.Button();
            this.yCenterElipse = new System.Windows.Forms.TextBox();
            this.xCenterElipse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ElispeButtom = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radiusX = new System.Windows.Forms.TextBox();
            this.radiusY = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.xPoint1 = new System.Windows.Forms.TextBox();
            this.yPoint1 = new System.Windows.Forms.TextBox();
            this.xPoint2 = new System.Windows.Forms.TextBox();
            this.yPoint2 = new System.Windows.Forms.TextBox();
            this.xPoint3 = new System.Windows.Forms.TextBox();
            this.yPoint3 = new System.Windows.Forms.TextBox();
            this.xPoint4 = new System.Windows.Forms.TextBox();
            this.yPoint4 = new System.Windows.Forms.TextBox();
            this.addPolygon = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.xMatrix = new System.Windows.Forms.TextBox();
            this.yMatrix = new System.Windows.Forms.TextBox();
            this.Translation = new System.Windows.Forms.Button();
            this.Scalling = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.TextBox();
            this.Rotation = new System.Windows.Forms.Button();
            this.xReflect = new System.Windows.Forms.Button();
            this.yReflect = new System.Windows.Forms.Button();
            this.originReflect = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.ShearX = new System.Windows.Forms.TextBox();
            this.ShearY = new System.Windows.Forms.TextBox();
            this.XShear = new System.Windows.Forms.Button();
            this.YShear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawing line";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Point";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Point";
            // 
            // xStartPoint
            // 
            this.xStartPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xStartPoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xStartPoint.Location = new System.Drawing.Point(84, 61);
            this.xStartPoint.Margin = new System.Windows.Forms.Padding(4);
            this.xStartPoint.Name = "xStartPoint";
            this.xStartPoint.Size = new System.Drawing.Size(54, 23);
            this.xStartPoint.TabIndex = 6;
            this.xStartPoint.Text = "X";
            this.xStartPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xStartPoint.TextChanged += new System.EventHandler(this.xStartPoint_TextChanged);
            // 
            // yStartPoint
            // 
            this.yStartPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yStartPoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yStartPoint.Location = new System.Drawing.Point(162, 61);
            this.yStartPoint.Margin = new System.Windows.Forms.Padding(4);
            this.yStartPoint.Multiline = true;
            this.yStartPoint.Name = "yStartPoint";
            this.yStartPoint.Size = new System.Drawing.Size(54, 23);
            this.yStartPoint.TabIndex = 7;
            this.yStartPoint.Text = "Y";
            this.yStartPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yStartPoint.TextChanged += new System.EventHandler(this.yEndPoint_TextChanged);
            // 
            // xEndPoint
            // 
            this.xEndPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xEndPoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xEndPoint.Location = new System.Drawing.Point(84, 113);
            this.xEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.xEndPoint.Name = "xEndPoint";
            this.xEndPoint.Size = new System.Drawing.Size(54, 23);
            this.xEndPoint.TabIndex = 8;
            this.xEndPoint.Text = "X";
            this.xEndPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xEndPoint.TextChanged += new System.EventHandler(this.xEndPoint_TextChanged);
            // 
            // yEndPoint
            // 
            this.yEndPoint.AccessibleDescription = "";
            this.yEndPoint.AccessibleName = "";
            this.yEndPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yEndPoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yEndPoint.Location = new System.Drawing.Point(162, 113);
            this.yEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.yEndPoint.Name = "yEndPoint";
            this.yEndPoint.Size = new System.Drawing.Size(54, 23);
            this.yEndPoint.TabIndex = 9;
            this.yEndPoint.Text = "Y";
            this.yEndPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yEndPoint.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DDAButtom
            // 
            this.DDAButtom.Location = new System.Drawing.Point(21, 153);
            this.DDAButtom.Margin = new System.Windows.Forms.Padding(4);
            this.DDAButtom.Name = "DDAButtom";
            this.DDAButtom.Size = new System.Drawing.Size(90, 26);
            this.DDAButtom.TabIndex = 10;
            this.DDAButtom.Text = "DDA";
            this.DDAButtom.UseVisualStyleBackColor = true;
            this.DDAButtom.Click += new System.EventHandler(this.button1_Click);
            // 
            // BresenhmanButtom
            // 
            this.BresenhmanButtom.Location = new System.Drawing.Point(135, 153);
            this.BresenhmanButtom.Margin = new System.Windows.Forms.Padding(4);
            this.BresenhmanButtom.Name = "BresenhmanButtom";
            this.BresenhmanButtom.Size = new System.Drawing.Size(90, 26);
            this.BresenhmanButtom.TabIndex = 11;
            this.BresenhmanButtom.Text = "Bresenham";
            this.BresenhmanButtom.UseVisualStyleBackColor = true;
            this.BresenhmanButtom.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Center Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Radius";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(57, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 19;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(19, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Drawing Elipse";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(19, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Drawing Circle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // xCenter
            // 
            this.xCenter.AccessibleDescription = "";
            this.xCenter.AccessibleName = "";
            this.xCenter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xCenter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xCenter.Location = new System.Drawing.Point(84, 236);
            this.xCenter.Margin = new System.Windows.Forms.Padding(4);
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(54, 23);
            this.xCenter.TabIndex = 22;
            this.xCenter.Text = "X";
            this.xCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yCenter
            // 
            this.yCenter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yCenter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yCenter.Location = new System.Drawing.Point(171, 236);
            this.yCenter.Margin = new System.Windows.Forms.Padding(4);
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(54, 23);
            this.yCenter.TabIndex = 23;
            this.yCenter.Text = "Y";
            this.yCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yCenter.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RadiusTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RadiusTextBox.Location = new System.Drawing.Point(123, 278);
            this.RadiusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(54, 23);
            this.RadiusTextBox.TabIndex = 24;
            this.RadiusTextBox.Text = "R";
            this.RadiusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CircleButtom
            // 
            this.CircleButtom.Location = new System.Drawing.Point(73, 314);
            this.CircleButtom.Margin = new System.Windows.Forms.Padding(4);
            this.CircleButtom.Name = "CircleButtom";
            this.CircleButtom.Size = new System.Drawing.Size(90, 26);
            this.CircleButtom.TabIndex = 25;
            this.CircleButtom.Text = "Circle";
            this.CircleButtom.UseVisualStyleBackColor = true;
            this.CircleButtom.Click += new System.EventHandler(this.button3_Click);
            // 
            // yCenterElipse
            // 
            this.yCenterElipse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yCenterElipse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yCenterElipse.Location = new System.Drawing.Point(162, 391);
            this.yCenterElipse.Margin = new System.Windows.Forms.Padding(4);
            this.yCenterElipse.Name = "yCenterElipse";
            this.yCenterElipse.Size = new System.Drawing.Size(54, 23);
            this.yCenterElipse.TabIndex = 28;
            this.yCenterElipse.Text = "Y";
            this.yCenterElipse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xCenterElipse
            // 
            this.xCenterElipse.AccessibleDescription = "";
            this.xCenterElipse.AccessibleName = "";
            this.xCenterElipse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xCenterElipse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xCenterElipse.Location = new System.Drawing.Point(84, 391);
            this.xCenterElipse.Margin = new System.Windows.Forms.Padding(4);
            this.xCenterElipse.Name = "xCenterElipse";
            this.xCenterElipse.Size = new System.Drawing.Size(54, 23);
            this.xCenterElipse.TabIndex = 27;
            this.xCenterElipse.Text = "X";
            this.xCenterElipse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xCenterElipse.TextChanged += new System.EventHandler(this.xCenterElipse_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Center Point";
            // 
            // ElispeButtom
            // 
            this.ElispeButtom.Location = new System.Drawing.Point(84, 480);
            this.ElispeButtom.Margin = new System.Windows.Forms.Padding(4);
            this.ElispeButtom.Name = "ElispeButtom";
            this.ElispeButtom.Size = new System.Drawing.Size(90, 26);
            this.ElispeButtom.TabIndex = 29;
            this.ElispeButtom.Text = "Elipse";
            this.ElispeButtom.UseVisualStyleBackColor = true;
            this.ElispeButtom.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(386, 480);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(314, 26);
            this.button5.TabIndex = 30;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(257, 14);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(528, 442);
            this.picture.TabIndex = 31;
            this.picture.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 436);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Radius";
            // 
            // radiusX
            // 
            this.radiusX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radiusX.Location = new System.Drawing.Point(84, 433);
            this.radiusX.Name = "radiusX";
            this.radiusX.Size = new System.Drawing.Size(54, 23);
            this.radiusX.TabIndex = 40;
            this.radiusX.Text = "X";
            this.radiusX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radiusY
            // 
            this.radiusY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radiusY.Location = new System.Drawing.Point(162, 433);
            this.radiusY.Name = "radiusY";
            this.radiusY.Size = new System.Drawing.Size(54, 23);
            this.radiusY.TabIndex = 41;
            this.radiusY.Text = "Y";
            this.radiusY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.Location = new System.Drawing.Point(836, 14);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 29);
            this.label16.TabIndex = 42;
            this.label16.Text = "Input";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(791, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 15);
            this.label17.TabIndex = 43;
            this.label17.Text = "Point 1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(791, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 15);
            this.label18.TabIndex = 44;
            this.label18.Text = "Point 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(966, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 15);
            this.label19.TabIndex = 45;
            this.label19.Text = "Point 3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(966, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 15);
            this.label20.TabIndex = 46;
            this.label20.Text = "Point 4";
            // 
            // xPoint1
            // 
            this.xPoint1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xPoint1.Location = new System.Drawing.Point(841, 58);
            this.xPoint1.Name = "xPoint1";
            this.xPoint1.Size = new System.Drawing.Size(57, 23);
            this.xPoint1.TabIndex = 47;
            this.xPoint1.Text = "X";
            this.xPoint1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yPoint1
            // 
            this.yPoint1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yPoint1.Location = new System.Drawing.Point(904, 58);
            this.yPoint1.Name = "yPoint1";
            this.yPoint1.Size = new System.Drawing.Size(54, 23);
            this.yPoint1.TabIndex = 48;
            this.yPoint1.Text = "Y";
            this.yPoint1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xPoint2
            // 
            this.xPoint2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xPoint2.Location = new System.Drawing.Point(841, 91);
            this.xPoint2.Name = "xPoint2";
            this.xPoint2.Size = new System.Drawing.Size(57, 23);
            this.xPoint2.TabIndex = 49;
            this.xPoint2.Text = "X";
            this.xPoint2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yPoint2
            // 
            this.yPoint2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yPoint2.Location = new System.Drawing.Point(904, 91);
            this.yPoint2.Name = "yPoint2";
            this.yPoint2.Size = new System.Drawing.Size(56, 23);
            this.yPoint2.TabIndex = 50;
            this.yPoint2.Text = "Y";
            this.yPoint2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xPoint3
            // 
            this.xPoint3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xPoint3.Location = new System.Drawing.Point(1016, 58);
            this.xPoint3.Name = "xPoint3";
            this.xPoint3.Size = new System.Drawing.Size(57, 23);
            this.xPoint3.TabIndex = 51;
            this.xPoint3.Text = "X";
            this.xPoint3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yPoint3
            // 
            this.yPoint3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yPoint3.Location = new System.Drawing.Point(1079, 58);
            this.yPoint3.Name = "yPoint3";
            this.yPoint3.Size = new System.Drawing.Size(55, 23);
            this.yPoint3.TabIndex = 52;
            this.yPoint3.Text = "Y";
            this.yPoint3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yPoint3.TextChanged += new System.EventHandler(this.yPoint3_TextChanged);
            // 
            // xPoint4
            // 
            this.xPoint4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xPoint4.Location = new System.Drawing.Point(1016, 94);
            this.xPoint4.Name = "xPoint4";
            this.xPoint4.Size = new System.Drawing.Size(57, 23);
            this.xPoint4.TabIndex = 53;
            this.xPoint4.Text = "X";
            this.xPoint4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yPoint4
            // 
            this.yPoint4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yPoint4.Location = new System.Drawing.Point(1079, 94);
            this.yPoint4.Name = "yPoint4";
            this.yPoint4.Size = new System.Drawing.Size(55, 23);
            this.yPoint4.TabIndex = 54;
            this.yPoint4.Text = "Y";
            this.yPoint4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPolygon
            // 
            this.addPolygon.Location = new System.Drawing.Point(922, 140);
            this.addPolygon.Name = "addPolygon";
            this.addPolygon.Size = new System.Drawing.Size(124, 29);
            this.addPolygon.TabIndex = 55;
            this.addPolygon.Text = "Draw";
            this.addPolygon.UseVisualStyleBackColor = true;
            this.addPolygon.Click += new System.EventHandler(this.addPolygon_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label21.Location = new System.Drawing.Point(808, 172);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 29);
            this.label21.TabIndex = 56;
            this.label21.Text = "Translation ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label23.Location = new System.Drawing.Point(808, 286);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 29);
            this.label23.TabIndex = 58;
            this.label23.Text = "Reflection";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xMatrix
            // 
            this.xMatrix.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xMatrix.Location = new System.Drawing.Point(813, 218);
            this.xMatrix.Name = "xMatrix";
            this.xMatrix.Size = new System.Drawing.Size(88, 23);
            this.xMatrix.TabIndex = 59;
            this.xMatrix.Text = "X";
            this.xMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yMatrix
            // 
            this.yMatrix.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yMatrix.Location = new System.Drawing.Point(935, 218);
            this.yMatrix.Name = "yMatrix";
            this.yMatrix.Size = new System.Drawing.Size(76, 23);
            this.yMatrix.TabIndex = 60;
            this.yMatrix.Text = "Y";
            this.yMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Translation
            // 
            this.Translation.Location = new System.Drawing.Point(813, 253);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(94, 30);
            this.Translation.TabIndex = 61;
            this.Translation.Text = "Translation";
            this.Translation.UseVisualStyleBackColor = true;
            this.Translation.Click += new System.EventHandler(this.button6_Click);
            // 
            // Scalling
            // 
            this.Scalling.Location = new System.Drawing.Point(922, 253);
            this.Scalling.Name = "Scalling";
            this.Scalling.Size = new System.Drawing.Size(92, 30);
            this.Scalling.TabIndex = 62;
            this.Scalling.Text = "Scalling";
            this.Scalling.UseVisualStyleBackColor = true;
            this.Scalling.Click += new System.EventHandler(this.Scalling2D_Click);
            // 
            // angle
            // 
            this.angle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.angle.Location = new System.Drawing.Point(1036, 218);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(79, 23);
            this.angle.TabIndex = 64;
            this.angle.Text = "Angle";
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rotation
            // 
            this.Rotation.Location = new System.Drawing.Point(1030, 253);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(85, 30);
            this.Rotation.TabIndex = 65;
            this.Rotation.Text = "Rotation";
            this.Rotation.UseVisualStyleBackColor = true;
            this.Rotation.Click += new System.EventHandler(this.Rotation_Click);
            // 
            // xReflect
            // 
            this.xReflect.Location = new System.Drawing.Point(813, 338);
            this.xReflect.Name = "xReflect";
            this.xReflect.Size = new System.Drawing.Size(85, 22);
            this.xReflect.TabIndex = 66;
            this.xReflect.Text = "Over X";
            this.xReflect.UseVisualStyleBackColor = true;
            this.xReflect.Click += new System.EventHandler(this.xReflect_Click);
            // 
            // yReflect
            // 
            this.yReflect.Location = new System.Drawing.Point(916, 337);
            this.yReflect.Name = "yReflect";
            this.yReflect.Size = new System.Drawing.Size(98, 23);
            this.yReflect.TabIndex = 67;
            this.yReflect.Text = "Over X";
            this.yReflect.UseVisualStyleBackColor = true;
            this.yReflect.Click += new System.EventHandler(this.yReflect_Click);
            // 
            // originReflect
            // 
            this.originReflect.Location = new System.Drawing.Point(1032, 333);
            this.originReflect.Name = "originReflect";
            this.originReflect.Size = new System.Drawing.Size(83, 27);
            this.originReflect.TabIndex = 68;
            this.originReflect.Text = "Over Origin";
            this.originReflect.UseVisualStyleBackColor = true;
            this.originReflect.Click += new System.EventHandler(this.originReflect_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label24.Location = new System.Drawing.Point(808, 372);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(130, 29);
            this.label24.TabIndex = 69;
            this.label24.Text = "Shearing";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShearX
            // 
            this.ShearX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShearX.Location = new System.Drawing.Point(817, 428);
            this.ShearX.Name = "ShearX";
            this.ShearX.Size = new System.Drawing.Size(81, 23);
            this.ShearX.TabIndex = 70;
            this.ShearX.Text = "X";
            this.ShearX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShearY
            // 
            this.ShearY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShearY.Location = new System.Drawing.Point(935, 428);
            this.ShearY.Name = "ShearY";
            this.ShearY.Size = new System.Drawing.Size(75, 23);
            this.ShearY.TabIndex = 71;
            this.ShearY.Text = "Y";
            this.ShearY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XShear
            // 
            this.XShear.Location = new System.Drawing.Point(817, 480);
            this.XShear.Name = "XShear";
            this.XShear.Size = new System.Drawing.Size(79, 26);
            this.XShear.TabIndex = 72;
            this.XShear.Text = "Shear X";
            this.XShear.UseVisualStyleBackColor = true;
            this.XShear.Click += new System.EventHandler(this.button11_Click);
            // 
            // YShear
            // 
            this.YShear.Location = new System.Drawing.Point(934, 480);
            this.YShear.Name = "YShear";
            this.YShear.Size = new System.Drawing.Size(97, 26);
            this.YShear.TabIndex = 73;
            this.YShear.Text = "Shear Y";
            this.YShear.UseVisualStyleBackColor = true;
            this.YShear.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 519);
            this.Controls.Add(this.YShear);
            this.Controls.Add(this.XShear);
            this.Controls.Add(this.ShearY);
            this.Controls.Add(this.ShearX);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.originReflect);
            this.Controls.Add(this.yReflect);
            this.Controls.Add(this.xReflect);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.Scalling);
            this.Controls.Add(this.Translation);
            this.Controls.Add(this.yMatrix);
            this.Controls.Add(this.xMatrix);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.addPolygon);
            this.Controls.Add(this.yPoint4);
            this.Controls.Add(this.xPoint4);
            this.Controls.Add(this.yPoint3);
            this.Controls.Add(this.xPoint3);
            this.Controls.Add(this.yPoint2);
            this.Controls.Add(this.xPoint2);
            this.Controls.Add(this.yPoint1);
            this.Controls.Add(this.xPoint1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.radiusY);
            this.Controls.Add(this.radiusX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ElispeButtom);
            this.Controls.Add(this.yCenterElipse);
            this.Controls.Add(this.xCenterElipse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CircleButtom);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BresenhmanButtom);
            this.Controls.Add(this.DDAButtom);
            this.Controls.Add(this.yEndPoint);
            this.Controls.Add(this.xEndPoint);
            this.Controls.Add(this.yStartPoint);
            this.Controls.Add(this.xStartPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Graphics Package";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xStartPoint;
        private System.Windows.Forms.TextBox yStartPoint;
        private System.Windows.Forms.TextBox xEndPoint;
        private System.Windows.Forms.TextBox yEndPoint;
        private System.Windows.Forms.Button DDAButtom;
        private System.Windows.Forms.Button BresenhmanButtom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox xCenter;
        private System.Windows.Forms.TextBox yCenter;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Button CircleButtom;
        private System.Windows.Forms.TextBox yCenterElipse;
        private System.Windows.Forms.TextBox xCenterElipse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ElispeButtom;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox radiusX;
        private System.Windows.Forms.TextBox radiusY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox xPoint1;
        private System.Windows.Forms.TextBox yPoint1;
        private System.Windows.Forms.TextBox xPoint2;
        private System.Windows.Forms.TextBox yPoint2;
        private System.Windows.Forms.TextBox xPoint3;
        private System.Windows.Forms.TextBox yPoint3;
        private System.Windows.Forms.TextBox xPoint4;
        private System.Windows.Forms.TextBox yPoint4;
        private System.Windows.Forms.Button addPolygon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox xMatrix;
        private System.Windows.Forms.TextBox yMatrix;
        private System.Windows.Forms.Button Translation;
        private System.Windows.Forms.Button Scalling;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Button Rotation;
        private System.Windows.Forms.Button xReflect;
        private System.Windows.Forms.Button yReflect;
        private System.Windows.Forms.Button originReflect;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox ShearX;
        private System.Windows.Forms.TextBox ShearY;
        private System.Windows.Forms.Button XShear;
        private System.Windows.Forms.Button YShear;
    }
}

