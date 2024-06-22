namespace CalculatorActivity
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            AddBtn = new Button();
            DivBtn = new Button();
            NegateBtn = new Button();
            MinusBtn = new Button();
            MultiBtn = new Button();
            ClearBtn = new Button();
            EraseBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20F);
            TxtBox.Location = new Point(12, 21);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(394, 43);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(12, 70);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(65, 63);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(12, 139);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(65, 63);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 12);
            OneBtn.Location = new Point(12, 208);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(65, 63);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(12, 277);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(65, 63);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F);
            DotBtn.Location = new Point(83, 277);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(65, 63);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(83, 208);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(65, 63);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(83, 139);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(65, 63);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(83, 70);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(65, 63);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.BackColor = SystemColors.MenuHighlight;
            EqualBtn.Font = new Font("Segoe UI", 12F);
            EqualBtn.Location = new Point(154, 277);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(65, 63);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = false;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(154, 208);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(65, 63);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(154, 139);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(65, 63);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(154, 70);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(65, 63);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkGray;
            AddBtn.Font = new Font("Segoe UI", 15F);
            AddBtn.Location = new Point(341, 208);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(65, 129);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DivBtn
            // 
            DivBtn.BackColor = Color.DarkGray;
            DivBtn.Font = new Font("Segoe UI", 12F);
            DivBtn.Location = new Point(341, 139);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(65, 63);
            DivBtn.TabIndex = 14;
            DivBtn.Text = "/";
            DivBtn.UseVisualStyleBackColor = false;
            DivBtn.Click += DivBtn_Click;
            // 
            // NegateBtn
            // 
            NegateBtn.BackColor = Color.DarkGray;
            NegateBtn.Font = new Font("Segoe UI", 12F);
            NegateBtn.Location = new Point(270, 277);
            NegateBtn.Name = "NegateBtn";
            NegateBtn.Size = new Size(65, 63);
            NegateBtn.TabIndex = 20;
            NegateBtn.Text = "-/+";
            NegateBtn.UseVisualStyleBackColor = false;
            NegateBtn.Click += NegateBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.BackColor = Color.DarkGray;
            MinusBtn.Font = new Font("Segoe UI", 12F);
            MinusBtn.Location = new Point(270, 208);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(65, 63);
            MinusBtn.TabIndex = 19;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = false;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // MultiBtn
            // 
            MultiBtn.BackColor = Color.DarkGray;
            MultiBtn.Font = new Font("Segoe UI", 12F);
            MultiBtn.Location = new Point(270, 139);
            MultiBtn.Name = "MultiBtn";
            MultiBtn.Size = new Size(65, 63);
            MultiBtn.TabIndex = 18;
            MultiBtn.Text = "*";
            MultiBtn.UseVisualStyleBackColor = false;
            MultiBtn.Click += MultiBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.DarkOrange;
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(270, 70);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(65, 63);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // EraseBtn
            // 
            EraseBtn.BackColor = Color.DarkOrange;
            EraseBtn.Font = new Font("Segoe UI", 12F);
            EraseBtn.Location = new Point(341, 70);
            EraseBtn.Name = "EraseBtn";
            EraseBtn.Size = new Size(65, 63);
            EraseBtn.TabIndex = 21;
            EraseBtn.Text = "<-";
            EraseBtn.UseVisualStyleBackColor = false;
            EraseBtn.Click += EraseBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 349);
            Controls.Add(EraseBtn);
            Controls.Add(NegateBtn);
            Controls.Add(MinusBtn);
            Controls.Add(MultiBtn);
            Controls.Add(ClearBtn);
            Controls.Add(AddBtn);
            Controls.Add(DivBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button AddBtn;
        private Button DivBtn;
        private Button NegateBtn;
        private Button MinusBtn;
        private Button MultiBtn;
        private Button ClearBtn;
        private Button EraseBtn;
    }
}
