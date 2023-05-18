namespace CalculatorProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PnlTitle = new Panel();
            button2 = new Button();
            button1 = new Button();
            BtnExit = new Button();
            PnlHistory = new Panel();
            richTextBox1 = new RichTextBox();
            BtnClearHistory = new Button();
            panel1 = new Panel();
            BtnMenu = new Button();
            BtnHistory = new Button();
            NumberDisplay = new TextBox();
            SumDisplay = new TextBox();
            button3 = new Button();
            BtnBack = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            BtnPercent = new Button();
            BtnCE = new Button();
            BtnC = new Button();
            BtnDivide = new Button();
            BtnPowerOfX = new Button();
            BtnPowerOf2 = new Button();
            BtnSquareRoot = new Button();
            BtnMultiply = new Button();
            BtnNumber7 = new Button();
            BtnSubtract = new Button();
            BtnNumber4 = new Button();
            BtnNumber8 = new Button();
            BtnNumber5 = new Button();
            BtnNumber9 = new Button();
            BtnNumber6 = new Button();
            BtnAdd = new Button();
            BtnNumber1 = new Button();
            BtnEquals = new Button();
            BtnPM = new Button();
            BtnNumber2 = new Button();
            BtnNumber0 = new Button();
            BtnNumber3 = new Button();
            BtnDecimal = new Button();
            PnlTitle.SuspendLayout();
            PnlHistory.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitle
            // 
            PnlTitle.Controls.Add(button2);
            PnlTitle.Controls.Add(button1);
            PnlTitle.Controls.Add(BtnExit);
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Margin = new Padding(0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(487, 60);
            PnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(337, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(50, 60);
            button2.TabIndex = 2;
            button2.Text = "−";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(387, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 60);
            button1.TabIndex = 1;
            button1.Text = "□";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnExit
            // 
            BtnExit.Dock = DockStyle.Right;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.White;
            BtnExit.Location = new Point(437, 0);
            BtnExit.Margin = new Padding(0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(50, 60);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "×";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // PnlHistory
            // 
            PnlHistory.Controls.Add(richTextBox1);
            PnlHistory.Controls.Add(BtnClearHistory);
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 751);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(487, 5);
            PnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(38, 36, 36);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
            richTextBox1.Size = new Size(487, 0);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // BtnClearHistory
            // 
            BtnClearHistory.Dock = DockStyle.Bottom;
            BtnClearHistory.FlatAppearance.BorderSize = 0;
            BtnClearHistory.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnClearHistory.FlatStyle = FlatStyle.Flat;
            BtnClearHistory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClearHistory.ForeColor = Color.White;
            BtnClearHistory.Image = (Image)resources.GetObject("BtnClearHistory.Image");
            BtnClearHistory.Location = new Point(0, -55);
            BtnClearHistory.Margin = new Padding(0);
            BtnClearHistory.Name = "BtnClearHistory";
            BtnClearHistory.Size = new Size(487, 60);
            BtnClearHistory.TabIndex = 3;
            BtnClearHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnMenu);
            panel1.Controls.Add(BtnHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 60);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 60);
            panel1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            BtnMenu.Dock = DockStyle.Left;
            BtnMenu.FlatAppearance.BorderSize = 0;
            BtnMenu.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnMenu.FlatStyle = FlatStyle.Flat;
            BtnMenu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMenu.ForeColor = Color.White;
            BtnMenu.Image = Properties.Resources.menu;
            BtnMenu.Location = new Point(0, 0);
            BtnMenu.Margin = new Padding(0);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(50, 60);
            BtnMenu.TabIndex = 2;
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += button3_Click;
            // 
            // BtnHistory
            // 
            BtnHistory.Dock = DockStyle.Right;
            BtnHistory.FlatAppearance.BorderSize = 0;
            BtnHistory.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnHistory.FlatStyle = FlatStyle.Flat;
            BtnHistory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHistory.ForeColor = Color.White;
            BtnHistory.Image = (Image)resources.GetObject("BtnHistory.Image");
            BtnHistory.Location = new Point(437, 0);
            BtnHistory.Margin = new Padding(0);
            BtnHistory.Name = "BtnHistory";
            BtnHistory.Size = new Size(50, 60);
            BtnHistory.TabIndex = 0;
            BtnHistory.UseVisualStyleBackColor = true;
            // 
            // NumberDisplay
            // 
            NumberDisplay.BackColor = Color.FromArgb(38, 36, 36);
            NumberDisplay.BorderStyle = BorderStyle.None;
            NumberDisplay.Dock = DockStyle.Top;
            NumberDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NumberDisplay.ForeColor = Color.White;
            NumberDisplay.Location = new Point(0, 120);
            NumberDisplay.Margin = new Padding(0);
            NumberDisplay.Multiline = true;
            NumberDisplay.Name = "NumberDisplay";
            NumberDisplay.Size = new Size(487, 45);
            NumberDisplay.TabIndex = 3;
            NumberDisplay.Text = "0";
            NumberDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // SumDisplay
            // 
            SumDisplay.BackColor = Color.FromArgb(38, 36, 36);
            SumDisplay.BorderStyle = BorderStyle.None;
            SumDisplay.Dock = DockStyle.Top;
            SumDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SumDisplay.ForeColor = Color.White;
            SumDisplay.Location = new Point(0, 165);
            SumDisplay.Margin = new Padding(0);
            SumDisplay.Multiline = true;
            SumDisplay.Name = "SumDisplay";
            SumDisplay.Size = new Size(487, 57);
            SumDisplay.TabIndex = 4;
            SumDisplay.Text = "0";
            SumDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(38, 36, 36);
            button3.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(414, 222);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(60, 40);
            button3.TabIndex = 5;
            button3.Text = "M~";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(65, 60, 60);
            BtnBack.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Image = Properties.Resources.clear__1_;
            BtnBack.Location = new Point(366, 262);
            BtnBack.Margin = new Padding(0);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(110, 60);
            BtnBack.TabIndex = 6;
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(38, 36, 36);
            button5.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(333, 222);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(60, 40);
            button5.TabIndex = 7;
            button5.Text = "MS";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(38, 36, 36);
            button6.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(252, 222);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(60, 40);
            button6.TabIndex = 7;
            button6.Text = "M-";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(38, 36, 36);
            button7.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(171, 222);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(60, 40);
            button7.TabIndex = 7;
            button7.Text = "M+";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(38, 36, 36);
            button8.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(90, 222);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(60, 40);
            button8.TabIndex = 7;
            button8.Text = "MR";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(38, 36, 36);
            button9.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(9, 222);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(60, 40);
            button9.TabIndex = 7;
            button9.Text = "MC";
            button9.UseVisualStyleBackColor = false;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(65, 60, 60);
            BtnPercent.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPercent.Location = new Point(9, 262);
            BtnPercent.Margin = new Padding(0);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(110, 60);
            BtnPercent.TabIndex = 6;
            BtnPercent.Text = "%";
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += button4_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = Color.FromArgb(65, 60, 60);
            BtnCE.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnCE.FlatAppearance.BorderSize = 0;
            BtnCE.FlatStyle = FlatStyle.Flat;
            BtnCE.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCE.Location = new Point(128, 262);
            BtnCE.Margin = new Padding(0);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(110, 60);
            BtnCE.TabIndex = 6;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += button4_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.FromArgb(65, 60, 60);
            BtnC.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnC.FlatAppearance.BorderSize = 0;
            BtnC.FlatStyle = FlatStyle.Flat;
            BtnC.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnC.Location = new Point(247, 262);
            BtnC.Margin = new Padding(0);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(110, 60);
            BtnC.TabIndex = 6;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += button4_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = Color.FromArgb(65, 60, 60);
            BtnDivide.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnDivide.FlatAppearance.BorderSize = 0;
            BtnDivide.FlatStyle = FlatStyle.Flat;
            BtnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivide.Location = new Point(366, 333);
            BtnDivide.Margin = new Padding(0);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(110, 60);
            BtnDivide.TabIndex = 6;
            BtnDivide.Text = "÷";
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += button4_Click;
            // 
            // BtnPowerOfX
            // 
            BtnPowerOfX.BackColor = Color.FromArgb(65, 60, 60);
            BtnPowerOfX.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPowerOfX.FlatAppearance.BorderSize = 0;
            BtnPowerOfX.FlatStyle = FlatStyle.Flat;
            BtnPowerOfX.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPowerOfX.Location = new Point(9, 333);
            BtnPowerOfX.Margin = new Padding(0);
            BtnPowerOfX.Name = "BtnPowerOfX";
            BtnPowerOfX.Size = new Size(110, 60);
            BtnPowerOfX.TabIndex = 6;
            BtnPowerOfX.Text = "^";
            BtnPowerOfX.UseVisualStyleBackColor = false;
            BtnPowerOfX.Click += button4_Click;
            // 
            // BtnPowerOf2
            // 
            BtnPowerOf2.BackColor = Color.FromArgb(65, 60, 60);
            BtnPowerOf2.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPowerOf2.FlatAppearance.BorderSize = 0;
            BtnPowerOf2.FlatStyle = FlatStyle.Flat;
            BtnPowerOf2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPowerOf2.Location = new Point(121, 334);
            BtnPowerOf2.Margin = new Padding(0);
            BtnPowerOf2.Name = "BtnPowerOf2";
            BtnPowerOf2.Size = new Size(110, 60);
            BtnPowerOf2.TabIndex = 6;
            BtnPowerOf2.Text = "^2";
            BtnPowerOf2.UseVisualStyleBackColor = false;
            BtnPowerOf2.Click += button4_Click;
            // 
            // BtnSquareRoot
            // 
            BtnSquareRoot.BackColor = Color.FromArgb(65, 60, 60);
            BtnSquareRoot.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnSquareRoot.FlatAppearance.BorderSize = 0;
            BtnSquareRoot.FlatStyle = FlatStyle.Flat;
            BtnSquareRoot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSquareRoot.Location = new Point(247, 333);
            BtnSquareRoot.Margin = new Padding(0);
            BtnSquareRoot.Name = "BtnSquareRoot";
            BtnSquareRoot.Size = new Size(110, 60);
            BtnSquareRoot.TabIndex = 6;
            BtnSquareRoot.Text = "√x";
            BtnSquareRoot.UseVisualStyleBackColor = false;
            BtnSquareRoot.Click += button4_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.FromArgb(65, 60, 60);
            BtnMultiply.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnMultiply.FlatAppearance.BorderSize = 0;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMultiply.Location = new Point(366, 404);
            BtnMultiply.Margin = new Padding(0);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(110, 60);
            BtnMultiply.TabIndex = 6;
            BtnMultiply.Text = "×";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += button4_Click;
            // 
            // BtnNumber7
            // 
            BtnNumber7.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber7.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber7.FlatAppearance.BorderSize = 0;
            BtnNumber7.FlatStyle = FlatStyle.Flat;
            BtnNumber7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber7.Location = new Point(9, 404);
            BtnNumber7.Margin = new Padding(0);
            BtnNumber7.Name = "BtnNumber7";
            BtnNumber7.Size = new Size(110, 60);
            BtnNumber7.TabIndex = 6;
            BtnNumber7.Text = "7";
            BtnNumber7.UseVisualStyleBackColor = false;
            BtnNumber7.Click += BtnNum_Click;
            // 
            // BtnSubtract
            // 
            BtnSubtract.BackColor = Color.FromArgb(65, 60, 60);
            BtnSubtract.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnSubtract.FlatAppearance.BorderSize = 0;
            BtnSubtract.FlatStyle = FlatStyle.Flat;
            BtnSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubtract.Location = new Point(366, 475);
            BtnSubtract.Margin = new Padding(0);
            BtnSubtract.Name = "BtnSubtract";
            BtnSubtract.Size = new Size(110, 60);
            BtnSubtract.TabIndex = 6;
            BtnSubtract.Text = "−";
            BtnSubtract.UseVisualStyleBackColor = false;
            BtnSubtract.Click += button4_Click;
            // 
            // BtnNumber4
            // 
            BtnNumber4.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber4.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber4.FlatAppearance.BorderSize = 0;
            BtnNumber4.FlatStyle = FlatStyle.Flat;
            BtnNumber4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber4.Location = new Point(9, 475);
            BtnNumber4.Margin = new Padding(0);
            BtnNumber4.Name = "BtnNumber4";
            BtnNumber4.Size = new Size(110, 60);
            BtnNumber4.TabIndex = 6;
            BtnNumber4.Text = "4";
            BtnNumber4.UseVisualStyleBackColor = false;
            BtnNumber4.Click += BtnNum_Click;
            // 
            // BtnNumber8
            // 
            BtnNumber8.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber8.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber8.FlatAppearance.BorderSize = 0;
            BtnNumber8.FlatStyle = FlatStyle.Flat;
            BtnNumber8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber8.Location = new Point(128, 404);
            BtnNumber8.Margin = new Padding(0);
            BtnNumber8.Name = "BtnNumber8";
            BtnNumber8.Size = new Size(110, 60);
            BtnNumber8.TabIndex = 6;
            BtnNumber8.Text = "8";
            BtnNumber8.UseVisualStyleBackColor = false;
            BtnNumber8.Click += BtnNum_Click;
            // 
            // BtnNumber5
            // 
            BtnNumber5.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber5.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber5.FlatAppearance.BorderSize = 0;
            BtnNumber5.FlatStyle = FlatStyle.Flat;
            BtnNumber5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber5.Location = new Point(128, 475);
            BtnNumber5.Margin = new Padding(0);
            BtnNumber5.Name = "BtnNumber5";
            BtnNumber5.Size = new Size(110, 60);
            BtnNumber5.TabIndex = 6;
            BtnNumber5.Text = "5";
            BtnNumber5.UseVisualStyleBackColor = false;
            BtnNumber5.Click += BtnNum_Click;
            // 
            // BtnNumber9
            // 
            BtnNumber9.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber9.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber9.FlatAppearance.BorderSize = 0;
            BtnNumber9.FlatStyle = FlatStyle.Flat;
            BtnNumber9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber9.Location = new Point(247, 404);
            BtnNumber9.Margin = new Padding(0);
            BtnNumber9.Name = "BtnNumber9";
            BtnNumber9.Size = new Size(110, 60);
            BtnNumber9.TabIndex = 6;
            BtnNumber9.Text = "9";
            BtnNumber9.UseVisualStyleBackColor = false;
            BtnNumber9.Click += BtnNum_Click;
            // 
            // BtnNumber6
            // 
            BtnNumber6.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber6.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber6.FlatAppearance.BorderSize = 0;
            BtnNumber6.FlatStyle = FlatStyle.Flat;
            BtnNumber6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber6.Location = new Point(247, 475);
            BtnNumber6.Margin = new Padding(0);
            BtnNumber6.Name = "BtnNumber6";
            BtnNumber6.Size = new Size(110, 60);
            BtnNumber6.TabIndex = 6;
            BtnNumber6.Text = "6";
            BtnNumber6.UseVisualStyleBackColor = false;
            BtnNumber6.Click += BtnNum_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(65, 60, 60);
            BtnAdd.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.Location = new Point(366, 544);
            BtnAdd.Margin = new Padding(0);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(110, 60);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += button4_Click;
            // 
            // BtnNumber1
            // 
            BtnNumber1.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber1.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber1.FlatAppearance.BorderSize = 0;
            BtnNumber1.FlatStyle = FlatStyle.Flat;
            BtnNumber1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber1.Location = new Point(9, 544);
            BtnNumber1.Margin = new Padding(0);
            BtnNumber1.Name = "BtnNumber1";
            BtnNumber1.Size = new Size(110, 60);
            BtnNumber1.TabIndex = 6;
            BtnNumber1.Text = "1";
            BtnNumber1.UseVisualStyleBackColor = false;
            BtnNumber1.Click += BtnNum_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.FromArgb(65, 60, 60);
            BtnEquals.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnEquals.FlatAppearance.BorderSize = 0;
            BtnEquals.FlatStyle = FlatStyle.Flat;
            BtnEquals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEquals.Location = new Point(366, 615);
            BtnEquals.Margin = new Padding(0);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(110, 60);
            BtnEquals.TabIndex = 6;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += button4_Click;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.FromArgb(65, 60, 60);
            BtnPM.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPM.Location = new Point(9, 615);
            BtnPM.Margin = new Padding(0);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(110, 60);
            BtnPM.TabIndex = 6;
            BtnPM.Text = "+/−";
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += button4_Click;
            // 
            // BtnNumber2
            // 
            BtnNumber2.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber2.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber2.FlatAppearance.BorderSize = 0;
            BtnNumber2.FlatStyle = FlatStyle.Flat;
            BtnNumber2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber2.Location = new Point(128, 544);
            BtnNumber2.Margin = new Padding(0);
            BtnNumber2.Name = "BtnNumber2";
            BtnNumber2.Size = new Size(110, 60);
            BtnNumber2.TabIndex = 6;
            BtnNumber2.Text = "2";
            BtnNumber2.UseVisualStyleBackColor = false;
            BtnNumber2.Click += BtnNum_Click;
            // 
            // BtnNumber0
            // 
            BtnNumber0.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber0.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber0.FlatAppearance.BorderSize = 0;
            BtnNumber0.FlatStyle = FlatStyle.Flat;
            BtnNumber0.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber0.Location = new Point(128, 615);
            BtnNumber0.Margin = new Padding(0);
            BtnNumber0.Name = "BtnNumber0";
            BtnNumber0.Size = new Size(110, 60);
            BtnNumber0.TabIndex = 6;
            BtnNumber0.Text = "0";
            BtnNumber0.UseVisualStyleBackColor = false;
            BtnNumber0.Click += BtnNum_Click;
            // 
            // BtnNumber3
            // 
            BtnNumber3.BackColor = Color.FromArgb(65, 60, 60);
            BtnNumber3.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber3.FlatAppearance.BorderSize = 0;
            BtnNumber3.FlatStyle = FlatStyle.Flat;
            BtnNumber3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber3.Location = new Point(247, 544);
            BtnNumber3.Margin = new Padding(0);
            BtnNumber3.Name = "BtnNumber3";
            BtnNumber3.Size = new Size(110, 60);
            BtnNumber3.TabIndex = 6;
            BtnNumber3.Text = "3";
            BtnNumber3.UseVisualStyleBackColor = false;
            BtnNumber3.Click += BtnNum_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.BackColor = Color.FromArgb(65, 60, 60);
            BtnDecimal.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnDecimal.FlatAppearance.BorderSize = 0;
            BtnDecimal.FlatStyle = FlatStyle.Flat;
            BtnDecimal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDecimal.Location = new Point(247, 615);
            BtnDecimal.Margin = new Padding(0);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(110, 60);
            BtnDecimal.TabIndex = 6;
            BtnDecimal.Text = ".";
            BtnDecimal.UseVisualStyleBackColor = false;
            BtnDecimal.Click += BtnNum_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 36, 36);
            ClientSize = new Size(487, 756);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnNumber6);
            Controls.Add(BtnSquareRoot);
            Controls.Add(BtnNumber3);
            Controls.Add(BtnNumber9);
            Controls.Add(BtnC);
            Controls.Add(BtnNumber0);
            Controls.Add(BtnNumber5);
            Controls.Add(BtnPowerOf2);
            Controls.Add(BtnNumber2);
            Controls.Add(BtnNumber8);
            Controls.Add(BtnPM);
            Controls.Add(BtnCE);
            Controls.Add(BtnNumber4);
            Controls.Add(BtnEquals);
            Controls.Add(BtnPowerOfX);
            Controls.Add(BtnSubtract);
            Controls.Add(BtnNumber1);
            Controls.Add(BtnDivide);
            Controls.Add(BtnAdd);
            Controls.Add(BtnNumber7);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnPercent);
            Controls.Add(BtnBack);
            Controls.Add(button3);
            Controls.Add(SumDisplay);
            Controls.Add(NumberDisplay);
            Controls.Add(panel1);
            Controls.Add(PnlHistory);
            Controls.Add(PnlTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Click += BtnNum_Click;
            PnlTitle.ResumeLayout(false);
            PnlHistory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitle;
        private Panel PnlHistory;
        private Button BtnExit;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button BtnMenu;
        private Button BtnHistory;
        private TextBox NumberDisplay;
        private TextBox SumDisplay;
        private RichTextBox richTextBox1;
        private Button BtnClearHistory;
        private Button button3;
        private Button BtnBack;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button BtnPercent;
        private Button BtnCE;
        private Button BtnC;
        private Button BtnDivide;
        private Button BtnPowerOfX;
        private Button BtnPowerOf2;
        private Button BtnSquareRoot;
        private Button BtnMultiply;
        private Button BtnNumber7;
        private Button BtnSubtract;
        private Button BtnNumber4;
        private Button BtnNumber8;
        private Button BtnNumber5;
        private Button BtnNumber9;
        private Button BtnNumber6;
        private Button BtnAdd;
        private Button BtnNumber1;
        private Button BtnEquals;
        private Button BtnPM;
        private Button BtnNumber2;
        private Button BtnNumber0;
        private Button BtnNumber3;
        private Button BtnDecimal;
    }
}