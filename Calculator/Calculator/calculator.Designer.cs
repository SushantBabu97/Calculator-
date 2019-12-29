namespace Calculator
{
    partial class Calculator
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
            this.Display = new System.Windows.Forms.TextBox();
            this.CEButton = new System.Windows.Forms.Button();
            this.StandardLabel = new System.Windows.Forms.Label();
            this.SevenButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.InvertButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.BackspButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.SqrButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.Display2 = new System.Windows.Forms.TextBox();
            this.Scientificbutton = new System.Windows.Forms.Button();
            this.Standardbutton = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Absolute = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Modular = new System.Windows.Forms.Button();
            this.Exponential = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Tenx = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.Tanin = new System.Windows.Forms.Button();
            this.Octal = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Cosh = new System.Windows.Forms.Button();
            this.Cosin = new System.Windows.Forms.Button();
            this.Hexa = new System.Windows.Forms.Button();
            this.Pi = new System.Windows.Forms.Button();
            this.Sinin = new System.Windows.Forms.Button();
            this.Sinh = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Scientificlabel = new System.Windows.Forms.Label();
            this.Radian = new System.Windows.Forms.RadioButton();
            this.Degree = new System.Windows.Forms.RadioButton();
            this.Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Display.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.Menu;
            this.Display.Location = new System.Drawing.Point(2, 70);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Display.MaxLength = 15;
            this.Display.Name = "Display";
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display.Size = new System.Drawing.Size(336, 54);
            this.Display.TabIndex = 0;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CEButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CEButton.Location = new System.Drawing.Point(2, 222);
            this.CEButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(78, 55);
            this.CEButton.TabIndex = 1;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // StandardLabel
            // 
            this.StandardLabel.AutoSize = true;
            this.StandardLabel.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StandardLabel.Location = new System.Drawing.Point(84, 6);
            this.StandardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StandardLabel.Name = "StandardLabel";
            this.StandardLabel.Size = new System.Drawing.Size(177, 22);
            this.StandardLabel.TabIndex = 2;
            this.StandardLabel.Text = "Standard Calculator";
            this.StandardLabel.Click += new System.EventHandler(this.StandardLabel_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.SevenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SevenButton.Location = new System.Drawing.Point(2, 281);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(78, 55);
            this.SevenButton.TabIndex = 3;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.FourButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FourButton.Location = new System.Drawing.Point(2, 344);
            this.FourButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(78, 55);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.OneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OneButton.Location = new System.Drawing.Point(2, 405);
            this.OneButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(78, 55);
            this.OneButton.TabIndex = 5;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // InvertButton
            // 
            this.InvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.InvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.InvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvertButton.Font = new System.Drawing.Font("Segoe UI Symbol", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvertButton.Location = new System.Drawing.Point(2, 466);
            this.InvertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(78, 55);
            this.InvertButton.TabIndex = 6;
            this.InvertButton.Text = "+-";
            this.InvertButton.UseVisualStyleBackColor = false;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CButton.Location = new System.Drawing.Point(88, 222);
            this.CButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(78, 55);
            this.CButton.TabIndex = 7;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.TwoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TwoButton.Location = new System.Drawing.Point(88, 405);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(78, 55);
            this.TwoButton.TabIndex = 8;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.FiveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FiveButton.Location = new System.Drawing.Point(88, 344);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(78, 55);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.EightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EightButton.Location = new System.Drawing.Point(88, 283);
            this.EightButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(78, 55);
            this.EightButton.TabIndex = 10;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.ZeroButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroButton.Location = new System.Drawing.Point(88, 466);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(78, 55);
            this.ZeroButton.TabIndex = 11;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DotButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotButton.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DotButton.Location = new System.Drawing.Point(174, 466);
            this.DotButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(78, 55);
            this.DotButton.TabIndex = 21;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.NineButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NineButton.Location = new System.Drawing.Point(174, 283);
            this.NineButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(78, 55);
            this.NineButton.TabIndex = 20;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.SixButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SixButton.Location = new System.Drawing.Point(174, 344);
            this.SixButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(78, 55);
            this.SixButton.TabIndex = 19;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.ThreeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThreeButton.Location = new System.Drawing.Point(174, 405);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(78, 55);
            this.ThreeButton.TabIndex = 18;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // BackspButton
            // 
            this.BackspButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BackspButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.BackspButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackspButton.Location = new System.Drawing.Point(174, 222);
            this.BackspButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackspButton.Name = "BackspButton";
            this.BackspButton.Size = new System.Drawing.Size(78, 55);
            this.BackspButton.TabIndex = 17;
            this.BackspButton.Text = "Backsp";
            this.BackspButton.UseVisualStyleBackColor = false;
            this.BackspButton.Click += new System.EventHandler(this.BackspButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Symbol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(260, 403);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 55);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MulButton
            // 
            this.MulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.MulButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.MulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MulButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MulButton.Location = new System.Drawing.Point(260, 281);
            this.MulButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(78, 55);
            this.MulButton.TabIndex = 25;
            this.MulButton.Text = "X";
            this.MulButton.UseVisualStyleBackColor = false;
            this.MulButton.Click += new System.EventHandler(this.MulButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SubButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubButton.Font = new System.Drawing.Font("Segoe UI Symbol", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubButton.Location = new System.Drawing.Point(260, 342);
            this.SubButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(78, 55);
            this.SubButton.TabIndex = 24;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = false;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.EqualButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.EqualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualButton.Font = new System.Drawing.Font("Segoe UI Symbol", 20.04124F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EqualButton.Location = new System.Drawing.Point(260, 464);
            this.EqualButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(78, 55);
            this.EqualButton.TabIndex = 23;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DivButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DivButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivButton.Font = new System.Drawing.Font("qtquickcontrols", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DivButton.Location = new System.Drawing.Point(260, 220);
            this.DivButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(78, 55);
            this.DivButton.TabIndex = 22;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DownButton.Location = new System.Drawing.Point(260, 159);
            this.DownButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(78, 55);
            this.DownButton.TabIndex = 30;
            this.DownButton.Text = "1/X";
            this.DownButton.UseVisualStyleBackColor = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // SqrButton
            // 
            this.SqrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SqrButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SqrButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SqrButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SqrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqrButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SqrButton.Location = new System.Drawing.Point(174, 159);
            this.SqrButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SqrButton.Name = "SqrButton";
            this.SqrButton.Size = new System.Drawing.Size(78, 55);
            this.SqrButton.TabIndex = 29;
            this.SqrButton.Text = "Sqr";
            this.SqrButton.UseVisualStyleBackColor = false;
            this.SqrButton.Click += new System.EventHandler(this.SqrButton_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SqrtButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.SqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqrtButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrtButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SqrtButton.Location = new System.Drawing.Point(88, 159);
            this.SqrtButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(78, 55);
            this.SqrtButton.TabIndex = 28;
            this.SqrtButton.Text = "Sqrt";
            this.SqrtButton.UseVisualStyleBackColor = false;
            this.SqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ModButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModButton.Location = new System.Drawing.Point(2, 159);
            this.ModButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(78, 55);
            this.ModButton.TabIndex = 27;
            this.ModButton.Text = "%";
            this.ModButton.UseVisualStyleBackColor = false;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // Display2
            // 
            this.Display2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.Display2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display2.ForeColor = System.Drawing.SystemColors.Menu;
            this.Display2.Location = new System.Drawing.Point(2, 34);
            this.Display2.MaxLength = 15;
            this.Display2.Name = "Display2";
            this.Display2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display2.Size = new System.Drawing.Size(336, 18);
            this.Display2.TabIndex = 0;
            this.Display2.TextChanged += new System.EventHandler(this.Display2_TextChanged);
            // 
            // Scientificbutton
            // 
            this.Scientificbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Scientificbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Scientificbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scientificbutton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scientificbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Scientificbutton.Location = new System.Drawing.Point(260, 3);
            this.Scientificbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Scientificbutton.Name = "Scientificbutton";
            this.Scientificbutton.Size = new System.Drawing.Size(78, 31);
            this.Scientificbutton.TabIndex = 31;
            this.Scientificbutton.Text = ">>>";
            this.Scientificbutton.UseVisualStyleBackColor = false;
            this.Scientificbutton.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // Standardbutton
            // 
            this.Standardbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Standardbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Standardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Standardbutton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standardbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Standardbutton.Location = new System.Drawing.Point(358, 0);
            this.Standardbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Standardbutton.Name = "Standardbutton";
            this.Standardbutton.Size = new System.Drawing.Size(78, 31);
            this.Standardbutton.TabIndex = 32;
            this.Standardbutton.Text = "<<<";
            this.Standardbutton.UseVisualStyleBackColor = false;
            this.Standardbutton.Click += new System.EventHandler(this.Standard_Click);
            // 
            // Cube
            // 
            this.Cube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cube.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cube.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cube.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cube.Location = new System.Drawing.Point(616, 159);
            this.Cube.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(78, 55);
            this.Cube.TabIndex = 56;
            this.Cube.Text = "x3";
            this.Cube.UseVisualStyleBackColor = false;
            this.Cube.Click += new System.EventHandler(this.Cube_Click);
            // 
            // Absolute
            // 
            this.Absolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Absolute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Absolute.Cursor = System.Windows.Forms.Cursors.Default;
            this.Absolute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Absolute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Absolute.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Absolute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Absolute.Location = new System.Drawing.Point(530, 159);
            this.Absolute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Absolute.Name = "Absolute";
            this.Absolute.Size = new System.Drawing.Size(78, 55);
            this.Absolute.TabIndex = 55;
            this.Absolute.Text = "Abs |x|";
            this.Absolute.UseVisualStyleBackColor = false;
            this.Absolute.Click += new System.EventHandler(this.Absolute_Click);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Factorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Factorial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Factorial.Location = new System.Drawing.Point(444, 159);
            this.Factorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(78, 55);
            this.Factorial.TabIndex = 54;
            this.Factorial.Text = "Fact";
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Modular
            // 
            this.Modular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Modular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Modular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modular.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Modular.Location = new System.Drawing.Point(358, 159);
            this.Modular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Modular.Name = "Modular";
            this.Modular.Size = new System.Drawing.Size(78, 55);
            this.Modular.TabIndex = 53;
            this.Modular.Text = "Mod";
            this.Modular.UseVisualStyleBackColor = false;
            this.Modular.Click += new System.EventHandler(this.Modular_Click);
            // 
            // Exponential
            // 
            this.Exponential.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Exponential.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Exponential.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exponential.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.Exponential.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exponential.Location = new System.Drawing.Point(616, 403);
            this.Exponential.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exponential.Name = "Exponential";
            this.Exponential.Size = new System.Drawing.Size(78, 55);
            this.Exponential.TabIndex = 52;
            this.Exponential.Text = "Exp";
            this.Exponential.UseVisualStyleBackColor = false;
            this.Exponential.Click += new System.EventHandler(this.Exponential_Click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ln.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ln.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.ln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ln.Location = new System.Drawing.Point(616, 281);
            this.ln.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(78, 55);
            this.ln.TabIndex = 51;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // Logarithm
            // 
            this.Logarithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Logarithm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Logarithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logarithm.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logarithm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Logarithm.Location = new System.Drawing.Point(616, 342);
            this.Logarithm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(78, 55);
            this.Logarithm.TabIndex = 50;
            this.Logarithm.Text = "log";
            this.Logarithm.UseVisualStyleBackColor = false;
            this.Logarithm.Click += new System.EventHandler(this.Logarithm_Click);
            // 
            // Tenx
            // 
            this.Tenx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tenx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tenx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tenx.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tenx.Location = new System.Drawing.Point(616, 464);
            this.Tenx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tenx.Name = "Tenx";
            this.Tenx.Size = new System.Drawing.Size(78, 55);
            this.Tenx.TabIndex = 49;
            this.Tenx.Text = "*10x";
            this.Tenx.UseVisualStyleBackColor = false;
            this.Tenx.Click += new System.EventHandler(this.Tenx_Click);
            // 
            // Binary
            // 
            this.Binary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Binary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Binary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Binary.Font = new System.Drawing.Font("Segoe UI", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Binary.Location = new System.Drawing.Point(616, 220);
            this.Binary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(78, 55);
            this.Binary.TabIndex = 48;
            this.Binary.Text = "BIN";
            this.Binary.UseVisualStyleBackColor = false;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // Root
            // 
            this.Root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Root.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Root.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Root.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Root.Location = new System.Drawing.Point(530, 464);
            this.Root.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(78, 55);
            this.Root.TabIndex = 47;
            this.Root.Text = "_/```";
            this.Root.UseVisualStyleBackColor = false;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tan.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tan.Location = new System.Drawing.Point(530, 281);
            this.Tan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(78, 55);
            this.Tan.TabIndex = 46;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = false;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Tanh
            // 
            this.Tanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tanh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tanh.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tanh.Location = new System.Drawing.Point(530, 342);
            this.Tanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(78, 55);
            this.Tanh.TabIndex = 45;
            this.Tanh.Text = "Tanh";
            this.Tanh.UseVisualStyleBackColor = false;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // Tanin
            // 
            this.Tanin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tanin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Tanin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tanin.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tanin.Location = new System.Drawing.Point(530, 403);
            this.Tanin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tanin.Name = "Tanin";
            this.Tanin.Size = new System.Drawing.Size(78, 55);
            this.Tanin.TabIndex = 44;
            this.Tanin.Text = "Tan-1";
            this.Tanin.UseVisualStyleBackColor = false;
            this.Tanin.Click += new System.EventHandler(this.Tanin_Click);
            // 
            // Octal
            // 
            this.Octal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Octal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Octal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Octal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Octal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Octal.Location = new System.Drawing.Point(530, 220);
            this.Octal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Octal.Name = "Octal";
            this.Octal.Size = new System.Drawing.Size(78, 55);
            this.Octal.TabIndex = 43;
            this.Octal.Text = "OCT";
            this.Octal.UseVisualStyleBackColor = false;
            this.Octal.Click += new System.EventHandler(this.Octal_Click);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Power.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Power.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Power.Location = new System.Drawing.Point(444, 464);
            this.Power.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(78, 55);
            this.Power.TabIndex = 42;
            this.Power.Text = "^";
            this.Power.UseVisualStyleBackColor = false;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cos.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cos.Location = new System.Drawing.Point(444, 281);
            this.Cos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(78, 55);
            this.Cos.TabIndex = 41;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Cosh
            // 
            this.Cosh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cosh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cosh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cosh.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cosh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cosh.Location = new System.Drawing.Point(444, 342);
            this.Cosh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cosh.Name = "Cosh";
            this.Cosh.Size = new System.Drawing.Size(78, 55);
            this.Cosh.TabIndex = 40;
            this.Cosh.Text = "Cosh";
            this.Cosh.UseVisualStyleBackColor = false;
            this.Cosh.Click += new System.EventHandler(this.Cosh_Click);
            // 
            // Cosin
            // 
            this.Cosin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cosin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Cosin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cosin.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cosin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cosin.Location = new System.Drawing.Point(444, 403);
            this.Cosin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cosin.Name = "Cosin";
            this.Cosin.Size = new System.Drawing.Size(78, 55);
            this.Cosin.TabIndex = 39;
            this.Cosin.Text = "Cos-1";
            this.Cosin.UseVisualStyleBackColor = false;
            this.Cosin.Click += new System.EventHandler(this.Cosin_Click);
            // 
            // Hexa
            // 
            this.Hexa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Hexa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Hexa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hexa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hexa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hexa.Location = new System.Drawing.Point(444, 220);
            this.Hexa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Hexa.Name = "Hexa";
            this.Hexa.Size = new System.Drawing.Size(78, 55);
            this.Hexa.TabIndex = 38;
            this.Hexa.Text = "HEX";
            this.Hexa.UseVisualStyleBackColor = false;
            this.Hexa.Click += new System.EventHandler(this.Hexa_Click);
            // 
            // Pi
            // 
            this.Pi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Pi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pi.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pi.Location = new System.Drawing.Point(358, 464);
            this.Pi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(78, 55);
            this.Pi.TabIndex = 37;
            this.Pi.Text = "Pi";
            this.Pi.UseVisualStyleBackColor = false;
            this.Pi.Click += new System.EventHandler(this.Pi_Click);
            // 
            // Sinin
            // 
            this.Sinin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Sinin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Sinin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sinin.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sinin.Location = new System.Drawing.Point(358, 403);
            this.Sinin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sinin.Name = "Sinin";
            this.Sinin.Size = new System.Drawing.Size(78, 55);
            this.Sinin.TabIndex = 36;
            this.Sinin.Text = "Sin-1";
            this.Sinin.UseVisualStyleBackColor = false;
            this.Sinin.Click += new System.EventHandler(this.Sinin_Click);
            // 
            // Sinh
            // 
            this.Sinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Sinh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Sinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sinh.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sinh.Location = new System.Drawing.Point(358, 342);
            this.Sinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sinh.Name = "Sinh";
            this.Sinh.Size = new System.Drawing.Size(78, 55);
            this.Sinh.TabIndex = 35;
            this.Sinh.Text = "Sinh";
            this.Sinh.UseVisualStyleBackColor = false;
            this.Sinh.Click += new System.EventHandler(this.Sinh_Click);
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Sin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sin.Font = new System.Drawing.Font("Segoe UI Symbol", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sin.Location = new System.Drawing.Point(358, 281);
            this.Sin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(78, 55);
            this.Sin.TabIndex = 34;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = false;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Decimal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decimal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Decimal.Location = new System.Drawing.Point(358, 220);
            this.Decimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(78, 55);
            this.Decimal.TabIndex = 33;
            this.Decimal.Text = "DEC";
            this.Decimal.UseVisualStyleBackColor = false;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Scientificlabel
            // 
            this.Scientificlabel.AutoSize = true;
            this.Scientificlabel.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scientificlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Scientificlabel.Location = new System.Drawing.Point(482, 9);
            this.Scientificlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scientificlabel.Name = "Scientificlabel";
            this.Scientificlabel.Size = new System.Drawing.Size(178, 22);
            this.Scientificlabel.TabIndex = 57;
            this.Scientificlabel.Text = "Scientific Calculator";
            this.Scientificlabel.Click += new System.EventHandler(this.Scientificlabel_Click);
            // 
            // Radian
            // 
            this.Radian.AutoSize = true;
            this.Radian.Location = new System.Drawing.Point(535, 133);
            this.Radian.Name = "Radian";
            this.Radian.Size = new System.Drawing.Size(75, 20);
            this.Radian.TabIndex = 58;
            this.Radian.TabStop = true;
            this.Radian.Text = "Radian";
            this.Radian.UseVisualStyleBackColor = true;
            this.Radian.CheckedChanged += new System.EventHandler(this.Radian_CheckedChanged);
            // 
            // Degree
            // 
            this.Degree.AutoSize = true;
            this.Degree.Location = new System.Drawing.Point(616, 133);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(78, 20);
            this.Degree.TabIndex = 59;
            this.Degree.TabStop = true;
            this.Degree.Text = "Degree";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.CheckedChanged += new System.EventHandler(this.Degree_CheckedChanged);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(75, 28);
            this.Menu.TabIndex = 60;
            this.Menu.Text = ":::";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(345, 521);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Radian);
            this.Controls.Add(this.Scientificlabel);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Absolute);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Modular);
            this.Controls.Add(this.Exponential);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.Tenx);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Tanh);
            this.Controls.Add(this.Tanin);
            this.Controls.Add(this.Octal);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Cosh);
            this.Controls.Add(this.Cosin);
            this.Controls.Add(this.Hexa);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.Sinin);
            this.Controls.Add(this.Sinh);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Standardbutton);
            this.Controls.Add(this.Scientificbutton);
            this.Controls.Add(this.Display2);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.SqrButton);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.ModButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DivButton);
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
            this.Controls.Add(this.StandardLabel);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.Display);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.164948F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(50, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Label StandardLabel;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button BackspButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button SqrButton;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.TextBox Display2;
        private System.Windows.Forms.Button Scientificbutton;
        private System.Windows.Forms.Button Standardbutton;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Absolute;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Modular;
        private System.Windows.Forms.Button Exponential;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button Tenx;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button Tanin;
        private System.Windows.Forms.Button Octal;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Cosh;
        private System.Windows.Forms.Button Cosin;
        private System.Windows.Forms.Button Hexa;
        private System.Windows.Forms.Button Pi;
        private System.Windows.Forms.Button Sinin;
        private System.Windows.Forms.Button Sinh;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Label Scientificlabel;
        private System.Windows.Forms.RadioButton Radian;
        private System.Windows.Forms.RadioButton Degree;
        private System.Windows.Forms.Button Menu;
    }
}

