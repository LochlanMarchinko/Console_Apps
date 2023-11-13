namespace _2d_Game
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
            components = new System.ComponentModel.Container();
            pbGround = new PictureBox();
            pbPlayer = new PictureBox();
            tmrGravity = new System.Windows.Forms.Timer(components);
            tmrUp = new System.Windows.Forms.Timer(components);
            tmrRight = new System.Windows.Forms.Timer(components);
            tmrLeft = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer).BeginInit();
            SuspendLayout();
            // 
            // pbGround
            // 
            pbGround.BackColor = Color.FromArgb(128, 74, 0);
            pbGround.Location = new Point(-37, 385);
            pbGround.Name = "pbGround";
            pbGround.Size = new Size(845, 179);
            pbGround.TabIndex = 0;
            pbGround.TabStop = false;
            // 
            // pbPlayer
            // 
            pbPlayer.BackColor = Color.Coral;
            pbPlayer.Location = new Point(269, 177);
            pbPlayer.Name = "pbPlayer";
            pbPlayer.Size = new Size(50, 50);
            pbPlayer.TabIndex = 1;
            pbPlayer.TabStop = false;
            pbPlayer.Click += pbPlayer_Click;
            // 
            // tmrGravity
            // 
            tmrGravity.Enabled = true;
            tmrGravity.Interval = 10;
            tmrGravity.Tick += tmrGravity_Tick;
            // 
            // tmrUp
            // 
            tmrUp.Interval = 10;
            tmrUp.Tick += tmrUp_Tick;
            // 
            // tmrRight
            // 
            tmrRight.Interval = 10;
            tmrRight.Tick += tmrRight_Tick;
            // 
            // tmrLeft
            // 
            tmrLeft.Interval = 10;
            tmrLeft.Tick += tmrLeft_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 110, 255);
            ClientSize = new Size(600, 540);
            Controls.Add(pbPlayer);
            Controls.Add(pbGround);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbGround;
        private PictureBox pbPlayer;
        private System.Windows.Forms.Timer tmrGravity;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrLeft;
    }
}