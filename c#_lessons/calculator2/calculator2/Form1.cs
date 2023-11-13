namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal firstNumber, secondNumber, result;
        private void ResultTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveZero("1");
        }
        private void RemoveZero(string number)
        {if(informationalLabel.Text() != string.Empty) { informationalLabel.Text = string.Empty; }
            if (ResultTextbox.Text == "0")
            { ResultTextbox.Text = number; }
            else { ResultTextbox.Text += number; }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveZero("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveZero("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveZero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveZero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveZero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoveZero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RemoveZero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RemoveZero("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            RemoveZero("0");
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (ResultTextbox.Text.Trim() == string.Empty || ResultTextbox.Text.Trim() == "0")
                MessageBox.Show("Please enter valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firstNumber = Convert.ToDecimal(ResultTextbox.Text);

            ResultTextbox.Text = "";
            informationalLabel.Text = "Enter second value";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResultTextbox.Text = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
        }
    }
}