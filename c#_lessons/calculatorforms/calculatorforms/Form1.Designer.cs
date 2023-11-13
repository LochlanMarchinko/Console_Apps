namespace calculatorforms
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
            textBox1 = new TextBox();
            btn1 = new Button();
            btnPlus = new Button();
            this.btnClear = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btn4 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            btnMin = new Button();
            btn7 = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 70);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 88);
            btn1.Name = "btn1";
            btn1.Size = new Size(95, 95);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(316, 88);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(95, 95);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(316, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(196, 95);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(215, 88);
            btn3.Name = "btn3";
            btn3.Size = new Size(95, 95);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button4_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(114, 88);
            btn2.Name = "btn2";
            btn2.Size = new Size(95, 95);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(114, 189);
            btn5.Name = "btn5";
            btn5.Size = new Size(95, 95);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(215, 189);
            btn6.Name = "btn6";
            btn6.Size = new Size(95, 95);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(417, 189);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(95, 95);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(316, 189);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(95, 95);
            btnMult.TabIndex = 7;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 189);
            btn4.Name = "btn4";
            btn4.Size = new Size(95, 95);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new Point(114, 290);
            this.btn8.Name = "btn8";
            this.btn8.Size = new Size(95, 95);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new Point(215, 290);
            this.btn9.Name = "btn9";
            this.btn9.Size = new Size(95, 95);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(417, 88);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(95, 95);
            btnMin.TabIndex = 13;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 290);
            btn7.Name = "btn7";
            btn7.Size = new Size(95, 95);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btnEql
            // 
            btnEql.Location = new Point(12, 391);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(500, 95);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 491);
            Controls.Add(btnEql);
            Controls.Add(this.btn8);
            Controls.Add(this.btn9);
            Controls.Add(btnMin);
            Controls.Add(btn7);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(this.btnClear);
            Controls.Add(btnPlus);
            Controls.Add(btn1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn1;
        private Button btnPlus;
        private Button button3;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Button btn6;
        private Button btnDiv;
        private Button btnMult;
        private Button btn4;
        private Button button11;
        private Button button12;
        private Button btnMin;
        private Button button14;
        private Button btn7;
        private Button btnEql;
    }
}