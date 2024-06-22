using System.Data;

namespace CalculatorActivity
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void DotBtn_Click(Object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void OneBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void TwoBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void ThreeBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void FourBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void FiveBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void SixBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void SevenBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void EightBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void NineBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void ClearBtn_Click(Object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }
        private void MultiBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void DivBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void MinusBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void AddBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            TxtBox.Clear();

            Button button = (Button)sender;
            TxtBox.Text = TxtBox.Text + button.Text;
        }
        private void NegateBtn_Click(Object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }
        private void EqualBtn_Click(Object sender, EventArgs e)
        {
            string equation = TxtBox.Text;
            var result = new DataTable().Compute(equation, null);
            TxtBox.Text = result.ToString();
        }
        private void EraseBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1);
        }
    }
}
