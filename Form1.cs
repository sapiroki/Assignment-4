using System.Numerics;
namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputTextBox.Text, out int number))
            {
                if (number >= 0)
                {
                    BigInteger factorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }

                    resultLabel.Visible = true;
                    resultLabel.Text = $"Factorial: {factorial}";
                }
                else
                {
                    MessageBox.Show("Please enter a nonnegative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}