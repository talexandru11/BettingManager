namespace ProiectPariuri.Forms
{
    partial class BetsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dgvBets = new DataGridView();
            btnResetList = new Button();
            btnDeleteMatch = new Button();
            btnEditMatch = new Button();
            grpBetInfo = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddBet = new Button();
            chkWinner = new CheckBox();
            numAmount = new NumericUpDown();
            numOdds = new NumericUpDown();
            cmbBetType = new ComboBox();
            cmbMatches = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBets).BeginInit();
            grpBetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOdds).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBets);
            groupBox1.Location = new Point(66, 346);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 300);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bet List";
            // 
            // dgvBets
            // 
            dgvBets.AllowDrop = true;
            dgvBets.AllowUserToAddRows = false;
            dgvBets.AllowUserToResizeColumns = false;
            dgvBets.AllowUserToResizeRows = false;
            dgvBets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBets.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBets.EnableHeadersVisualStyles = false;
            dgvBets.GridColor = SystemColors.Menu;
            dgvBets.Location = new Point(6, 20);
            dgvBets.MultiSelect = false;
            dgvBets.Name = "dgvBets";
            dgvBets.ReadOnly = true;
            dgvBets.RowHeadersVisible = false;
            dgvBets.RowHeadersWidth = 51;
            dgvBets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBets.Size = new Size(500, 275);
            dgvBets.TabIndex = 13;
            dgvBets.CellClick += dgvBets_CellClick;
            // 
            // btnResetList
            // 
            btnResetList.Location = new Point(445, 668);
            btnResetList.Name = "btnResetList";
            btnResetList.Size = new Size(129, 29);
            btnResetList.TabIndex = 24;
            btnResetList.Text = "&Reset List";
            btnResetList.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMatch
            // 
            btnDeleteMatch.Location = new Point(254, 668);
            btnDeleteMatch.Name = "btnDeleteMatch";
            btnDeleteMatch.Size = new Size(129, 29);
            btnDeleteMatch.TabIndex = 23;
            btnDeleteMatch.Text = "&Delete Selected";
            btnDeleteMatch.UseVisualStyleBackColor = true;
            btnDeleteMatch.Click += btnDeleteMatch_Click;
            // 
            // btnEditMatch
            // 
            btnEditMatch.Location = new Point(73, 668);
            btnEditMatch.Name = "btnEditMatch";
            btnEditMatch.Size = new Size(129, 29);
            btnEditMatch.TabIndex = 22;
            btnEditMatch.Text = "&Update Selected";
            btnEditMatch.UseVisualStyleBackColor = true;
            btnEditMatch.Click += btnEditMatch_Click;
            // 
            // grpBetInfo
            // 
            grpBetInfo.Controls.Add(label4);
            grpBetInfo.Controls.Add(label3);
            grpBetInfo.Controls.Add(label2);
            grpBetInfo.Controls.Add(label1);
            grpBetInfo.Controls.Add(btnAddBet);
            grpBetInfo.Controls.Add(chkWinner);
            grpBetInfo.Controls.Add(numAmount);
            grpBetInfo.Controls.Add(numOdds);
            grpBetInfo.Controls.Add(cmbBetType);
            grpBetInfo.Controls.Add(cmbMatches);
            grpBetInfo.Location = new Point(76, 18);
            grpBetInfo.Name = "grpBetInfo";
            grpBetInfo.Size = new Size(494, 322);
            grpBetInfo.TabIndex = 25;
            grpBetInfo.TabStop = false;
            grpBetInfo.Text = "Bet Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 174);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 31;
            label4.Text = "Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 128);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 30;
            label3.Text = "Odds:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 82);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 29;
            label2.Text = "Bet type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 28;
            label1.Text = "Match:";
            // 
            // btnAddBet
            // 
            btnAddBet.Location = new Point(200, 263);
            btnAddBet.Name = "btnAddBet";
            btnAddBet.Size = new Size(94, 29);
            btnAddBet.TabIndex = 27;
            btnAddBet.Text = "&Add bet";
            btnAddBet.UseVisualStyleBackColor = true;
            btnAddBet.Click += btnAddBet_Click;
            // 
            // chkWinner
            // 
            chkWinner.AutoSize = true;
            chkWinner.Location = new Point(205, 216);
            chkWinner.Name = "chkWinner";
            chkWinner.Size = new Size(85, 24);
            chkWinner.TabIndex = 26;
            chkWinner.Text = "Winner?";
            chkWinner.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(208, 170);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(150, 27);
            numAmount.TabIndex = 25;
            // 
            // numOdds
            // 
            numOdds.Location = new Point(208, 124);
            numOdds.Name = "numOdds";
            numOdds.Size = new Size(150, 27);
            numOdds.TabIndex = 24;
            // 
            // cmbBetType
            // 
            cmbBetType.FormattingEnabled = true;
            cmbBetType.Location = new Point(208, 77);
            cmbBetType.Name = "cmbBetType";
            cmbBetType.Size = new Size(151, 28);
            cmbBetType.TabIndex = 23;
            // 
            // cmbMatches
            // 
            cmbMatches.FormattingEnabled = true;
            cmbMatches.Location = new Point(208, 30);
            cmbMatches.Name = "cmbMatches";
            cmbMatches.Size = new Size(151, 28);
            cmbMatches.TabIndex = 22;
            // 
            // BetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 733);
            Controls.Add(grpBetInfo);
            Controls.Add(btnResetList);
            Controls.Add(btnDeleteMatch);
            Controls.Add(btnEditMatch);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BetsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BetsForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBets).EndInit();
            grpBetInfo.ResumeLayout(false);
            grpBetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOdds).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvBets;
        private Button btnResetList;
        private Button btnDeleteMatch;
        private Button btnEditMatch;
        private GroupBox grpBetInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddBet;
        private CheckBox chkWinner;
        private NumericUpDown numAmount;
        private NumericUpDown numOdds;
        private ComboBox cmbBetType;
        private ComboBox cmbMatches;
    }
}