namespace _2d_Game
{
    public partial class Form1 : Form
    {
        bool isJumping = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if (!pbPlayer.Bounds.IntersectsWith(pbGround.Bounds) && isJumping == false)
            {
                pbPlayer.Top += 10;

            }
        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            pbPlayer.Top -= 10;
            isJumping = true;
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left += 10;
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left -= 10;
        }
    }
}