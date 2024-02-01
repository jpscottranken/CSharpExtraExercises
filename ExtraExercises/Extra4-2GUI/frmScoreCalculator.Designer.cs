namespace Extra4_2GUI
{
    partial class frmScoreCalculator
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
            btnClear = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            lblScore = new Label();
            lblScoreTotal = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            txtScore = new TextBox();
            txtScoreCount = new TextBox();
            txtScoreTotal = new TextBox();
            txtAverage = new TextBox();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(94, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 51);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(362, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 51);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(553, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblScore
            // 
            lblScore.BackColor = Color.FromArgb(255, 128, 255);
            lblScore.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(94, 44);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(184, 38);
            lblScore.TabIndex = 7;
            lblScore.Text = "Score:";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.BackColor = Color.FromArgb(255, 128, 255);
            lblScoreTotal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblScoreTotal.ForeColor = Color.White;
            lblScoreTotal.Location = new Point(94, 121);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(184, 35);
            lblScoreTotal.TabIndex = 8;
            lblScoreTotal.Text = "Score Total:";
            lblScoreTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreCount
            // 
            lblScoreCount.BackColor = Color.FromArgb(255, 128, 255);
            lblScoreCount.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblScoreCount.ForeColor = Color.White;
            lblScoreCount.Location = new Point(94, 190);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(184, 35);
            lblScoreCount.TabIndex = 9;
            lblScoreCount.Text = "ScoreCount:";
            lblScoreCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            lblAverage.BackColor = Color.FromArgb(255, 128, 255);
            lblAverage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAverage.ForeColor = Color.White;
            lblAverage.Location = new Point(94, 266);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(184, 35);
            lblAverage.TabIndex = 10;
            lblAverage.Text = "Average:";
            lblAverage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtScore.Location = new Point(301, 44);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(190, 38);
            txtScore.TabIndex = 0;
            txtScore.TextAlign = HorizontalAlignment.Center;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtScoreCount.Location = new Point(301, 187);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(190, 38);
            txtScoreCount.TabIndex = 5;
            txtScoreCount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtScoreTotal.Location = new Point(301, 118);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(190, 38);
            txtScoreTotal.TabIndex = 4;
            txtScoreTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAverage
            // 
            txtAverage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtAverage.Location = new Point(301, 263);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(190, 38);
            txtAverage.TabIndex = 6;
            txtAverage.TextAlign = HorizontalAlignment.Center;
            // 
            // frmScoreCalculator
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScore);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoreTotal);
            Controls.Add(lblScore);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Name = "frmScoreCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Calculataor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnExit;
        private Button btnAdd;
        private Label lblScore;
        private Label lblScoreTotal;
        private Label lblScoreCount;
        private Label lblAverage;
        private TextBox txtScore;
        private TextBox txtScoreCount;
        private TextBox txtScoreTotal;
        private TextBox txtAverage;
    }
}
