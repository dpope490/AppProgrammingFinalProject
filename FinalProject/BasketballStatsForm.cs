using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinalProject
{

    public partial class BasketballStatsForm : Form
    {
        public BasketballStatsForm()
        {
            InitializeComponent();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
            var basketballDB = new BasketballDB(connection);
			var players = basketballDB.GetTable<Player>();

            var name = playerNameTextBox.Text;
            var number = numberUpDown.Value;
			var position = "";
            foreach (RadioButton rdo in positionBox.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    position = rdo.Text;
                }
            }
			var team = teamListBox.GetItemText(teamListBox.SelectedItem);

			var player = new Player(name, number, team, position);

			players.InsertOnSubmit(player);
			basketballDB.SubmitChanges();

			addPlayerConsole.Text = $"Successfully added {name} to the {team}";

			basketballDB.Dispose();
            connection.Close();
        }

        private void refreshTeamsButton_Click(object sender, EventArgs e)
        {
            teamListBox.Items.Clear();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
            var basketballDB = new BasketballDB(connection);
            foreach (var team in basketballDB.Teams)
            {
                teamListBox.Items.Insert(0, $"{team.Name}");
            }

            basketballDB.Dispose();
            connection.Close();
        }

        private void addPlayerReset_Click(object sender, EventArgs e)
        {
			foreach (Control control in StatsTab.SelectedTab.Controls)
			{
				if (control is TextBox)
				{
					TextBox textBox = (TextBox)control;
					textBox.Text = null;
				}

				if (control is GroupBox)
				{
					foreach (Control button in positionBox.Controls)
					{
						RadioButton radioButton = (RadioButton)button;
						radioButton.Checked = false;
					}
				}

				if (control is ListBox)
				{
					ListBox listBox = (ListBox)control;
					listBox.ClearSelected();
				}

				if (control is NumericUpDown)
				{
					NumericUpDown numericUpDown = (NumericUpDown)control;
					numericUpDown.Value = 0;
				}
			}
			addPlayerConsole.Text = null;
		}

		private void addGameLoadTeams_Click(object sender, EventArgs e)
		{
			teamOneListBox.Items.Clear();
			teamTwoListBox.Items.Clear();
			SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
			var basketballDB = new BasketballDB(connection);
			foreach (var team in basketballDB.Teams)
			{
				teamOneListBox.Items.Insert(0, $"{team.Name}");
				teamTwoListBox.Items.Insert(0, $"{team.Name}");
			}

			basketballDB.Dispose();
			connection.Close();
		}

		private void submitScoreButton_Click(object sender, EventArgs e)
		{
            addGameConsole.Text = null;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
			var basketballDB = new BasketballDB(connection);
			var games = basketballDB.GetTable<Game>();
			var id = 1;
			foreach (var g in basketballDB.Games)
			{
				id++;
			}

			var teamOne = teamOneListBox.GetItemText(teamOneListBox.SelectedItem);
			var teamTwo = teamTwoListBox.GetItemText(teamTwoListBox.SelectedItem);
			var teamOnePoints = int.Parse(teamOnePointsTextBox.Text);
			var teamTwoPoints = int.Parse(teamTwoPointsTextBox.Text);

			var game = new Game(id, teamOne, teamTwo, teamOnePoints, teamTwoPoints);

			games.InsertOnSubmit(game);
			basketballDB.SubmitChanges();
            //ask Mark about this
            String consoleText = $"{teamOne} VS {teamTwo}";
            addGameConsole.Text = consoleText;

			if (teamOnePoints > teamTwoPoints)
			{
				var winningTeam =
					from team in basketballDB.Teams
					where team.Name == teamOne
					select team;
                var losingTeam =
                    from team in basketballDB.Teams
                    where team.Name == teamTwo
                    select team;
				foreach (var team in winningTeam)
				{
					team.Wins++;
				}
                foreach (var team in losingTeam)
                {
                    team.Losses++;
                }
				basketballDB.SubmitChanges();
                addGameConsole.Text += $"\n{teamOne} win!";
			}
			else
			{
				var winningTeam =
					from team in basketballDB.Teams
					where team.Name == teamTwo
					select team;
                var losingTeam =
                    from team in basketballDB.Teams
                    where team.Name == teamOne
                    select team;
                foreach (var team in winningTeam)
				{
					team.Wins++;
				}
                foreach (var team in losingTeam)
                {
                    team.Losses++;
                }
				basketballDB.SubmitChanges();
                addGameConsole.Text += $"\n{teamTwo} get the win!";
			}


			basketballDB.Dispose();
			connection.Close();
		}

        private void resetAddGame_Click(object sender, EventArgs e)
        {
            foreach (Control control in StatsTab.SelectedTab.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
            addGameConsole.Text = null;
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            addGameConsole.Text = null;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
            var basketballDB = new BasketballDB(connection);
            var teams = basketballDB.GetTable<Team>();

            var name = teamNameTextBox.Text;
            var city = cityTextBox.Text;
            var wins = int.Parse(winsTextBox.Text);
            var losses = int.Parse(lossesTextBox.Text);

            var team = new Team(name, city, wins, losses);

            teams.InsertOnSubmit(team);
            basketballDB.SubmitChanges();

            addTeamConsole.Text = $"{city} {name} added.";
        }

        private void addTeamReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in StatsTab.SelectedTab.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

            }
            addTeamConsole.Text = null;
        }
    }
}
