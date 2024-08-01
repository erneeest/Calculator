namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        public CalculatorClass cal = new CalculatorClass();

        private void btnEqual_Click(object sender, EventArgs e)
        {
            #region -- Operation --
            if (string.IsNullOrEmpty(txtBoxInput1.Text) || string.IsNullOrEmpty(txtBoxInput2.Text))
            {
                MessageBox.Show("Please fill in both input boxes.", "May error bossing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double num1 = Convert.ToDouble(txtBoxInput1.Text);
                    double num2 = Convert.ToDouble(txtBoxInput2.Text);
                    string operation = cbOperator.Text;

                    switch (operation)
                    {
                        case "+":
                            {
                                cal.CalculatorEvent += new Formula<double>(cal.GetSum);
                                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                                cal.CalculatorEvent -= new Formula<double>(cal.GetSum);
                                break;
                            }
                        case "-":
                            {
                                cal.CalculatorEvent += new Formula<double>(cal.GetDifference);
                                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                                cal.CalculatorEvent -= new Formula<double>(cal.GetDifference);
                                break;
                            }
                        case "*":
                            {
                                cal.CalculatorEvent += new Formula<double>(cal.GetProduct);
                                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                                cal.CalculatorEvent -= new Formula<double>(cal.GetProduct);
                                break;
                            }
                        case "/":
                            {
                                if (num2 == 0)
                                {
                                    MessageBox.Show("Division by zero is not allowed.", "May error bossing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    cal.CalculatorEvent += new Formula<double>(cal.GetQuotient);
                                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                                    cal.CalculatorEvent -= new Formula<double>(cal.GetQuotient);
                                }
                                break;
                            }
                        default:
                            MessageBox.Show("Please choose an operator.", "May error bossing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Beep();
                    MessageBox.Show("Please enter valid numbers in both input boxes.", "May error bossing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
        }
    }
}
