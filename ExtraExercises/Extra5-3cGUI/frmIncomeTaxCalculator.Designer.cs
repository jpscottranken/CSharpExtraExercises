namespace Extra5_3cGUI
{
    partial class frmIncomeTaxCalculator
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
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblTaxableIncome = new Label();
            lblIncomeTaxOwed = new Label();
            txtTaxableIncome = new TextBox();
            txtIncomeTaxOwed = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(63, 313);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(177, 61);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(321, 313);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(177, 61);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(578, 313);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(177, 61);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTaxableIncome
            // 
            lblTaxableIncome.BackColor = Color.FromArgb(255, 255, 128);
            lblTaxableIncome.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTaxableIncome.Location = new Point(63, 48);
            lblTaxableIncome.Name = "lblTaxableIncome";
            lblTaxableIncome.Size = new Size(260, 36);
            lblTaxableIncome.TabIndex = 5;
            lblTaxableIncome.Text = "Taxable Income:";
            lblTaxableIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIncomeTaxOwed
            // 
            lblIncomeTaxOwed.BackColor = Color.FromArgb(255, 255, 128);
            lblIncomeTaxOwed.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblIncomeTaxOwed.Location = new Point(63, 176);
            lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            lblIncomeTaxOwed.Size = new Size(260, 36);
            lblIncomeTaxOwed.TabIndex = 6;
            lblIncomeTaxOwed.Text = "Income Tax Owed:";
            lblIncomeTaxOwed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTaxableIncome
            // 
            txtTaxableIncome.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTaxableIncome.Location = new Point(386, 48);
            txtTaxableIncome.Name = "txtTaxableIncome";
            txtTaxableIncome.Size = new Size(369, 38);
            txtTaxableIncome.TabIndex = 0;
            txtTaxableIncome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIncomeTaxOwed
            // 
            txtIncomeTaxOwed.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtIncomeTaxOwed.Location = new Point(386, 176);
            txtIncomeTaxOwed.Name = "txtIncomeTaxOwed";
            txtIncomeTaxOwed.ReadOnly = true;
            txtIncomeTaxOwed.Size = new Size(369, 38);
            txtIncomeTaxOwed.TabIndex = 4;
            txtIncomeTaxOwed.TextAlign = HorizontalAlignment.Center;
            // 
            // frmIncomeTaxCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIncomeTaxOwed);
            Controls.Add(txtTaxableIncome);
            Controls.Add(lblIncomeTaxOwed);
            Controls.Add(lblTaxableIncome);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Name = "frmIncomeTaxCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income Tax Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblTaxableIncome;
        private Label lblIncomeTaxOwed;
        private TextBox txtTaxableIncome;
        private TextBox txtIncomeTaxOwed;
    }
}
