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
            SuspendLayout();
            // 
            // btnManageMatches
            // 
            btnManageMatches.Location = new Point(76, 85);
            btnManageMatches.Name = "btnManageMatches";
            btnManageMatches.Size = new Size(207, 59);
            btnManageMatches.TabIndex = 0;
            btnManageMatches.Text = "Manage Matches";
            btnManageMatches.UseVisualStyleBackColor = true;
            btnManageMatches.Click += btnManageMatches_Click;
            // 
            // btnManageBets
            // 
            btnManageBets.Location = new Point(368, 85);
            btnManageBets.Name = "btnManageBets";
            btnManageBets.Size = new Size(207, 59);
            btnManageBets.TabIndex = 1;
            btnManageBets.Text = "Manage Bets";
            btnManageBets.UseVisualStyleBackColor = true;
            btnManageBets.Click += btnManageBets_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(btnManageBets);
            Controls.Add(btnManageMatches);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionarePariuriSportive";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageMatches;
        private Button btnManageBets;
    }
}
