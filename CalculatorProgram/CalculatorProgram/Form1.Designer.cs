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
            PnlTitle = new Panel();
            PnlHistory = new Panel();
            button1 = new Button();
            PnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitle
            // 
            PnlTitle.Controls.Add(button1);
            PnlTitle.Dock = DockStyle.Top;
            PnlTitle.Location = new Point(0, 0);
            PnlTitle.Margin = new Padding(0);
            PnlTitle.Name = "PnlTitle";
            PnlTitle.Size = new Size(400, 60);
            PnlTitle.TabIndex = 0;
            // 
            // PnlHistory
            // 
            PnlHistory.Dock = DockStyle.Bottom;
            PnlHistory.Location = new Point(0, 540);
            PnlHistory.Name = "PnlHistory";
            PnlHistory.Size = new Size(400, 60);
            PnlHistory.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(345, 41);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(18, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 36, 36);
            ClientSize = new Size(400, 600);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitle;
        private Panel PnlHistory;
        private Button button1;
    }
}