using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        String option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button17.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
            switch (option)
            {


                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "mod":
                    textBox1.Text = (num1 % num2).ToString();
                    break;
                default:
                    break;


            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void steToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.textBox1.Width = 925;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 650;//1000;
            this.textBox1.Width = 580;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 650;//1000;
            this.textBox1.Width = 580;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you wan to exit", "Sceinec Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(this.textBox1.Text);
            logg = Math.Cos(logg);
            textBox1.Text = Convert.ToString(logg);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(x);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "3.141592653589976323";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(this.textBox1.Text);
            logg = Math.Log10(logg);
            textBox1.Text = Convert.ToString(logg);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(this.textBox1.Text);
            logg = Math.Sin(logg);
            textBox1.Text = Convert.ToString(logg);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(this.textBox1.Text);
            tan = Math.Tan(tan);
            textBox1.Text = Convert.ToString((double)tan);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            Text = Convert.ToString(a);
        }

      
    }
}
