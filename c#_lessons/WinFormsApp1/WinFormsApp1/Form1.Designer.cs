namespace WinFormsApp1
{
    partial class Form1
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btnMin = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnmult = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(12, 12);
            txtTotal.MaxLength = 32000;
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(500, 80);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 98);
            btn1.Name = "btn1";
            btn1.Size = new Size(95, 95);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(113, 98);
            btn2.Name = "btn2";
            btn2.Size = new Size(95, 95);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(214, 98);
            btn3.Name = "btn3";
            btn3.Size = new Size(95, 95);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(316, 98);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(95, 95);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(315, 401);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(197, 95);
            btnEqual.TabIndex = 5;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.Location = new Point(316, 199);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(95, 95);
            btnMin.TabIndex = 9;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(214, 199);
            btn6.Name = "btn6";
            btn6.Size = new Size(95, 95);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(113, 199);
            btn5.Name = "btn5";
            btn5.Size = new Size(95, 95);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 199);
            btn4.Name = "btn4";
            btn4.Size = new Size(95, 95);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnmult
            // 
            btnmult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnmult.Location = new Point(417, 98);
            btnmult.Name = "btnmult";
            btnmult.Size = new Size(95, 95);
            btnmult.TabIndex = 14;
            btnmult.Text = "*";
            btnmult.UseVisualStyleBackColor = true;
            
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(214, 300);
            btn9.Name = "btn9";
            btn9.Size = new Size(95, 95);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(113, 300);
            btn8.Name = "btn8";
            btn8.Size = new Size(95, 95);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 300);
            btn7.Name = "btn7";
            btn7.Size = new Size(95, 95);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(316, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(196, 95);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btsEqual_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(417, 199);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(95, 95);
            btnDiv.TabIndex = 19;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 401);
            btn0.Name = "btn0";
            btn0.Size = new Size(297, 95);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 534);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btn0);
            Controls.Add(btnmult);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMin);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnMin;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnmult;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnClear;
        private Button btnDiv;
        private Button btn0;
    }
}