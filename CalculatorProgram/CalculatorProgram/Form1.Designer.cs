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
            panel1 = new Panel();
            BtnMenu = new Button();
            BtnHistory = new Button();
            NumberDisplay = new TextBox();
            SumDisplay = new TextBox();
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
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 639);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(487, 117);
            PnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(38, 36, 36);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(188, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 23);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
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
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 36, 36);
            ClientSize = new Size(487, 756);
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
        private RichTextBox richTextBox1;
        private Button button2;
        private Panel panel1;
        private Button BtnMenu;
        private Button BtnHistory;
        private TextBox NumberDisplay;
        private TextBox SumDisplay;
    }
}