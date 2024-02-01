namespace Extra5_2bGUI
{
    partial class frmChangeCalculator
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
            lblChangeDue = new Label();
            lblQuarters = new Label();
            lblDimes = new Label();
            lblNickels = new Label();
            lblPennies = new Label();
            txtChangeDue = new TextBox();
            txtNickels = new TextBox();
            txtDimes = new TextBox();
            txtQuarters = new TextBox();
            txtPennies = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(71, 505);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(166, 66);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(308, 505);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 66);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(560, 505);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 66);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblChangeDue
            // 
            lblChangeDue.BackColor = Color.FromArgb(128, 255, 255);
            lblChangeDue.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblChangeDue.Location = new Point(167, 40);
            lblChangeDue.Name = "lblChangeDue";
            lblChangeDue.Size = new Size(237, 39);
            lblChangeDue.TabIndex = 8;
            lblChangeDue.Text = "Change Due (0 - 99):";
            lblChangeDue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuarters
            // 
            lblQuarters.BackColor = Color.FromArgb(128, 255, 255);
            lblQuarters.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblQuarters.Location = new Point(167, 131);
            lblQuarters.Name = "lblQuarters";
            lblQuarters.Size = new Size(237, 39);
            lblQuarters.TabIndex = 9;
            lblQuarters.Text = "Quarters:";
            lblQuarters.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDimes
            // 
            lblDimes.BackColor = Color.FromArgb(128, 255, 255);
            lblDimes.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDimes.Location = new Point(167, 224);
            lblDimes.Name = "lblDimes";
            lblDimes.Size = new Size(237, 39);
            lblDimes.TabIndex = 10;
            lblDimes.Text = "Dimes:";
            lblDimes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNickels
            // 
            lblNickels.BackColor = Color.FromArgb(128, 255, 255);
            lblNickels.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblNickels.Location = new Point(167, 325);
            lblNickels.Name = "lblNickels";
            lblNickels.Size = new Size(237, 39);
            lblNickels.TabIndex = 11;
            lblNickels.Text = "Nickels:";
            lblNickels.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPennies
            // 
            lblPennies.BackColor = Color.FromArgb(128, 255, 255);
            lblPennies.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblPennies.Location = new Point(167, 420);
            lblPennies.Name = "lblPennies";
            lblPennies.Size = new Size(237, 39);
            lblPennies.TabIndex = 12;
            lblPennies.Text = "Pennies:";
            lblPennies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtChangeDue
            // 
            txtChangeDue.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtChangeDue.Location = new Point(454, 40);
            txtChangeDue.Name = "txtChangeDue";
            txtChangeDue.Size = new Size(187, 38);
            txtChangeDue.TabIndex = 0;
            txtChangeDue.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNickels
            // 
            txtNickels.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtNickels.Location = new Point(454, 322);
            txtNickels.Name = "txtNickels";
            txtNickels.ReadOnly = true;
            txtNickels.Size = new Size(187, 38);
            txtNickels.TabIndex = 6;
            txtNickels.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDimes
            // 
            txtDimes.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDimes.Location = new Point(454, 221);
            txtDimes.Name = "txtDimes";
            txtDimes.ReadOnly = true;
            txtDimes.Size = new Size(187, 38);
            txtDimes.TabIndex = 5;
            txtDimes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQuarters
            // 
            txtQuarters.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtQuarters.Location = new Point(454, 131);
            txtQuarters.Name = "txtQuarters";
            txtQuarters.ReadOnly = true;
            txtQuarters.Size = new Size(187, 38);
            txtQuarters.TabIndex = 4;
            txtQuarters.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPennies
            // 
            txtPennies.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPennies.Location = new Point(454, 420);
            txtPennies.Name = "txtPennies";
            txtPennies.ReadOnly = true;
            txtPennies.Size = new Size(187, 38);
            txtPennies.TabIndex = 7;
            txtPennies.TextAlign = HorizontalAlignment.Center;
            // 
            // frmChangeCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            CancelButton = btnClear;
            ClientSize = new Size(800, 634);
            Controls.Add(txtPennies);
            Controls.Add(txtQuarters);
            Controls.Add(txtDimes);
            Controls.Add(txtNickels);
            Controls.Add(txtChangeDue);
            Controls.Add(lblPennies);
            Controls.Add(lblNickels);
            Controls.Add(lblDimes);
            Controls.Add(lblQuarters);
            Controls.Add(lblChangeDue);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Name = "frmChangeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblChangeDue;
        private Label lblQuarters;
        private Label lblDimes;
        private Label lblNickels;
        private Label lblPennies;
        private TextBox txtChangeDue;
        private TextBox txtNickels;
        private TextBox txtDimes;
        private TextBox txtQuarters;
        private TextBox txtPennies;
    }
}
