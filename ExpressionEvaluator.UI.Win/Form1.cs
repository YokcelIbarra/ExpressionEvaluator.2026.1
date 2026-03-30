using ExpressionEvaluator.Core;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToDisplay(string value)
        {
            txtDisplay.Text += value;
        }

        private void btn0_Click(object sender, EventArgs e) => AddToDisplay("0");
        private void btn1_Click(object sender, EventArgs e) => AddToDisplay("1");
        private void btn2_Click(object sender, EventArgs e) => AddToDisplay("2");
        private void btn3_Click(object sender, EventArgs e) => AddToDisplay("3");
        private void btn4_Click(object sender, EventArgs e) => AddToDisplay("4");
        private void btn5_Click(object sender, EventArgs e) => AddToDisplay("5");
        private void btn6_Click(object sender, EventArgs e) => AddToDisplay("6");
        private void btn7_Click(object sender, EventArgs e) => AddToDisplay("7");
        private void btn8_Click(object sender, EventArgs e) => AddToDisplay("8");
        private void btn9_Click(object sender, EventArgs e) => AddToDisplay("9");

        private void btnPlus_Click(object sender, EventArgs e) => AddToDisplay("+");
        private void btnMinus_Click(object sender, EventArgs e) => AddToDisplay("-");
        private void btnMultiply_Click(object sender, EventArgs e) => AddToDisplay("*");
        private void btnDivide_Click(object sender, EventArgs e) => AddToDisplay("/");
        private void btnPower_Click(object sender, EventArgs e) => AddToDisplay("^");
        private void btnOpenParen_Click(object sender, EventArgs e) => AddToDisplay("(");
        private void btnCloseParen_Click(object sender, EventArgs e) => AddToDisplay(")");
        private void btnDot_Click(object sender, EventArgs e) => AddToDisplay(".");

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtDisplay.Text;
                double result = Evaluator.Evaluate(expression);
                txtDisplay.Text = $"{expression}={result}";
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }
    }
}