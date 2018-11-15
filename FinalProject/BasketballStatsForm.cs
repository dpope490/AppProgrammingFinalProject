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
        }
    }
}
