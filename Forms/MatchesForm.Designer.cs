namespace ProiectPariuri.Forms
{
    partial class MatchesForm
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
            components = new System.ComponentModel.Container();
            grpbMatchInfo = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            lblCompetition = new Label();
            lblDate = new Label();
            txtCompetition = new TextBox();
            dateMatchDate = new DateTimePicker();
            txtAwayTeam = new TextBox();
            lblAwayTeam = new Label();
            txtHomeTeam = new TextBox();
            lblHomeTeam = new Label();
            groupBox1 = new GroupBox();
            dgvMatches = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteItemToolStripMenuItem = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileImportJson = new ToolStripMenuItem();
            fileExportJson = new ToolStripMenuItem();
            exportTXTToolStripMenuItem = new ToolStripMenuItem();
            fileExit = new ToolStripMenuItem();
            btnEditMatch = new Button();
            btnDeleteMatch = new Button();
            btnResetList = new Button();
            grpbMatchInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpbMatchInfo
            // 
            grpbMatchInfo.Controls.Add(label3);
            grpbMatchInfo.Controls.Add(label2);
            grpbMatchInfo.Controls.Add(label1);
            grpbMatchInfo.Controls.Add(btnAdd);
            grpbMatchInfo.Controls.Add(lblCompetition);
            grpbMatchInfo.Controls.Add(lblDate);
            grpbMatchInfo.Controls.Add(txtCompetition);
            grpbMatchInfo.Controls.Add(dateMatchDate);
            grpbMatchInfo.Controls.Add(txtAwayTeam);
            grpbMatchInfo.Controls.Add(lblAwayTeam);
            grpbMatchInfo.Controls.Add(txtHomeTeam);
            grpbMatchInfo.Controls.Add(lblHomeTeam);
            grpbMatchInfo.Location = new Point(63, 31);
            grpbMatchInfo.Name = "grpbMatchInfo";
            grpbMatchInfo.Size = new Size(513, 269);
            grpbMatchInfo.TabIndex = 10;
            grpbMatchInfo.TabStop = false;
            grpbMatchInfo.Text = "Match Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(168, 184);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 20;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(161, 95);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 19;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(166, 50);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 18;
            label1.Text = "*";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(213, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCompetition
            // 
            lblCompetition.AutoSize = true;
            lblCompetition.Location = new Point(79, 187);
            lblCompetition.Name = "lblCompetition";
            lblCompetition.Size = new Size(95, 20);
            lblCompetition.TabIndex = 16;
            lblCompetition.Text = "Competition:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(79, 141);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date:";
            // 
            // txtCompetition
            // 
            txtCompetition.Location = new Point(187, 180);
            txtCompetition.Name = "txtCompetition";
            txtCompetition.PlaceholderText = "Competition name...";
            txtCompetition.Size = new Size(250, 27);
            txtCompetition.TabIndex = 14;
            // 
            // dateMatchDate
            // 
            dateMatchDate.Location = new Point(187, 134);
            dateMatchDate.Name = "dateMatchDate";
            dateMatchDate.Size = new Size(250, 27);
            dateMatchDate.TabIndex = 13;
            // 
            // txtAwayTeam
            // 
            txtAwayTeam.Location = new Point(187, 90);
            txtAwayTeam.Name = "txtAwayTeam";
            txtAwayTeam.PlaceholderText = "Team name...";
            txtAwayTeam.Size = new Size(250, 27);
            txtAwayTeam.TabIndex = 12;
            // 
            // lblAwayTeam
            // 
            lblAwayTeam.AutoSize = true;
            lblAwayTeam.Location = new Point(79, 97);
            lblAwayTeam.Name = "lblAwayTeam";
            lblAwayTeam.Size = new Size(88, 20);
            lblAwayTeam.TabIndex = 11;
            lblAwayTeam.Text = "Away Team:";
            // 
            // txtHomeTeam
            // 
            txtHomeTeam.Location = new Point(187, 46);
            txtHomeTeam.Name = "txtHomeTeam";
            txtHomeTeam.PlaceholderText = "Team name...";
            txtHomeTeam.Size = new Size(250, 27);
            txtHomeTeam.TabIndex = 10;
            // 
            // lblHomeTeam
            // 
            lblHomeTeam.AutoSize = true;
            lblHomeTeam.Location = new Point(79, 53);
            lblHomeTeam.Name = "lblHomeTeam";
            lblHomeTeam.Size = new Size(93, 20);
            lblHomeTeam.TabIndex = 9;
            lblHomeTeam.Text = "Home Team:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMatches);
            groupBox1.Location = new Point(63, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 300);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Match List";
            // 
            // dgvMatches
            // 
            dgvMatches.AllowDrop = true;
            dgvMatches.AllowUserToAddRows = false;
            dgvMatches.AllowUserToResizeColumns = false;
            dgvMatches.AllowUserToResizeRows = false;
            dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.EnableHeadersVisualStyles = false;
            dgvMatches.GridColor = SystemColors.Menu;
            dgvMatches.Location = new Point(6, 21);
            dgvMatches.MultiSelect = false;
            dgvMatches.Name = "dgvMatches";
            dgvMatches.RowHeadersVisible = false;
            dgvMatches.RowHeadersWidth = 51;
            dgvMatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatches.Size = new Size(501, 273);
            dgvMatches.TabIndex = 10;
            dgvMatches.CellMouseDown += dgvMatches_CellMouseDown;
            dgvMatches.DragDrop += dgvMatches_DragDrop;
            dgvMatches.DragEnter += dgvMatches_DragEnter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteItemToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(157, 28);
            // 
            // deleteItemToolStripMenuItem
            // 
            deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            deleteItemToolStripMenuItem.Size = new Size(156, 24);
            deleteItemToolStripMenuItem.Text = "Delete Item";
            deleteItemToolStripMenuItem.Click += deleteItemToolStripMenuItem_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(645, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileImportJson, fileExportJson, exportTXTToolStripMenuItem, fileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileImportJson
            // 
            fileImportJson.Name = "fileImportJson";
            fileImportJson.Size = new Size(234, 26);
            fileImportJson.Text = "Import JSON";
            fileImportJson.Click += fileImportJson_Click;
            // 
            // fileExportJson
            // 
            fileExportJson.Name = "fileExportJson";
            fileExportJson.Size = new Size(234, 26);
            fileExportJson.Text = "Export JSON";
            fileExportJson.Click += fileExportJson_Click;
            // 
            // exportTXTToolStripMenuItem
            // 
            exportTXTToolStripMenuItem.Name = "exportTXTToolStripMenuItem";
            exportTXTToolStripMenuItem.Size = new Size(234, 26);
            exportTXTToolStripMenuItem.Text = "Export file report TXT";
            exportTXTToolStripMenuItem.Click += exportTXTToolStripMenuItem_Click;
            // 
            // fileExit
            // 
            fileExit.Name = "fileExit";
            fileExit.Size = new Size(234, 26);
            fileExit.Text = "Exit";
            fileExit.Click += fileExit_Click;
            // 
            // btnEditMatch
            // 
            btnEditMatch.Location = new Point(69, 644);
            btnEditMatch.Name = "btnEditMatch";
            btnEditMatch.Size = new Size(129, 29);
            btnEditMatch.TabIndex = 13;
            btnEditMatch.Text = "&Update Selected";
            btnEditMatch.UseVisualStyleBackColor = true;
            btnEditMatch.Click += btnEditMatch_Click;
            // 
            // btnDeleteMatch
            // 
            btnDeleteMatch.Location = new Point(250, 644);
            btnDeleteMatch.Name = "btnDeleteMatch";
            btnDeleteMatch.Size = new Size(129, 29);
            btnDeleteMatch.TabIndex = 14;
            btnDeleteMatch.Text = "&Delete Selected";
            btnDeleteMatch.UseVisualStyleBackColor = true;
            btnDeleteMatch.Click += btnDeleteMatch_Click;
            // 
            // btnResetList
            // 
            btnResetList.Location = new Point(441, 644);
            btnResetList.Name = "btnResetList";
            btnResetList.Size = new Size(129, 29);
            btnResetList.TabIndex = 15;
            btnResetList.Text = "&Reset List";
            btnResetList.UseVisualStyleBackColor = true;
            btnResetList.Click += btnResetList_Click;
            // 
            // MatchesForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 734);
            Controls.Add(btnResetList);
            Controls.Add(btnDeleteMatch);
            Controls.Add(btnEditMatch);
            Controls.Add(grpbMatchInfo);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MatchesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatchesForm";
            grpbMatchInfo.ResumeLayout(false);
            grpbMatchInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpbMatchInfo;
        private Button btnAdd;
        private Label lblCompetition;
        private Label lblDate;
        private TextBox txtCompetition;
        private DateTimePicker dateMatchDate;
        private TextBox txtAwayTeam;
        private Label lblAwayTeam;
        private TextBox txtHomeTeam;
        private Label lblHomeTeam;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMatches;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileImportJson;
        private ToolStripMenuItem fileExportJson;
        private ToolStripMenuItem fileExit;
        private Button btnResetList;
        private Button btnDeleteMatch;
        private Button btnEditMatch;
        private ToolStripMenuItem exportTXTToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
    }
}