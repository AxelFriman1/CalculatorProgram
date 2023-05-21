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
            if (NumberDisplay.Text == "0" || EnterValue)
            {
                NumberDisplay.Text = string.Empty;
            }
            EnterValue = false;

        }
    }
}