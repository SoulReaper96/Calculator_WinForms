namespace Calculator
{
    public partial class Calculator : Form
    {
        private double? Result = 0;
        private string? Operation = "";
        private string? CurrentEntry = "";
        private string? TotalEntry = "";

        public Calculator() => InitializeComponent();

        private void ButtonDigits_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                CurrentEntry += button.Text;
                textBox1.Text = TotalEntry + CurrentEntry;
            }
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Operation = button.Text;
                if (double.TryParse(CurrentEntry, out double number))
                {
                    Result = number;
                    TotalEntry = CurrentEntry + " " + Operation;
                    CurrentEntry = "";
                    textBox1.Text = TotalEntry;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            CurrentEntry = "";
            textBox1.Text = TotalEntry;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(CurrentEntry, out double number))
            {
                switch (Operation)
                {
                    case "+":
                        Result += number;
                        break;
                    case "-":
                        Result -= number;
                        break;
                    case "*":
                        Result *= number;
                        break;
                    case "/":
                        if (number != 0)
                        {
                            Result /= number;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                            return;
                        }
                        break;
                }
                textBox1.Text = Result.ToString();
                CurrentEntry = Result.ToString();
                TotalEntry = "";
                Operation = "";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (CurrentEntry.Length > 0)
            {
                CurrentEntry = CurrentEntry.Substring(0, CurrentEntry.Length - 1);
                textBox1.Text = CurrentEntry;
            }
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            CurrentEntry = "";
            TotalEntry = "";
            Result = 0;
            Operation = "";
            textBox1.Text = "";
        }
    }
}
