namespace MoreSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Convert user input to ints
            string num1 = TxtNumber1.Text;
            string num2 = TxtNumber2.Text;

            // Add numbers together and validate input
            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
            {
                int sum = number1 + number2;
                string result = sum.ToString();

                TxtResult.Text = result;
            }
            else
            {
                MessageBox.Show("Not a number, please enter a number");
            }
        }
    }
}
