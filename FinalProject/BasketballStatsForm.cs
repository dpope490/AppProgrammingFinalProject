﻿using System;
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

		static string UppercaseFirst(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			return char.ToUpper(s[0]) + s.Substring(1);
		}

		//adds a player to the database
		private void addPlayerButton_Click(object sender, EventArgs e)
        {
			addPlayerConsole.Text = null;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
            var basketballDB = new BasketballDB(connection);
			var players = basketballDB.GetTable<Player>();

			//gets user inputted player information
            var name = playerNameTextBox.Text;
            var number = numberUpDown.Value;
			var position = "";
			int j;
			foreach (RadioButton rdo in positionBox.Controls.OfType<RadioButton>())
			{
				if (rdo.Checked)
				{
					position = rdo.Text;
				}
			}
			var team = teamListBox.GetItemText(teamListBox.SelectedItem);
			if (int.TryParse(name, out j))
			{
				addPlayerConsole.Text = "Name cannot be an integer.";
			}
			else
			{
				var player = new Player(name, number, team, position);

				//inserts new player into the database
				players.InsertOnSubmit(player);
				basketballDB.SubmitChanges();

				addPlayerConsole.Text = $"Successfully added {name} to the {team}";
			}
			basketballDB.Dispose();
            connection.Close();
        }

		//gets a list of the teams in the database
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

		//resets the form fields in add player tab
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

		//loads the teams in the add game tab
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

		//adds a game to the database
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
			int j;

			if (teamOne == teamTwo)
			{
				addGameConsole.Text = "Team One cannot be the same as team two";
			}
			else
			{
				var game = new Game(id, teamOne, teamTwo, teamOnePoints, teamTwoPoints);
				//inserts new game into database
				games.InsertOnSubmit(game);
				basketballDB.SubmitChanges();
				//ask Mark about this
				String consoleText = $"{teamOne} VS {teamTwo}";
				addGameConsole.Text = consoleText;

				//determines who won and lost the game and adds a win and loss to each respectively
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
			}

			basketballDB.Dispose();
			connection.Close();
		}

		//resets the form fields in the add game tab
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

		//adds a team to the database
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            addGameConsole.Text = null;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
            var basketballDB = new BasketballDB(connection);
            var teams = basketballDB.GetTable<Team>();

            var name = UppercaseFirst(teamNameTextBox.Text);
            var city = UppercaseFirst(cityTextBox.Text);
            var wins = int.Parse(winsTextBox.Text);
            var losses = int.Parse(lossesTextBox.Text);

            var team = new Team(name, city, wins, losses);

            teams.InsertOnSubmit(team);
            basketballDB.SubmitChanges();

            addTeamConsole.Text = $"{city} {name} added.";

			basketballDB.Dispose();
			connection.Close();
		}

		//resets the form fields in the add team tab
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

		//checks to see if name is checked in player search
		private void nameCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (playerNameSearch.Enabled == true)
			{
				playerNameSearch.Enabled = false;
			}
			else
			{
				playerNameSearch.Enabled = true;
			}
		}

		//checks to see if number box is checked in player search
		private void numberCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (playerNumberSearch.Enabled == true)
			{
				playerNumberSearch.Enabled = false;
			}
			else
			{
				playerNumberSearch.Enabled = true;
			}
		}

		//checks to see if team box is checked in player search
		private void teamCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (playerTeamSearch.Enabled == true)
			{
				playerTeamSearch.Enabled = false;
			}
			else
			{
				playerTeamSearch.Enabled = true;
			}
		}

		//checks to see if position box is checked in player search
		private void positionCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (playerPositionSearch.Enabled == true)
			{
				playerPositionSearch.Enabled = false;
			}
			else
			{
				playerPositionSearch.Enabled = true;
			}
		}

		//checks to see if only one team is going to be searched in game search
		private void oneTeamSearchButton_CheckedChanged(object sender, EventArgs e)
		{
			if (teamOneGameSearch.Enabled == false)
			{
				teamOneGameSearch.Enabled = true;
			}
			else if (teamTwoGameSearch.Enabled == true)
			{
				teamTwoGameSearch.Enabled = false;
			}
		}

		//checks to see if two teams are going to be searched in game search
		private void twoTeamsSearchButton_CheckedChanged(object sender, EventArgs e)
		{
			if (teamOneGameSearch.Enabled == false)
			{
				teamOneGameSearch.Enabled = true;
			}
			else if (teamTwoGameSearch.Enabled == false)
			{
				teamTwoGameSearch.Enabled = true;
			}
		}

		//checks to see if name box is checked in team search
		private void teamNameCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (teamNameSearch.Enabled == true)
			{
				teamNameSearch.Enabled = false;
			}
			else
			{
				teamNameSearch.Enabled = true;
			}
		}

		//checks to see if city box is checked in team search
		private void teamCityCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (teamCitySearch.Enabled == true)
			{
				teamCitySearch.Enabled = false;
			}
			else
			{
				teamCitySearch.Enabled = true;
			}
		}

		//searches by player
		private void searchPlayers_Click(object sender, EventArgs e)
		{
			playerSearchConsole.Text = null;
			SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
			var basketballDB = new BasketballDB(connection);
			var players = basketballDB.GetTable<Player>();
			var name = "";
			var number = -1;
			var team = "";
			var position = "";

			//checks to see what the user is searching by
			if (playerNameSearch.Enabled == true)
			{
				name = playerNameSearch.Text;
			}
			else if (playerNumberSearch.Enabled == true)
			{
				number = int.Parse(playerNumberSearch.Text);
			}
			else if (playerTeamSearch.Enabled == true)
			{
				team = playerTeamSearch.Text;
			}
			else if (playerPositionSearch.Enabled == true)
			{
				position = UppercaseFirst(playerPositionSearch.Text);
			}
			else
			{
				playerSearchConsole.Text = "You can't search nothing, duh.";
			}

			IQueryable<Player> searchedPlayers = null;

			//searches by player name
			if (name != "" && number == -1 && team == "" && position == "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name
					select player;
			}
			//searches by player number
			else if (name == "" && number != -1 && team == "" && position == "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Number == number
					select player;
			}
			//searches by player's team
			else if (name == "" && number == -1 && team != "" && position == "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Team == team
					select player;
			}
			//searches by player's position
			else if (name == "" && number == -1 && team == "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Position == position
					select player;
			}
			//searcbes by player name and number
			else if (name != "" && number != -1 && team == "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Number == number
					select player;
			}
			//searches by player name and team
			else if (name != "" && number == -1 && team != "" && position == "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Team == team
					select player;
			}
			//searches by player name and position
			else if (name != "" && number == -1 && team == "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Position == position
					select player;
			}
			//searches by player number and team
			else if (name == "" && number != -1 && team != "" && position == "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Number == number && player.Team == team
					select player;
			}
			//searches by player number and position
			else if (name == "" && number != -1 && team == "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Number == number && player.Position == position
					select player;
			}
			//searches by player team and position
			else if (name == "" && number == -1 && team != "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Team == team && player.Position == position
					select player;
			}
			//searches by player name, number, and team
			else if (name != "" && number != -1 && team != "" && position == "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Number == number && player.Team == team
					select player;
			}
			//searches by player name, number, and position
			else if (name != "" && number != -1 && team == "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Number == number && player.Position == position
					select player;
			}
			//searches by player name, team, and position
			else if (name != "" && number == -1 && team != "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Team == team && player.Position == position
					select player;
			}
			//searches by player number, team, and position
			else if (name == "" && number != -1 && team != "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Number == number && player.Team == team && player.Position == position
					select player;
			}
			//searches by name, number, team, position
			else if (name != "" && number != -1 && team != "" && position != "")
			{
				searchedPlayers =
					from player in basketballDB.Players
					where player.Name == name && player.Number == number && player.Team == team && player.Position == position
					select player;
			}


			//outputs onto console
			playerSearchConsole.Text = "Name\t\tNumber\tTeam\tPosition";
			playerSearchConsole.Text += "\n-----------------------------------------------------------------------------------";
			if (!searchedPlayers.Any())
			{
				playerSearchConsole.Text = "Nothing found.";
			}
			else
			{
				foreach (var player in searchedPlayers)
				{
					playerSearchConsole.Text += $"\n{player.Name}\t{player.Number}\t{player.Team}\t{player.Position}";
				}
			}
			basketballDB.Dispose();
			connection.Close();
		}

		//searches by game
		private void searchGames_Click(object sender, EventArgs e)
		{
			SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
			var basketballDB = new BasketballDB(connection);
			var games = basketballDB.GetTable<Game>();

			basketballDB.Dispose();
			connection.Close();
		}

		//searches by team
		private void searchTeams_Click(object sender, EventArgs e)
		{
			SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\basketball.sqlite3");
			var basketballDB = new BasketballDB(connection);
			var teams = basketballDB.GetTable<Team>();

			basketballDB.Dispose();
			connection.Close();
		}

		private void playerSearchConsole_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
