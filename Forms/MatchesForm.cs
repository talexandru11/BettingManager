using ProiectPariuri.Exceptions;
using ProiectPariuri.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
//using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProiectPariuri.Forms
{
    public partial class MatchesForm : Form
    {
        private int nextId = 1;
        private BindingList<Match> matches;
        private BindingList<Bet> bets;

        public MatchesForm(BindingList<Match> matches)
        {
            InitializeComponent();
            this.matches=matches;
            dgvMatches.DataSource = matches;
            dgvMatches.Columns["Id"].HeaderText = "ID";
            dgvMatches.Columns["HomeTeam"].HeaderText = "Home Team";
            dgvMatches.Columns["AwayTeam"].HeaderText = "Away Team";
            dgvMatches.Columns["MatchDate"].HeaderText = "Date";
            dgvMatches.Columns["Competition"].HeaderText = "Competition";
            dgvMatches.Columns["FinalScore"].HeaderText = "Final Score";
            dgvMatches.Columns["DisplayName"].Visible = false;
            dgvMatches.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMatches.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMatches.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMatches.ColumnHeadersDefaultCellStyle.ForeColor;

            dgvMatches.Columns["Id"].FillWeight = 45;
        }

        private void UpdateStatusStrip()
        {
            statusMatchesCount.Text = $"Total matches: {matches.Count}";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                ValidateMatchInput();

                Match match = new Match();

                match.Id = nextId;
                match.HomeTeam = txtHomeTeam.Text;
                match.AwayTeam = txtAwayTeam.Text;
                match.MatchDate = dateMatchDate.Value;
                match.Competition = txtCompetition.Text;
                match.FinalScore = txtFinalScore.Text;

                matches.Insert(0, match);
                nextId++;

                txtHomeTeam.Clear();
                txtAwayTeam.Clear();
                txtCompetition.Clear();
                UpdateStatusStrip();
            }
            catch (InvalidMatchException ex)
            {
                MessageBox.Show(ex.Message, "Validation error");
            }


        }

        private void UpdateNextId()
        {
            if (matches.Count == 0)
            {
                nextId = 1;
            }
            else
            {
                nextId = matches.Max(match => match.Id) + 1;
            }
        }

        private void ValidateMatchInput()
        {
            if (string.IsNullOrWhiteSpace(txtHomeTeam.Text))
            {
                throw new InvalidMatchException("Home team is required.");
            }

            if (string.IsNullOrWhiteSpace(txtAwayTeam.Text))
            {
                throw new InvalidMatchException("Away team is required.");
            }

            if (txtHomeTeam.Text == txtAwayTeam.Text)
            {
                throw new InvalidMatchException("Home team and away team cannot be the same.");
            }

            if (string.IsNullOrWhiteSpace(txtCompetition.Text))
            {
                throw new InvalidMatchException("Competition is required.");
            }

            if (dateMatchDate.Value.Date < DateTime.Today)
            {
                throw new InvalidMatchException("Match date cannot be in the past.");
            }
        }

        private void fileImportJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Select a JSON file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportMatchesFromJsonFile(openFileDialog.FileName);
            }
            UpdateStatusStrip();

        }

        private void fileExportJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save matches as JSON";
            saveFileDialog.FileName = "Matches.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json =
                    JsonSerializer.Serialize(matches,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(saveFileDialog.FileName, json);

                MessageBox.Show(this, "Matches exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvMatches_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvMatches_DragDrop(object sender, DragEventArgs e)
        {
            string[] files =
        (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 0)
            {
                return;
            }

            string filePath = files[0];

            if (Path.GetExtension(filePath).ToLower() != ".json")
            {
                MessageBox.Show(this, "Matches imported successfully.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImportMatchesFromJsonFile(filePath);
        }

        private void ImportMatchesFromJsonFile(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    MessageBox.Show(this, "The JSON file is empty.", "Import error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Match>? loadedMatches =
                    JsonSerializer.Deserialize<List<Match>>(json);

                if (loadedMatches == null)
                {
                    MessageBox.Show(this, "Could not import file.", "Import error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                matches.Clear();

                foreach (Match match in loadedMatches)
                {
                    matches.Add(match);
                }
                UpdateNextId();

                MessageBox.Show(this, "Matches imported successfully.", "Import",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (JsonException)
            {
                MessageBox.Show(this, "The file is not valid JSON.", "Import error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMatches.CurrentRow == null)
                {
                    return;
                }

                ValidateMatchInput();

                Match selectedMatch =
                    (Match)dgvMatches.CurrentRow.DataBoundItem;

                selectedMatch.HomeTeam = txtHomeTeam.Text.Trim();
                selectedMatch.AwayTeam = txtAwayTeam.Text.Trim();
                selectedMatch.MatchDate = dateMatchDate.Value;
                selectedMatch.Competition = txtCompetition.Text.Trim();
                selectedMatch.FinalScore = txtFinalScore.Text;

                dgvMatches.Refresh();
            }
            catch (InvalidMatchException ex)
            {
                MessageBox.Show(this, ex.Message, "Validation error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DeleteSelectedMatch()
        {
            if (dgvMatches.CurrentRow == null)
            {
                return;
            }

            Match selectedMatch =
                (Match)dgvMatches.CurrentRow.DataBoundItem;

            matches.Remove(selectedMatch);
            UpdateStatusStrip();
        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            DeleteSelectedMatch();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedMatch();
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to delete all matches?",
        "Confirm reset",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                matches.Clear();
                UpdateNextId();

                txtHomeTeam.Clear();
                txtAwayTeam.Clear();
                txtCompetition.Clear();
                UpdateStatusStrip();
            }
        }

        private void exportTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Export matches report";
            saveFileDialog.FileName = "MatchesReport.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer =
                    new StreamWriter(saveFileDialog.FileName);

                foreach (Match match in matches)
                {
                    writer.WriteLine(
                        $"[{match.Id}] {match.HomeTeam} vs {match.AwayTeam}");

                    writer.WriteLine(
                        $"Competition: {match.Competition}");

                    writer.WriteLine(
                        $"Date: {match.MatchDate}");

                    if (!string.IsNullOrWhiteSpace(match.FinalScore))
                    {
                        writer.WriteLine(
                            $"Final Score: {match.FinalScore}");
                    }

                    writer.WriteLine("--------------------------------");
                }

                writer.Close();

                MessageBox.Show(this, "Matches report exported successfully.", "Export match report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvMatches_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvMatches.ClearSelection();

                dgvMatches.Rows[e.RowIndex].Selected = true;

                dgvMatches.CurrentCell =
                    dgvMatches.Rows[e.RowIndex].Cells[0];

                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }


}
