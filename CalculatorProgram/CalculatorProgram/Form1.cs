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
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 550 : 5;
        }
    }
}