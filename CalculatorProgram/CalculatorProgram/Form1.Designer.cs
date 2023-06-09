﻿namespace CalculatorProgram
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
            RtBoxDisplayHistory = new RichTextBox();
            BtnClearHistory = new Button();
            panel1 = new Panel();
            BtnHistory = new Button();
            NumberDisplay = new TextBox();
            SumDisplay = new TextBox();
            BtnBackspace = new CustomButton.CustomButton1();
            customButton2 = new CustomButton.CustomButton1();
            customButton3 = new CustomButton.CustomButton1();
            customButton4 = new CustomButton.CustomButton1();
            customButton5 = new CustomButton.CustomButton1();
            customButton6 = new CustomButton.CustomButton1();
            customButton7 = new CustomButton.CustomButton1();
            BtnPercent = new CustomButton.CustomButton1();
            BtnClearEntry = new CustomButton.CustomButton1();
            BtnClear = new CustomButton.CustomButton1();
            BtnDivide = new CustomButton.CustomButton1();
            Btn1X = new CustomButton.CustomButton1();
            BtnPowerOf2 = new CustomButton.CustomButton1();
            BtnSquareRoot = new CustomButton.CustomButton1();
            BtnMultiply = new CustomButton.CustomButton1();
            BtnNumber7 = new CustomButton.CustomButton1();
            BtnSubtract = new CustomButton.CustomButton1();
            BtnNumber8 = new CustomButton.CustomButton1();
            BtnNumber4 = new CustomButton.CustomButton1();
            BtnNumber9 = new CustomButton.CustomButton1();
            BtnNumber5 = new CustomButton.CustomButton1();
            BtnNumber6 = new CustomButton.CustomButton1();
            BtnAdd = new CustomButton.CustomButton1();
            BtnNumber1 = new CustomButton.CustomButton1();
            BtnEquals = new CustomButton.CustomButton1();
            BtnNumber2 = new CustomButton.CustomButton1();
            BtnPM = new CustomButton.CustomButton1();
            BtnNumber3 = new CustomButton.CustomButton1();
            BtnNumber0 = new CustomButton.CustomButton1();
            BtnDecimal = new CustomButton.CustomButton1();
            customButton11 = new CustomButton.CustomButton1();
            customButton12 = new CustomButton.CustomButton1();
            customButton13 = new CustomButton.CustomButton1();
            customButton14 = new CustomButton.CustomButton1();
            customButton15 = new CustomButton.CustomButton1();
            customButton16 = new CustomButton.CustomButton1();
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
            PnlTitle.Size = new Size(615, 60);
            PnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(465, 0);
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
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(515, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 60);
            button1.TabIndex = 1;
            button1.Text = "□";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.FromArgb(38, 36, 36);
            BtnExit.Dock = DockStyle.Right;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.White;
            BtnExit.Location = new Point(565, 0);
            BtnExit.Margin = new Padding(0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(50, 60);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "×";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // PnlHistory
            // 
            PnlHistory.Controls.Add(RtBoxDisplayHistory);
            PnlHistory.Controls.Add(BtnClearHistory);
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 814);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(615, 5);
            PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            RtBoxDisplayHistory.BackColor = Color.FromArgb(38, 36, 36);
            RtBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RtBoxDisplayHistory.Dock = DockStyle.Fill;
            RtBoxDisplayHistory.ForeColor = Color.White;
            RtBoxDisplayHistory.Location = new Point(0, 0);
            RtBoxDisplayHistory.Margin = new Padding(0);
            RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            RtBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RtBoxDisplayHistory.Size = new Size(615, 0);
            RtBoxDisplayHistory.TabIndex = 4;
            RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            BtnClearHistory.Dock = DockStyle.Bottom;
            BtnClearHistory.FlatAppearance.BorderSize = 0;
            BtnClearHistory.FlatStyle = FlatStyle.Flat;
            BtnClearHistory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClearHistory.ForeColor = Color.White;
            BtnClearHistory.Image = (Image)resources.GetObject("BtnClearHistory.Image");
            BtnClearHistory.Location = new Point(0, -55);
            BtnClearHistory.Margin = new Padding(0);
            BtnClearHistory.Name = "BtnClearHistory";
            BtnClearHistory.Size = new Size(615, 60);
            BtnClearHistory.TabIndex = 3;
            BtnClearHistory.UseVisualStyleBackColor = true;
            BtnClearHistory.Click += BtnClearHistory_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 60);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 60);
            panel1.TabIndex = 2;
            // 
            // BtnHistory
            // 
            BtnHistory.Dock = DockStyle.Right;
            BtnHistory.FlatAppearance.BorderSize = 0;
            BtnHistory.FlatStyle = FlatStyle.Flat;
            BtnHistory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHistory.ForeColor = Color.White;
            BtnHistory.Image = (Image)resources.GetObject("BtnHistory.Image");
            BtnHistory.Location = new Point(565, 0);
            BtnHistory.Margin = new Padding(0);
            BtnHistory.Name = "BtnHistory";
            BtnHistory.Size = new Size(50, 60);
            BtnHistory.TabIndex = 0;
            BtnHistory.UseVisualStyleBackColor = true;
            BtnHistory.Click += BtnHistory_Click;
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
            NumberDisplay.Size = new Size(615, 45);
            NumberDisplay.TabIndex = 3;
            NumberDisplay.Text = "0";
            NumberDisplay.TextAlign = HorizontalAlignment.Right;
            NumberDisplay.Click += BtnOperation_Click;
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
            SumDisplay.Size = new Size(615, 57);
            SumDisplay.TabIndex = 4;
            SumDisplay.Text = "0";
            SumDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnBackspace
            // 
            BtnBackspace.BackColor = Color.FromArgb(43, 39, 34);
            BtnBackspace.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnBackspace.BorderRadius = 20;
            BtnBackspace.BorderSize = 0;
            BtnBackspace.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnBackspace.FlatAppearance.BorderSize = 0;
            BtnBackspace.FlatStyle = FlatStyle.Flat;
            BtnBackspace.ForeColor = Color.White;
            BtnBackspace.Image = Properties.Resources.clear__1_;
            BtnBackspace.Location = new Point(488, 277);
            BtnBackspace.Margin = new Padding(0);
            BtnBackspace.Name = "BtnBackspace";
            BtnBackspace.Size = new Size(115, 75);
            BtnBackspace.TabIndex = 5;
            BtnBackspace.TextColor = Color.White;
            BtnBackspace.UseVisualStyleBackColor = false;
            BtnBackspace.Click += BtnBackspace_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(38, 36, 36);
            customButton2.BackgroundColor = Color.FromArgb(38, 36, 36);
            customButton2.BorderRadius = 15;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(414, 222);
            customButton2.Margin = new Padding(0);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(75, 45);
            customButton2.TabIndex = 5;
            customButton2.Text = "M~";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.FromArgb(38, 36, 36);
            customButton3.BackgroundColor = Color.FromArgb(38, 36, 36);
            customButton3.BorderRadius = 15;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(333, 222);
            customButton3.Margin = new Padding(0);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(75, 45);
            customButton3.TabIndex = 5;
            customButton3.Text = "MS";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(38, 36, 36);
            customButton4.BackgroundColor = Color.FromArgb(38, 36, 36);
            customButton4.BorderRadius = 15;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(252, 222);
            customButton4.Margin = new Padding(0);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(75, 45);
            customButton4.TabIndex = 5;
            customButton4.Text = "M−";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.FromArgb(38, 36, 36);
            customButton5.BackgroundColor = Color.FromArgb(38, 36, 36);
            customButton5.BorderRadius = 15;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(171, 222);
            customButton5.Margin = new Padding(0);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(75, 45);
            customButton5.TabIndex = 5;
            customButton5.Text = "M+";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton6
            // 
            customButton6.BackColor = Color.FromArgb(38, 36, 36);
            customButton6.BackgroundColor = Color.FromArgb(38, 36, 36);
            customButton6.BorderRadius = 15;
            customButton6.BorderSize = 0;
            customButton6.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customButton6.ForeColor = Color.White;
            customButton6.Location = new Point(90, 222);
            customButton6.Margin = new Padding(0);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(75, 45);
            customButton6.TabIndex = 5;
            customButton6.Text = "MR";
            customButton6.TextColor = Color.White;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // customButton7
            // 
            customButton7.BackColor = Color.FromArgb(38, 36, 36);
            customButton7.BackgroundColor = Color.FromArgb(38, 36, 36);
            customButton7.BorderRadius = 15;
            customButton7.BorderSize = 0;
            customButton7.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton7.FlatAppearance.BorderSize = 0;
            customButton7.FlatStyle = FlatStyle.Flat;
            customButton7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customButton7.ForeColor = Color.White;
            customButton7.Location = new Point(9, 222);
            customButton7.Margin = new Padding(0);
            customButton7.Name = "customButton7";
            customButton7.Size = new Size(75, 45);
            customButton7.TabIndex = 5;
            customButton7.Text = "MC";
            customButton7.TextColor = Color.White;
            customButton7.UseVisualStyleBackColor = false;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(43, 39, 34);
            BtnPercent.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnPercent.BorderRadius = 20;
            BtnPercent.BorderSize = 0;
            BtnPercent.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPercent.ForeColor = Color.White;
            BtnPercent.Location = new Point(8, 277);
            BtnPercent.Margin = new Padding(0);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(115, 75);
            BtnPercent.TabIndex = 5;
            BtnPercent.Text = "%";
            BtnPercent.TextColor = Color.White;
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnMathFunctions_Click;
            // 
            // BtnClearEntry
            // 
            BtnClearEntry.BackColor = Color.FromArgb(43, 39, 34);
            BtnClearEntry.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnClearEntry.BorderRadius = 20;
            BtnClearEntry.BorderSize = 0;
            BtnClearEntry.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnClearEntry.FlatAppearance.BorderSize = 0;
            BtnClearEntry.FlatStyle = FlatStyle.Flat;
            BtnClearEntry.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClearEntry.ForeColor = Color.White;
            BtnClearEntry.Location = new Point(368, 277);
            BtnClearEntry.Margin = new Padding(0);
            BtnClearEntry.Name = "BtnClearEntry";
            BtnClearEntry.Size = new Size(115, 75);
            BtnClearEntry.TabIndex = 5;
            BtnClearEntry.Text = "CE";
            BtnClearEntry.TextColor = Color.White;
            BtnClearEntry.UseVisualStyleBackColor = false;
            BtnClearEntry.Click += BtnClearEntry_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(43, 39, 34);
            BtnClear.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnClear.BorderRadius = 20;
            BtnClear.BorderSize = 0;
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(248, 277);
            BtnClear.Margin = new Padding(0);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(115, 75);
            BtnClear.TabIndex = 5;
            BtnClear.Text = "C";
            BtnClear.TextColor = Color.White;
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = Color.FromArgb(43, 39, 34);
            BtnDivide.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnDivide.BorderRadius = 20;
            BtnDivide.BorderSize = 0;
            BtnDivide.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnDivide.FlatAppearance.BorderSize = 0;
            BtnDivide.FlatStyle = FlatStyle.Flat;
            BtnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivide.ForeColor = Color.White;
            BtnDivide.Location = new Point(487, 361);
            BtnDivide.Margin = new Padding(0);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(115, 75);
            BtnDivide.TabIndex = 5;
            BtnDivide.Text = "÷";
            BtnDivide.TextColor = Color.White;
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += BtnOperation_Click;
            // 
            // Btn1X
            // 
            Btn1X.BackColor = Color.FromArgb(43, 39, 34);
            Btn1X.BackgroundColor = Color.FromArgb(43, 39, 34);
            Btn1X.BorderRadius = 20;
            Btn1X.BorderSize = 0;
            Btn1X.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            Btn1X.FlatAppearance.BorderSize = 0;
            Btn1X.FlatStyle = FlatStyle.Flat;
            Btn1X.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Btn1X.ForeColor = Color.White;
            Btn1X.Location = new Point(7, 361);
            Btn1X.Margin = new Padding(0);
            Btn1X.Name = "Btn1X";
            Btn1X.Size = new Size(115, 75);
            Btn1X.TabIndex = 5;
            Btn1X.Text = "1/x";
            Btn1X.TextColor = Color.White;
            Btn1X.UseVisualStyleBackColor = false;
            Btn1X.Click += BtnMathFunctions_Click;
            // 
            // BtnPowerOf2
            // 
            BtnPowerOf2.BackColor = Color.FromArgb(43, 39, 34);
            BtnPowerOf2.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnPowerOf2.BorderRadius = 20;
            BtnPowerOf2.BorderSize = 0;
            BtnPowerOf2.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPowerOf2.FlatAppearance.BorderSize = 0;
            BtnPowerOf2.FlatStyle = FlatStyle.Flat;
            BtnPowerOf2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPowerOf2.ForeColor = Color.White;
            BtnPowerOf2.Location = new Point(127, 362);
            BtnPowerOf2.Margin = new Padding(0);
            BtnPowerOf2.Name = "BtnPowerOf2";
            BtnPowerOf2.Size = new Size(115, 75);
            BtnPowerOf2.TabIndex = 5;
            BtnPowerOf2.Text = "^2";
            BtnPowerOf2.TextColor = Color.White;
            BtnPowerOf2.UseVisualStyleBackColor = false;
            BtnPowerOf2.Click += BtnMathFunctions_Click;
            // 
            // BtnSquareRoot
            // 
            BtnSquareRoot.BackColor = Color.FromArgb(43, 39, 34);
            BtnSquareRoot.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnSquareRoot.BorderRadius = 20;
            BtnSquareRoot.BorderSize = 0;
            BtnSquareRoot.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnSquareRoot.FlatAppearance.BorderSize = 0;
            BtnSquareRoot.FlatStyle = FlatStyle.Flat;
            BtnSquareRoot.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSquareRoot.ForeColor = Color.White;
            BtnSquareRoot.Location = new Point(247, 361);
            BtnSquareRoot.Margin = new Padding(0);
            BtnSquareRoot.Name = "BtnSquareRoot";
            BtnSquareRoot.Size = new Size(115, 75);
            BtnSquareRoot.TabIndex = 5;
            BtnSquareRoot.Text = "√x";
            BtnSquareRoot.TextColor = Color.White;
            BtnSquareRoot.UseVisualStyleBackColor = false;
            BtnSquareRoot.Click += BtnMathFunctions_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.FromArgb(43, 39, 34);
            BtnMultiply.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnMultiply.BorderRadius = 20;
            BtnMultiply.BorderSize = 0;
            BtnMultiply.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnMultiply.FlatAppearance.BorderSize = 0;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMultiply.ForeColor = Color.White;
            BtnMultiply.Location = new Point(488, 445);
            BtnMultiply.Margin = new Padding(0);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(115, 75);
            BtnMultiply.TabIndex = 5;
            BtnMultiply.Text = "×";
            BtnMultiply.TextColor = Color.White;
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnOperation_Click;
            // 
            // BtnNumber7
            // 
            BtnNumber7.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber7.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber7.BorderRadius = 20;
            BtnNumber7.BorderSize = 0;
            BtnNumber7.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber7.FlatAppearance.BorderSize = 0;
            BtnNumber7.FlatStyle = FlatStyle.Flat;
            BtnNumber7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber7.ForeColor = Color.White;
            BtnNumber7.Location = new Point(8, 445);
            BtnNumber7.Margin = new Padding(0);
            BtnNumber7.Name = "BtnNumber7";
            BtnNumber7.Size = new Size(115, 75);
            BtnNumber7.TabIndex = 5;
            BtnNumber7.Text = "7";
            BtnNumber7.TextColor = Color.White;
            BtnNumber7.UseVisualStyleBackColor = false;
            BtnNumber7.Click += BtnNum_Click;
            // 
            // BtnSubtract
            // 
            BtnSubtract.BackColor = Color.FromArgb(43, 39, 34);
            BtnSubtract.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnSubtract.BorderRadius = 20;
            BtnSubtract.BorderSize = 0;
            BtnSubtract.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnSubtract.FlatAppearance.BorderSize = 0;
            BtnSubtract.FlatStyle = FlatStyle.Flat;
            BtnSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSubtract.ForeColor = Color.White;
            BtnSubtract.Location = new Point(487, 529);
            BtnSubtract.Margin = new Padding(0);
            BtnSubtract.Name = "BtnSubtract";
            BtnSubtract.Size = new Size(115, 75);
            BtnSubtract.TabIndex = 5;
            BtnSubtract.Text = "−";
            BtnSubtract.TextColor = Color.White;
            BtnSubtract.UseVisualStyleBackColor = false;
            BtnSubtract.Click += BtnOperation_Click;
            // 
            // BtnNumber8
            // 
            BtnNumber8.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber8.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber8.BorderRadius = 20;
            BtnNumber8.BorderSize = 0;
            BtnNumber8.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber8.FlatAppearance.BorderSize = 0;
            BtnNumber8.FlatStyle = FlatStyle.Flat;
            BtnNumber8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber8.ForeColor = Color.White;
            BtnNumber8.Location = new Point(128, 445);
            BtnNumber8.Margin = new Padding(0);
            BtnNumber8.Name = "BtnNumber8";
            BtnNumber8.Size = new Size(115, 75);
            BtnNumber8.TabIndex = 5;
            BtnNumber8.Text = "8";
            BtnNumber8.TextColor = Color.White;
            BtnNumber8.UseVisualStyleBackColor = false;
            BtnNumber8.Click += BtnNum_Click;
            // 
            // BtnNumber4
            // 
            BtnNumber4.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber4.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber4.BorderRadius = 20;
            BtnNumber4.BorderSize = 0;
            BtnNumber4.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber4.FlatAppearance.BorderSize = 0;
            BtnNumber4.FlatStyle = FlatStyle.Flat;
            BtnNumber4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber4.ForeColor = Color.White;
            BtnNumber4.Location = new Point(7, 529);
            BtnNumber4.Margin = new Padding(0);
            BtnNumber4.Name = "BtnNumber4";
            BtnNumber4.Size = new Size(115, 75);
            BtnNumber4.TabIndex = 5;
            BtnNumber4.Text = "4";
            BtnNumber4.TextColor = Color.White;
            BtnNumber4.UseVisualStyleBackColor = false;
            BtnNumber4.Click += BtnNum_Click;
            // 
            // BtnNumber9
            // 
            BtnNumber9.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber9.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber9.BorderRadius = 20;
            BtnNumber9.BorderSize = 0;
            BtnNumber9.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber9.FlatAppearance.BorderSize = 0;
            BtnNumber9.FlatStyle = FlatStyle.Flat;
            BtnNumber9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber9.ForeColor = Color.White;
            BtnNumber9.Location = new Point(248, 445);
            BtnNumber9.Margin = new Padding(0);
            BtnNumber9.Name = "BtnNumber9";
            BtnNumber9.Size = new Size(115, 75);
            BtnNumber9.TabIndex = 5;
            BtnNumber9.Text = "9";
            BtnNumber9.TextColor = Color.White;
            BtnNumber9.UseVisualStyleBackColor = false;
            BtnNumber9.Click += BtnNum_Click;
            // 
            // BtnNumber5
            // 
            BtnNumber5.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber5.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber5.BorderRadius = 20;
            BtnNumber5.BorderSize = 0;
            BtnNumber5.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber5.FlatAppearance.BorderSize = 0;
            BtnNumber5.FlatStyle = FlatStyle.Flat;
            BtnNumber5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber5.ForeColor = Color.White;
            BtnNumber5.Location = new Point(127, 529);
            BtnNumber5.Margin = new Padding(0);
            BtnNumber5.Name = "BtnNumber5";
            BtnNumber5.Size = new Size(115, 75);
            BtnNumber5.TabIndex = 5;
            BtnNumber5.Text = "5";
            BtnNumber5.TextColor = Color.White;
            BtnNumber5.UseVisualStyleBackColor = false;
            BtnNumber5.Click += BtnNum_Click;
            // 
            // BtnNumber6
            // 
            BtnNumber6.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber6.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber6.BorderRadius = 20;
            BtnNumber6.BorderSize = 0;
            BtnNumber6.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber6.FlatAppearance.BorderSize = 0;
            BtnNumber6.FlatStyle = FlatStyle.Flat;
            BtnNumber6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber6.ForeColor = Color.White;
            BtnNumber6.Location = new Point(247, 529);
            BtnNumber6.Margin = new Padding(0);
            BtnNumber6.Name = "BtnNumber6";
            BtnNumber6.Size = new Size(115, 75);
            BtnNumber6.TabIndex = 5;
            BtnNumber6.Text = "6";
            BtnNumber6.TextColor = Color.White;
            BtnNumber6.UseVisualStyleBackColor = false;
            BtnNumber6.Click += BtnNum_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(43, 39, 34);
            BtnAdd.BackgroundColor = Color.FromArgb(43, 39, 34);
            BtnAdd.BorderRadius = 20;
            BtnAdd.BorderSize = 0;
            BtnAdd.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.ForeColor = Color.White;
            BtnAdd.Location = new Point(487, 613);
            BtnAdd.Margin = new Padding(0);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(115, 75);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "+";
            BtnAdd.TextColor = Color.White;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnOperation_Click;
            // 
            // BtnNumber1
            // 
            BtnNumber1.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber1.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber1.BorderRadius = 20;
            BtnNumber1.BorderSize = 0;
            BtnNumber1.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber1.FlatAppearance.BorderSize = 0;
            BtnNumber1.FlatStyle = FlatStyle.Flat;
            BtnNumber1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber1.ForeColor = Color.White;
            BtnNumber1.Location = new Point(7, 613);
            BtnNumber1.Margin = new Padding(0);
            BtnNumber1.Name = "BtnNumber1";
            BtnNumber1.Size = new Size(115, 75);
            BtnNumber1.TabIndex = 5;
            BtnNumber1.Text = "1";
            BtnNumber1.TextColor = Color.White;
            BtnNumber1.UseVisualStyleBackColor = false;
            BtnNumber1.Click += BtnNum_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.FromArgb(191, 111, 11);
            BtnEquals.BackgroundColor = Color.FromArgb(191, 111, 11);
            BtnEquals.BorderRadius = 20;
            BtnEquals.BorderSize = 0;
            BtnEquals.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnEquals.FlatAppearance.BorderSize = 0;
            BtnEquals.FlatStyle = FlatStyle.Flat;
            BtnEquals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEquals.ForeColor = Color.White;
            BtnEquals.Location = new Point(486, 697);
            BtnEquals.Margin = new Padding(0);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(115, 75);
            BtnEquals.TabIndex = 5;
            BtnEquals.Text = "=";
            BtnEquals.TextColor = Color.White;
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // BtnNumber2
            // 
            BtnNumber2.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber2.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber2.BorderRadius = 20;
            BtnNumber2.BorderSize = 0;
            BtnNumber2.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber2.FlatAppearance.BorderSize = 0;
            BtnNumber2.FlatStyle = FlatStyle.Flat;
            BtnNumber2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber2.ForeColor = Color.White;
            BtnNumber2.Location = new Point(127, 613);
            BtnNumber2.Margin = new Padding(0);
            BtnNumber2.Name = "BtnNumber2";
            BtnNumber2.Size = new Size(115, 75);
            BtnNumber2.TabIndex = 5;
            BtnNumber2.Text = "2";
            BtnNumber2.TextColor = Color.White;
            BtnNumber2.UseVisualStyleBackColor = false;
            BtnNumber2.Click += BtnNum_Click;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.FromArgb(51, 47, 41);
            BtnPM.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnPM.BorderRadius = 20;
            BtnPM.BorderSize = 0;
            BtnPM.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPM.ForeColor = Color.White;
            BtnPM.Location = new Point(6, 697);
            BtnPM.Margin = new Padding(0);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(115, 75);
            BtnPM.TabIndex = 5;
            BtnPM.Text = "±";
            BtnPM.TextColor = Color.White;
            BtnPM.UseVisualStyleBackColor = false;
            // 
            // BtnNumber3
            // 
            BtnNumber3.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber3.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber3.BorderRadius = 20;
            BtnNumber3.BorderSize = 0;
            BtnNumber3.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber3.FlatAppearance.BorderSize = 0;
            BtnNumber3.FlatStyle = FlatStyle.Flat;
            BtnNumber3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber3.ForeColor = Color.White;
            BtnNumber3.Location = new Point(247, 613);
            BtnNumber3.Margin = new Padding(0);
            BtnNumber3.Name = "BtnNumber3";
            BtnNumber3.Size = new Size(115, 75);
            BtnNumber3.TabIndex = 5;
            BtnNumber3.Text = "3";
            BtnNumber3.TextColor = Color.White;
            BtnNumber3.UseVisualStyleBackColor = false;
            BtnNumber3.Click += BtnNum_Click;
            // 
            // BtnNumber0
            // 
            BtnNumber0.BackColor = Color.FromArgb(51, 47, 41);
            BtnNumber0.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnNumber0.BorderRadius = 20;
            BtnNumber0.BorderSize = 0;
            BtnNumber0.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnNumber0.FlatAppearance.BorderSize = 0;
            BtnNumber0.FlatStyle = FlatStyle.Flat;
            BtnNumber0.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNumber0.ForeColor = Color.White;
            BtnNumber0.Location = new Point(126, 697);
            BtnNumber0.Margin = new Padding(0);
            BtnNumber0.Name = "BtnNumber0";
            BtnNumber0.Size = new Size(115, 75);
            BtnNumber0.TabIndex = 5;
            BtnNumber0.Text = "0";
            BtnNumber0.TextColor = Color.White;
            BtnNumber0.UseVisualStyleBackColor = false;
            BtnNumber0.Click += BtnNum_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.BackColor = Color.FromArgb(51, 47, 41);
            BtnDecimal.BackgroundColor = Color.FromArgb(51, 47, 41);
            BtnDecimal.BorderRadius = 20;
            BtnDecimal.BorderSize = 0;
            BtnDecimal.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            BtnDecimal.FlatAppearance.BorderSize = 0;
            BtnDecimal.FlatStyle = FlatStyle.Flat;
            BtnDecimal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDecimal.ForeColor = Color.White;
            BtnDecimal.Location = new Point(246, 697);
            BtnDecimal.Margin = new Padding(0);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(115, 75);
            BtnDecimal.TabIndex = 5;
            BtnDecimal.Text = ".";
            BtnDecimal.TextColor = Color.White;
            BtnDecimal.UseVisualStyleBackColor = false;
            BtnDecimal.Click += BtnNum_Click;
            // 
            // customButton11
            // 
            customButton11.BackColor = Color.FromArgb(43, 39, 34);
            customButton11.BackgroundColor = Color.FromArgb(43, 39, 34);
            customButton11.BorderRadius = 20;
            customButton11.BorderSize = 0;
            customButton11.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton11.FlatAppearance.BorderSize = 0;
            customButton11.FlatStyle = FlatStyle.Flat;
            customButton11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton11.ForeColor = Color.White;
            customButton11.Location = new Point(128, 277);
            customButton11.Margin = new Padding(0);
            customButton11.Name = "customButton11";
            customButton11.Size = new Size(115, 75);
            customButton11.TabIndex = 5;
            customButton11.Text = "^3";
            customButton11.TextColor = Color.White;
            customButton11.UseVisualStyleBackColor = false;
            customButton11.Click += BtnMathFunctions_Click;
            // 
            // customButton12
            // 
            customButton12.BackColor = Color.FromArgb(43, 39, 34);
            customButton12.BackgroundColor = Color.FromArgb(43, 39, 34);
            customButton12.BorderRadius = 20;
            customButton12.BorderSize = 0;
            customButton12.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton12.FlatAppearance.BorderSize = 0;
            customButton12.FlatStyle = FlatStyle.Flat;
            customButton12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton12.ForeColor = Color.White;
            customButton12.Location = new Point(367, 361);
            customButton12.Margin = new Padding(0);
            customButton12.Name = "customButton12";
            customButton12.Size = new Size(115, 75);
            customButton12.TabIndex = 5;
            customButton12.Text = "ln";
            customButton12.TextColor = Color.White;
            customButton12.UseVisualStyleBackColor = false;
            customButton12.Click += BtnMathFunctions_Click;
            // 
            // customButton13
            // 
            customButton13.BackColor = Color.FromArgb(43, 39, 34);
            customButton13.BackgroundColor = Color.FromArgb(43, 39, 34);
            customButton13.BorderRadius = 20;
            customButton13.BorderSize = 0;
            customButton13.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton13.FlatAppearance.BorderSize = 0;
            customButton13.FlatStyle = FlatStyle.Flat;
            customButton13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton13.ForeColor = Color.White;
            customButton13.Location = new Point(368, 446);
            customButton13.Margin = new Padding(0);
            customButton13.Name = "customButton13";
            customButton13.Size = new Size(115, 75);
            customButton13.TabIndex = 5;
            customButton13.Text = "log";
            customButton13.TextColor = Color.White;
            customButton13.UseVisualStyleBackColor = false;
            customButton13.Click += BtnMathFunctions_Click;
            // 
            // customButton14
            // 
            customButton14.BackColor = Color.FromArgb(43, 39, 34);
            customButton14.BackgroundColor = Color.FromArgb(43, 39, 34);
            customButton14.BorderRadius = 20;
            customButton14.BorderSize = 0;
            customButton14.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton14.FlatAppearance.BorderSize = 0;
            customButton14.FlatStyle = FlatStyle.Flat;
            customButton14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton14.ForeColor = Color.White;
            customButton14.Location = new Point(367, 530);
            customButton14.Margin = new Padding(0);
            customButton14.Name = "customButton14";
            customButton14.Size = new Size(115, 75);
            customButton14.TabIndex = 5;
            customButton14.Text = "sin";
            customButton14.TextColor = Color.White;
            customButton14.UseVisualStyleBackColor = false;
            customButton14.Click += BtnMathFunctions_Click;
            // 
            // customButton15
            // 
            customButton15.BackColor = Color.FromArgb(43, 39, 34);
            customButton15.BackgroundColor = Color.FromArgb(43, 39, 34);
            customButton15.BorderRadius = 20;
            customButton15.BorderSize = 0;
            customButton15.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton15.FlatAppearance.BorderSize = 0;
            customButton15.FlatStyle = FlatStyle.Flat;
            customButton15.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton15.ForeColor = Color.White;
            customButton15.Location = new Point(367, 613);
            customButton15.Margin = new Padding(0);
            customButton15.Name = "customButton15";
            customButton15.Size = new Size(115, 75);
            customButton15.TabIndex = 5;
            customButton15.Text = "cos";
            customButton15.TextColor = Color.White;
            customButton15.UseVisualStyleBackColor = false;
            customButton15.Click += BtnMathFunctions_Click;
            // 
            // customButton16
            // 
            customButton16.BackColor = Color.FromArgb(43, 39, 34);
            customButton16.BackgroundColor = Color.FromArgb(43, 39, 34);
            customButton16.BorderRadius = 20;
            customButton16.BorderSize = 0;
            customButton16.FlatAppearance.BorderColor = Color.FromArgb(38, 36, 36);
            customButton16.FlatAppearance.BorderSize = 0;
            customButton16.FlatStyle = FlatStyle.Flat;
            customButton16.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customButton16.ForeColor = Color.White;
            customButton16.Location = new Point(366, 697);
            customButton16.Margin = new Padding(0);
            customButton16.Name = "customButton16";
            customButton16.Size = new Size(115, 75);
            customButton16.TabIndex = 5;
            customButton16.Text = "tan";
            customButton16.TextColor = Color.White;
            customButton16.UseVisualStyleBackColor = false;
            customButton16.Click += BtnMathFunctions_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 36, 36);
            ClientSize = new Size(615, 819);
            Controls.Add(PnlHistory);
            Controls.Add(customButton7);
            Controls.Add(customButton6);
            Controls.Add(customButton5);
            Controls.Add(customButton4);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnNumber6);
            Controls.Add(BtnSquareRoot);
            Controls.Add(BtnNumber0);
            Controls.Add(BtnNumber5);
            Controls.Add(customButton16);
            Controls.Add(customButton14);
            Controls.Add(customButton15);
            Controls.Add(customButton13);
            Controls.Add(customButton12);
            Controls.Add(customButton11);
            Controls.Add(BtnPowerOf2);
            Controls.Add(BtnNumber3);
            Controls.Add(BtnPM);
            Controls.Add(BtnNumber9);
            Controls.Add(BtnNumber4);
            Controls.Add(BtnNumber2);
            Controls.Add(BtnClear);
            Controls.Add(BtnNumber8);
            Controls.Add(BtnEquals);
            Controls.Add(Btn1X);
            Controls.Add(BtnSubtract);
            Controls.Add(BtnNumber1);
            Controls.Add(BtnClearEntry);
            Controls.Add(BtnNumber7);
            Controls.Add(BtnAdd);
            Controls.Add(BtnDivide);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnPercent);
            Controls.Add(BtnBackspace);
            Controls.Add(SumDisplay);
            Controls.Add(NumberDisplay);
            Controls.Add(panel1);
            Controls.Add(PnlTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private Button BtnHistory;
        private TextBox NumberDisplay;
        private TextBox SumDisplay;
        private RichTextBox RtBoxDisplayHistory;
        private Button BtnClearHistory;
        private CustomButton.CustomButton1 BtnBackspace;
        private CustomButton.CustomButton1 customButton2;
        private CustomButton.CustomButton1 customButton3;
        private CustomButton.CustomButton1 customButton4;
        private CustomButton.CustomButton1 customButton5;
        private CustomButton.CustomButton1 customButton6;
        private CustomButton.CustomButton1 customButton7;
        private CustomButton.CustomButton1 BtnPercent;
        private CustomButton.CustomButton1 BtnClearEntry;
        private CustomButton.CustomButton1 BtnClear;
        private CustomButton.CustomButton1 BtnDivide;
        private CustomButton.CustomButton1 Btn1X;
        private CustomButton.CustomButton1 BtnPowerOf2;
        private CustomButton.CustomButton1 BtnSquareRoot;
        private CustomButton.CustomButton1 BtnMultiply;
        private CustomButton.CustomButton1 BtnNumber7;
        private CustomButton.CustomButton1 BtnSubtract;
        private CustomButton.CustomButton1 BtnNumber8;
        private CustomButton.CustomButton1 BtnNumber4;
        private CustomButton.CustomButton1 BtnNumber9;
        private CustomButton.CustomButton1 BtnNumber5;
        private CustomButton.CustomButton1 BtnNumber6;
        private CustomButton.CustomButton1 BtnAdd;
        private CustomButton.CustomButton1 BtnNumber1;
        private CustomButton.CustomButton1 BtnEquals;
        private CustomButton.CustomButton1 BtnNumber2;
        private CustomButton.CustomButton1 BtnPM;
        private CustomButton.CustomButton1 BtnNumber3;
        private CustomButton.CustomButton1 BtnNumber0;
        private CustomButton.CustomButton1 BtnDecimal;
        private CustomButton.CustomButton1 customButton11;
        private CustomButton.CustomButton1 customButton12;
        private CustomButton.CustomButton1 customButton13;
        private CustomButton.CustomButton1 customButton14;
        private CustomButton.CustomButton1 customButton15;
        private CustomButton.CustomButton1 customButton16;
    }
}