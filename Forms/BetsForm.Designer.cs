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
            dgvBets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBets).BeginInit();
            SuspendLayout();
            // 
            // dgvBets
            // 
            dgvBets.Location = new Point(54, 109);
            dgvBets.Name = "dgvBets";
            dgvBets.Size = new Size(681, 313);
            dgvBets.AllowDrop = true;
            dgvBets.AllowUserToAddRows = false;
            dgvBets.AllowUserToResizeColumns = false;
            dgvBets.AllowUserToResizeRows = false;
            dgvBets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBets.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBets.EnableHeadersVisualStyles = false;
            dgvBets.GridColor = SystemColors.Menu;
            dgvBets.MultiSelect = false;
            dgvBets.RowHeadersVisible = false;
            dgvBets.RowHeadersWidth = 51;
            dgvBets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBets.TabIndex = 10;

            // 
            // BetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBets);
            Name = "BetsForm";
            Text = "BetsForm";
            ((System.ComponentModel.ISupportInitialize)dgvBets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBets;
    }
}