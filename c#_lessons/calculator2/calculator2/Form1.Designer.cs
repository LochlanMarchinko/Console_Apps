namespace calculator2
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
            button1 = new Button();
            ResultTextbox = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonClear = new Button();
            buttonMult = new Button();
            buttonDiv = new Button();
            buttonMin = new Button();
            ButtonPlus = new Button();
            buttonEqual = new Button();
            button0 = new Button();
            buttonPercent = new Button();
            informationalLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 113);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResultTextbox
            // 
            ResultTextbox.BackColor = Color.LightCyan;
            ResultTextbox.Enabled = false;
            ResultTextbox.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            ResultTextbox.ForeColor = SystemColors.ControlText;
            ResultTextbox.Location = new Point(12, 12);
            ResultTextbox.Multiline = true;
            ResultTextbox.Name = "ResultTextbox";
            ResultTextbox.ReadOnly = true;
            ResultTextbox.Size = new Size(500, 95);
            ResultTextbox.TabIndex = 1;
            ResultTextbox.TextChanged += ResultTextbox_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(113, 113);
            button2.Name = "button2";
            button2.Size = new Size(95, 95);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(214, 113);
            button3.Name = "button3";
            button3.Size = new Size(95, 95);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(12, 214);
            button4.Name = "button4";
            button4.Size = new Size(95, 95);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCyan;
            button5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(113, 214);
            button5.Name = "button5";
            button5.Size = new Size(95, 95);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(214, 214);
            button6.Name = "button6";
            button6.Size = new Size(95, 95);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightCyan;
            button7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(12, 315);
            button7.Name = "button7";
            button7.Size = new Size(95, 95);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightCyan;
            button8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(113, 315);
            button8.Name = "button8";
            button8.Size = new Size(95, 95);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightCyan;
            button9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(214, 315);
            button9.Name = "button9";
            button9.Size = new Size(95, 95);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.LightCyan;
            buttonClear.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = SystemColors.ControlText;
            buttonClear.Location = new Point(416, 315);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 95);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonMult
            // 
            buttonMult.BackColor = Color.LightCyan;
            buttonMult.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMult.ForeColor = SystemColors.ControlText;
            buttonMult.Location = new Point(315, 214);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(95, 95);
            buttonMult.TabIndex = 13;
            buttonMult.Text = "X";
            buttonMult.UseVisualStyleBackColor = false;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.LightCyan;
            buttonDiv.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDiv.ForeColor = SystemColors.ControlText;
            buttonDiv.Location = new Point(417, 214);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(95, 95);
            buttonDiv.TabIndex = 12;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.LightCyan;
            buttonMin.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMin.ForeColor = SystemColors.ControlText;
            buttonMin.Location = new Point(417, 113);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(95, 95);
            buttonMin.TabIndex = 11;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = false;
            buttonMin.Click += buttonMin_Click;
            // 
            // ButtonPlus
            // 
            ButtonPlus.BackColor = Color.LightCyan;
            ButtonPlus.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPlus.ForeColor = SystemColors.ControlText;
            ButtonPlus.Location = new Point(315, 113);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(95, 95);
            ButtonPlus.TabIndex = 10;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = false;
            ButtonPlus.Click += ButtonPlus_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = Color.LightCyan;
            buttonEqual.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEqual.ForeColor = SystemColors.ControlText;
            buttonEqual.Location = new Point(315, 414);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(197, 95);
            buttonEqual.TabIndex = 15;
            buttonEqual.Text = "Equal";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.LightCyan;
            button0.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button0.ForeColor = SystemColors.ControlText;
            button0.Location = new Point(12, 414);
            button0.Name = "button0";
            button0.Size = new Size(297, 95);
            button0.TabIndex = 16;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.BackColor = Color.LightCyan;
            buttonPercent.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPercent.ForeColor = SystemColors.ControlText;
            buttonPercent.Location = new Point(315, 315);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(95, 95);
            buttonPercent.TabIndex = 17;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = false;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // informationalLabel
            // 
            informationalLabel.AutoSize = true;
            informationalLabel.ForeColor = Color.Red;
            informationalLabel.Location = new Point(12, 52);
            informationalLabel.Name = "informationalLabel";
            informationalLabel.Size = new Size(0, 15);
            informationalLabel.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(524, 521);
            Controls.Add(informationalLabel);
            Controls.Add(buttonPercent);
            Controls.Add(button0);
            Controls.Add(buttonEqual);
            Controls.Add(buttonClear);
            Controls.Add(buttonMult);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMin);
            Controls.Add(ButtonPlus);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ResultTextbox);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ResultTextbox;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonClear;
        private Button buttonMult;
        private Button buttonDiv;
        private Button buttonMin;
        private Button ButtonPlus;
        private Button buttonEqual;
        private Button button0;
        private Button buttonPercent;
        private Label informationalLabel;
    }
}