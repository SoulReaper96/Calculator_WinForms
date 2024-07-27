namespace Calculator
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
            textBox1 = new TextBox();
            N1 = new Button();
            N2 = new Button();
            N3 = new Button();
            N4 = new Button();
            N5 = new Button();
            N6 = new Button();
            N7 = new Button();
            N8 = new Button();
            N9 = new Button();
            N0 = new Button();
            N00 = new Button();
            Dot = new Button();
            Addition = new Button();
            Equals = new Button();
            Subtraction = new Button();
            Multiplication = new Button();
            Division = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // N1
            // 
            N1.BackColor = Color.Cyan;
            N1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N1.Location = new Point(12, 140);
            N1.Name = "N1";
            N1.Size = new Size(40, 40);
            N1.TabIndex = 1;
            N1.Text = "1";
            N1.UseVisualStyleBackColor = false;
            N1.Click += N1_Click;
            // 
            // N2
            // 
            N2.BackColor = Color.Cyan;
            N2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N2.Location = new Point(58, 140);
            N2.Name = "N2";
            N2.Size = new Size(40, 40);
            N2.TabIndex = 2;
            N2.Text = "2";
            N2.UseVisualStyleBackColor = false;
            N2.Click += N2_Click;
            // 
            // N3
            // 
            N3.BackColor = Color.Cyan;
            N3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N3.Location = new Point(104, 140);
            N3.Name = "N3";
            N3.Size = new Size(40, 40);
            N3.TabIndex = 3;
            N3.Text = "3";
            N3.UseVisualStyleBackColor = false;
            N3.Click += N3_Click;
            // 
            // N4
            // 
            N4.BackColor = Color.Cyan;
            N4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N4.Location = new Point(12, 94);
            N4.Name = "N4";
            N4.Size = new Size(40, 40);
            N4.TabIndex = 4;
            N4.Text = "4";
            N4.UseVisualStyleBackColor = false;
            N4.Click += N4_Click;
            // 
            // N5
            // 
            N5.BackColor = Color.Cyan;
            N5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N5.Location = new Point(58, 94);
            N5.Name = "N5";
            N5.Size = new Size(40, 40);
            N5.TabIndex = 5;
            N5.Text = "5";
            N5.UseVisualStyleBackColor = false;
            N5.Click += N5_Click;
            // 
            // N6
            // 
            N6.BackColor = Color.Cyan;
            N6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N6.Location = new Point(104, 94);
            N6.Name = "N6";
            N6.Size = new Size(40, 40);
            N6.TabIndex = 6;
            N6.Text = "6";
            N6.UseVisualStyleBackColor = false;
            N6.Click += N6_Click;
            // 
            // N7
            // 
            N7.BackColor = Color.Cyan;
            N7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N7.Location = new Point(12, 48);
            N7.Name = "N7";
            N7.Size = new Size(40, 40);
            N7.TabIndex = 7;
            N7.Text = "7";
            N7.UseVisualStyleBackColor = false;
            N7.Click += N7_Click;
            // 
            // N8
            // 
            N8.BackColor = Color.Cyan;
            N8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N8.Location = new Point(58, 48);
            N8.Name = "N8";
            N8.Size = new Size(40, 40);
            N8.TabIndex = 8;
            N8.Text = "8";
            N8.UseVisualStyleBackColor = false;
            N8.Click += N8_Click;
            // 
            // N9
            // 
            N9.BackColor = Color.Cyan;
            N9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N9.Location = new Point(104, 48);
            N9.Name = "N9";
            N9.Size = new Size(40, 40);
            N9.TabIndex = 9;
            N9.Text = "9";
            N9.UseVisualStyleBackColor = false;
            N9.Click += N9_Click;
            // 
            // N0
            // 
            N0.BackColor = Color.Cyan;
            N0.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N0.Location = new Point(12, 186);
            N0.Name = "N0";
            N0.Size = new Size(40, 40);
            N0.TabIndex = 10;
            N0.Text = "0";
            N0.UseVisualStyleBackColor = false;
            N0.Click += N0_Click;
            // 
            // N00
            // 
            N00.BackColor = Color.Cyan;
            N00.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N00.Location = new Point(58, 186);
            N00.Name = "N00";
            N00.Size = new Size(40, 40);
            N00.TabIndex = 11;
            N00.Text = "00";
            N00.UseVisualStyleBackColor = false;
            N00.Click += N00_Click;
            // 
            // Dot
            // 
            Dot.BackColor = Color.Cyan;
            Dot.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dot.Location = new Point(104, 186);
            Dot.Name = "Dot";
            Dot.Size = new Size(40, 40);
            Dot.TabIndex = 12;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = false;
            Dot.Click += Dot_Click;
            // 
            // Addition
            // 
            Addition.BackColor = Color.Cyan;
            Addition.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addition.Location = new Point(150, 140);
            Addition.Name = "Addition";
            Addition.Size = new Size(40, 86);
            Addition.TabIndex = 13;
            Addition.Text = "+";
            Addition.UseVisualStyleBackColor = false;
            Addition.Click += Addition_Click;
            // 
            // Equals
            // 
            Equals.BackColor = Color.Cyan;
            Equals.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Equals.Location = new Point(196, 186);
            Equals.Name = "Equals";
            Equals.Size = new Size(40, 40);
            Equals.TabIndex = 14;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = false;
            Equals.Click += Equals_Click;
            // 
            // Subtraction
            // 
            Subtraction.BackColor = Color.Cyan;
            Subtraction.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subtraction.Location = new Point(196, 140);
            Subtraction.Name = "Subtraction";
            Subtraction.Size = new Size(40, 40);
            Subtraction.TabIndex = 15;
            Subtraction.Text = "-";
            Subtraction.UseVisualStyleBackColor = false;
            Subtraction.Click += Subtraction_Click;
            // 
            // Multiplication
            // 
            Multiplication.BackColor = Color.Cyan;
            Multiplication.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Multiplication.Location = new Point(150, 94);
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(40, 40);
            Multiplication.TabIndex = 16;
            Multiplication.Text = "*";
            Multiplication.UseVisualStyleBackColor = false;
            Multiplication.Click += Multiplication_Click;
            // 
            // Division
            // 
            Division.BackColor = Color.Cyan;
            Division.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Division.Location = new Point(196, 94);
            Division.Name = "Division";
            Division.Size = new Size(40, 40);
            Division.TabIndex = 17;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = false;
            Division.Click += Division_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Cyan;
            Clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(150, 48);
            Clear.Name = "Clear";
            Clear.Size = new Size(40, 40);
            Clear.TabIndex = 18;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(253, 229);
            Controls.Add(Clear);
            Controls.Add(Division);
            Controls.Add(Multiplication);
            Controls.Add(Subtraction);
            Controls.Add(Equals);
            Controls.Add(Addition);
            Controls.Add(Dot);
            Controls.Add(N00);
            Controls.Add(N0);
            Controls.Add(N9);
            Controls.Add(N8);
            Controls.Add(N7);
            Controls.Add(N6);
            Controls.Add(N5);
            Controls.Add(N4);
            Controls.Add(N3);
            Controls.Add(N2);
            Controls.Add(N1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button N1;
        private Button N2;
        private Button N3;
        private Button N4;
        private Button N5;
        private Button N6;
        private Button N7;
        private Button N8;
        private Button N9;
        private Button N0;
        private Button N00;
        private Button Dot;
        private Button Addition;
        private Button Equals;
        private Button Subtraction;
        private Button Multiplication;
        private Button Division;
        private Button Clear;
    }
}
