namespace ProiectPariuri
{
    partial class MainForm
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
            btnManageMatches = new Button();
            btnManageBets = new Button();
            groupBox1 = new GroupBox();
            lblTotalAmountValue = new Label();
            lblWinningBetsValue = new Label();
            lblTotalBetsValue = new Label();
            lblTotalMatchesValue = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnManageMatches
            // 
            btnManageMatches.Location = new Point(95, 44);
            btnManageMatches.Name = "btnManageMatches";
            btnManageMatches.Size = new Size(207, 61);
            btnManageMatches.TabIndex = 0;
            btnManageMatches.Text = "Manage Matches";
            btnManageMatches.UseVisualStyleBackColor = true;
            btnManageMatches.Click += btnManageMatches_Click;
            // 
            // btnManageBets
            // 
            btnManageBets.Location = new Point(387, 44);
            btnManageBets.Name = "btnManageBets";
            btnManageBets.Size = new Size(207, 61);
            btnManageBets.TabIndex = 1;
            btnManageBets.Text = "Manage Bets";
            btnManageBets.UseVisualStyleBackColor = true;
            btnManageBets.Click += btnManageBets_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalAmountValue);
            groupBox1.Controls.Add(lblWinningBetsValue);
            groupBox1.Controls.Add(lblTotalBetsValue);
            groupBox1.Controls.Add(lblTotalMatchesValue);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(95, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 236);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // lblTotalAmountValue
            // 
            lblTotalAmountValue.AutoSize = true;
            lblTotalAmountValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTotalAmountValue.ForeColor = SystemColors.MenuHighlight;
            lblTotalAmountValue.Location = new Point(297, 137);
            lblTotalAmountValue.Name = "lblTotalAmountValue";
            lblTotalAmountValue.Size = new Size(27, 31);
            lblTotalAmountValue.TabIndex = 11;
            lblTotalAmountValue.Text = "0";
            // 
            // lblWinningBetsValue
            // 
            lblWinningBetsValue.AutoSize = true;
            lblWinningBetsValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblWinningBetsValue.ForeColor = SystemColors.MenuHighlight;
            lblWinningBetsValue.Location = new Point(61, 137);
            lblWinningBetsValue.Name = "lblWinningBetsValue";
            lblWinningBetsValue.Size = new Size(27, 31);
            lblWinningBetsValue.TabIndex = 10;
            lblWinningBetsValue.Text = "0";
            lblWinningBetsValue.Click += lblWinningBetsValue_Click;
            // 
            // lblTotalBetsValue
            // 
            lblTotalBetsValue.AutoSize = true;
            lblTotalBetsValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTotalBetsValue.ForeColor = SystemColors.MenuHighlight;
            lblTotalBetsValue.Location = new Point(297, 42);
            lblTotalBetsValue.Name = "lblTotalBetsValue";
            lblTotalBetsValue.Size = new Size(27, 31);
            lblTotalBetsValue.TabIndex = 9;
            lblTotalBetsValue.Text = "0";
            // 
            // lblTotalMatchesValue
            // 
            lblTotalMatchesValue.AutoSize = true;
            lblTotalMatchesValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblTotalMatchesValue.ForeColor = SystemColors.MenuHighlight;
            lblTotalMatchesValue.Location = new Point(61, 42);
            lblTotalMatchesValue.Name = "lblTotalMatchesValue";
            lblTotalMatchesValue.Size = new Size(27, 31);
            lblTotalMatchesValue.TabIndex = 8;
            lblTotalMatchesValue.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(297, 168);
            label4.Name = "label4";
            label4.Size = new Size(161, 31);
            label4.TabIndex = 7;
            label4.Text = "Total Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(61, 168);
            label3.Name = "label3";
            label3.Size = new Size(159, 31);
            label3.TabIndex = 6;
            label3.Text = "Winning Bets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(297, 73);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 5;
            label2.Text = "Total Bets";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(61, 73);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 4;
            label1.Text = "Total Matches";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnManageBets);
            Controls.Add(btnManageMatches);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionarePariuriSportive";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageMatches;
        private Button btnManageBets;
        private GroupBox groupBox1;
        private Label lblTotalAmountValue;
        private Label lblWinningBetsValue;
        private Label lblTotalBetsValue;
        private Label lblTotalMatchesValue;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
