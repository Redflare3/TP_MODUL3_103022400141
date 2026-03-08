namespace TP_MODUL3_103022400141
{
    public partial class Form1 : Form
    {
        string input = "";
        int firstNumber = 0;
        bool isPlusClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                firstNumber = int.Parse(input);
                input = "";
                isPlusClicked = true;
                textBox1.Text = "+";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            textBox1.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isPlusClicked && input != "")
            {
                int secondNumber = int.Parse(input);
                int result = firstNumber + secondNumber;

                textBox1.Text = result.ToString();

                input = result.ToString();
                isPlusClicked = false;
            }
        }
    }
}
