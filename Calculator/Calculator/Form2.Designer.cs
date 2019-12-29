namespace Calculator
{
    partial class TempertureConverter
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Display = new System.Windows.Forms.TextBox();
            this.Temperaturelabel = new System.Windows.Forms.Label();
            this.Celsius = new System.Windows.Forms.RadioButton();
            this.Farenheit = new System.Windows.Forms.RadioButton();
            this.Kelvin = new System.Windows.Forms.RadioButton();
            this.K = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.Display2 = new System.Windows.Forms.TextBox();
            this.DotButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.BackspButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.InvertButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.Menuback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Display.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.Menu;
            this.Display.Location = new System.Drawing.Point(2, 77);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Display.MaxLength = 10;
            this.Display.Name = "Display";
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display.Size = new System.Drawing.Size(336, 54);
            this.Display.TabIndex = 2;
            // 
            // Temperaturelabel
            // 
            this.Temperaturelabel.AutoSize = true;
            this.Temperaturelabel.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperaturelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Temperaturelabel.Location = new System.Drawing.Point(84, 6);
            this.Temperaturelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temperaturelabel.Name = "Temperaturelabel";
            this.Temperaturelabel.Size = new System.Drawing.Size(206, 22);
            this.Temperaturelabel.TabIndex = 3;
            this.Temperaturelabel.Text = "Temperature Converter";
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(110, 163);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(78, 20);
            this.Celsius.TabIndex = 61;
            this.Celsius.TabStop = true;
            this.Celsius.Text = "Celsius";
            this.Celsius.UseVisualStyleBackColor = true;
            // 
            // Farenheit
            // 
            this.Farenheit.AutoSize = true;
            this.Farenheit.Location = new System.Drawing.Point(110, 137);
            this.Farenheit.Name = "Farenheit";
            this.Farenheit.Size = new System.Drawing.Size(95, 20);
            this.Farenheit.TabIndex = 60;
            this.Farenheit.TabStop = true;
            this.Farenheit.Text = "Farenheit";
            this.Farenheit.UseVisualStyleBackColor = true;
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.Location = new System.Drawing.Point(110, 189);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(69, 20);
            this.Kelvin.TabIndex = 62;
            this.Kelvin.TabStop = true;
            this.Kelvin.Text = "Kelvin";
            this.Kelvin.UseVisualStyleBackColor = true;
            this.Kelvin.CheckedChanged += new System.EventHandler(this.Kelvin_CheckedChanged);
            // 
            // K
            // 
            this.K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.K.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.K.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.K.Location = new System.Drawing.Point(251, 262);
            this.K.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(78, 55);
            this.K.TabIndex = 66;
            this.K.Text = "Kelvin";
            this.K.UseVisualStyleBackColor = false;
            this.K.Click += new System.EventHandler(this.K_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.C.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.C.Location = new System.Drawing.Point(251, 339);
            this.C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(78, 55);
            this.C.TabIndex = 65;
            this.C.Text = "Celsius";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.F.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.F.Location = new System.Drawing.Point(251, 410);
            this.F.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(78, 55);
            this.F.TabIndex = 63;
            this.F.Text = "Farenheit";
            this.F.UseVisualStyleBackColor = false;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // Display2
            // 
            this.Display2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.Display2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display2.ForeColor = System.Drawing.SystemColors.Menu;
            this.Display2.Location = new System.Drawing.Point(2, 41);
            this.Display2.MaxLength = 20;
            this.Display2.Name = "Display2";
            this.Display2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display2.Size = new System.Drawing.Size(336, 18);
            this.Display2.TabIndex = 1;
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DotButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotButton.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DotButton.Location = new System.Drawing.Point(154, 459);
            this.DotButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(68, 45);
            this.DotButton.TabIndex = 81;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click_1);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.NineButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NineButton.Location = new System.Drawing.Point(154, 311);
            this.NineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(68, 45);
            this.NineButton.TabIndex = 80;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click_1);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.SixButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SixButton.Location = new System.Drawing.Point(154, 361);
            this.SixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(68, 45);
            this.SixButton.TabIndex = 79;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click_1);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.ThreeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThreeButton.Location = new System.Drawing.Point(154, 410);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(68, 45);
            this.ThreeButton.TabIndex = 78;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click_1);
            // 
            // BackspButton
            // 
            this.BackspButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BackspButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BackspButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackspButton.Location = new System.Drawing.Point(154, 262);
            this.BackspButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackspButton.Name = "BackspButton";
            this.BackspButton.Size = new System.Drawing.Size(68, 45);
            this.BackspButton.TabIndex = 77;
            this.BackspButton.Text = "Backsp";
            this.BackspButton.UseVisualStyleBackColor = false;
            this.BackspButton.Click += new System.EventHandler(this.BackspButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.ZeroButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroButton.Location = new System.Drawing.Point(80, 459);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(68, 45);
            this.ZeroButton.TabIndex = 76;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click_1);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.EightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EightButton.Location = new System.Drawing.Point(80, 311);
            this.EightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(68, 45);
            this.EightButton.TabIndex = 75;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click_1);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.FiveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FiveButton.Location = new System.Drawing.Point(80, 361);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(68, 45);
            this.FiveButton.TabIndex = 74;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click_1);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.TwoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TwoButton.Location = new System.Drawing.Point(80, 410);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(68, 45);
            this.TwoButton.TabIndex = 73;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click_1);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CButton.Location = new System.Drawing.Point(80, 262);
            this.CButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(68, 45);
            this.CButton.TabIndex = 72;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click_1);
            // 
            // InvertButton
            // 
            this.InvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.InvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.InvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvertButton.Font = new System.Drawing.Font("Segoe UI Symbol", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvertButton.Location = new System.Drawing.Point(6, 459);
            this.InvertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(68, 45);
            this.InvertButton.TabIndex = 71;
            this.InvertButton.Text = "+-";
            this.InvertButton.UseVisualStyleBackColor = false;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.OneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OneButton.Location = new System.Drawing.Point(6, 410);
            this.OneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(68, 45);
            this.OneButton.TabIndex = 70;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click_1);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.FourButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FourButton.Location = new System.Drawing.Point(6, 361);
            this.FourButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(68, 45);
            this.FourButton.TabIndex = 69;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click_1);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.SevenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SevenButton.Location = new System.Drawing.Point(6, 309);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 45);
            this.SevenButton.TabIndex = 68;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click_1);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CEButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CEButton.Location = new System.Drawing.Point(6, 262);
            this.CEButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(68, 45);
            this.CEButton.TabIndex = 67;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Menuback
            // 
            this.Menuback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.Menuback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.Menuback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menuback.Location = new System.Drawing.Point(2, 0);
            this.Menuback.Name = "Menuback";
            this.Menuback.Size = new System.Drawing.Size(75, 28);
            this.Menuback.TabIndex = 83;
            this.Menuback.Text = ":::";
            this.Menuback.UseVisualStyleBackColor = false;
            this.Menuback.Click += new System.EventHandler(this.Menuback_Click);
            // 
            // TempertureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(342, 521);
            this.Controls.Add(this.Menuback);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.BackspButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.InvertButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.K);
            this.Controls.Add(this.C);
            this.Controls.Add(this.F);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Farenheit);
            this.Controls.Add(this.Temperaturelabel);
            this.Controls.Add(this.Display2);
            this.Controls.Add(this.Display);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.164948F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TempertureConverter";
            this.Text = "TemperatureConverter";
            this.Load += new System.EventHandler(this.TempertureConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label Temperaturelabel;
        private System.Windows.Forms.RadioButton Celsius;
        private System.Windows.Forms.RadioButton Farenheit;
        private System.Windows.Forms.RadioButton Kelvin;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.TextBox Display2;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button BackspButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button Menuback;
    }
}