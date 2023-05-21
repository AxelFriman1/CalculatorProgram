using CustomButton;
using System.Runtime.InteropServices;

namespace CalculatorProgram
{
    public partial class Form1 : Form
    {
        Double Result = 0;
        string Operation = string.Empty;
        string FirstNum, SecondNum;
        bool EnterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (SumDisplay.Text == "0" || EnterValue)  //SUMDISPLAY = TXTDISPLAY1
            {
                SumDisplay.Text = string.Empty;
            }
            EnterValue = false;
            CustomButton1 button = (CustomButton1)sender;
            if (button.Text == ".")
            {
                if (!SumDisplay.Text.Contains("."))
                {
                    SumDisplay.Text = SumDisplay.Text + button.Text;
                }
            }
            else
            {
                SumDisplay.Text = SumDisplay.Text + button.Text;
            }

        }
        private void BtnOperation_Click(object sender, EventArgs e)
        {
            if (Result != 0)
            {
                BtnEquals.PerformClick();
            }
            else
            {
                Result = Double.Parse(SumDisplay.Text);
            }
            CustomButton1 button = (CustomButton1)sender;
            Operation = button.Text;
            EnterValue = true;
            if (SumDisplay.Text != "0")
            {
                NumberDisplay.Text = FirstNum = $"{Result}{Operation}";
                SumDisplay.Text = string.Empty;
            }
        }
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            SecondNum = SumDisplay.Text;
            NumberDisplay.Text = $"{NumberDisplay.Text} {SumDisplay.Text}=";
            if (SumDisplay.Text != string.Empty)
            {
                if (SumDisplay.Text == "0")
                {
                    NumberDisplay.Text = string.Empty;
                }
                switch (Operation)
                {
                    case "+":
                        SumDisplay.Text = (Result + Double.Parse(SumDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {SumDisplay.Text} \n");
                        break;
                    case "−":
                        SumDisplay.Text = (Result - Double.Parse(SumDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {SumDisplay.Text} \n");
                        break;
                    case "×":
                        SumDisplay.Text = (Result * Double.Parse(SumDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {SumDisplay.Text} \n");
                        break;
                    case "÷":
                        SumDisplay.Text = (Result / Double.Parse(SumDisplay.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{FirstNum}{SecondNum} = {SumDisplay.Text} \n");
                        break;
                    default:
                        NumberDisplay.Text = $"{SumDisplay.Text}=";
                        break;
                }

                Result = Double.Parse(SumDisplay.Text);
                Operation = string.Empty;
            }
        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 550 : 5;
        }
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            RtBoxDisplayHistory.Text = "History Empty!";
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (SumDisplay.Text.Length > 0)
            {
                SumDisplay.Text = SumDisplay.Text.Remove(SumDisplay.Text.Length - 1, 1);
            }
            if (SumDisplay.Text == string.Empty)
            {
                SumDisplay.Text = "0";
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            SumDisplay.Text = "0";
            NumberDisplay.Text = string.Empty;
            Result = 0;
        }
        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            SumDisplay.Text = "0";
        }

        private void BtnMathFunctions_Click(object sender, EventArgs e)
        {
            CustomButton1 button = (CustomButton1)sender;
            Operation = button.Text;
            switch (Operation)
            {
                case "√x":
                    NumberDisplay.Text = $"√({SumDisplay.Text})";
                    SumDisplay.Text = Convert.ToString(Math.Sqrt(Double.Parse(SumDisplay.Text)));
                    break;
                case "^2":
                    NumberDisplay.Text = $"({SumDisplay.Text})^2";
                    SumDisplay.Text = Convert.ToString(Convert.ToDouble(SumDisplay.Text) * Convert.ToDouble(SumDisplay.Text));
                    break;
                case "1/x":
                    NumberDisplay.Text = $"1/({SumDisplay.Text})";
                    SumDisplay.Text = Convert.ToString(1.0 / Convert.ToDouble(SumDisplay.Text));
                    break;
                case "%":
                    NumberDisplay.Text = $"%({SumDisplay.Text})";
                    SumDisplay.Text = Convert.ToString(Convert.ToDouble(SumDisplay.Text) / Convert.ToDouble(100));
                    break;
                case "±":
                    SumDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(SumDisplay.Text));
                    break;
            }
            RtBoxDisplayHistory.AppendText($"{NumberDisplay.Text} = {SumDisplay.Text} \n");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}