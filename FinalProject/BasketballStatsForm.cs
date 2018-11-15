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
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var number = numberUpDown.Value;
            foreach (RadioButton rdo in positionBox.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    var position = rdo.Text;
                }
            }
            //continue working from here

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
                teamListBox.Items.Insert(0, $"{team.City} {team.Name}");
            }

            basketballDB.Dispose();
            connection.Close();
        }

        private void addPlayerReset_Click(object sender, EventArgs e)
        {

        }
    }
}
