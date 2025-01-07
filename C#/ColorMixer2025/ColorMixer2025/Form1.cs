namespace ColorMixer2025
{
    public partial class Form1 : Form
    {
        private int redValue = 0;
        private int greenValue = 0;
        private int blueValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            redValue = (int)numericUpDownRed.Value;
            pictureBoxRed.BackColor = Color.FromArgb(redValue, 0, 0);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            greenValue = (int)numericUpDownGreen.Value;
            pictureBoxGreen.BackColor = Color.FromArgb(0, greenValue, 0);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            blueValue = (int)numericUpDownGreen.Value;
            pictureBoxBlue.BackColor = Color.FromArgb(0, 0, blueValue);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            numericUpDownRed.Value = trackBarRed.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            numericUpDownGreen.Value = trackBarGreen.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            numericUpDownBlue.Value = trackBarBlue.Value;
        }
    }
}