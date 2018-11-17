using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace FinalProject
{

    [Database]
    public class BasketballDB : DataContext
    {
        public BasketballDB(System.Data.IDbConnection connection) : base(connection)
        {
        }

        public Table<Team> Teams;
        public Table<Player> Players;
        public Table<Game> Games;
    }

    [Table(Name = "Team")]
    public class Team
    {
		[Column(IsPrimaryKey = true)]
		public String Name { get; set; }
        [Column]
        public String City { get; set; }
        [Column]
        public int Wins { get; set; }
        [Column]
        public int Losses { get; set; }
        public Team(String name, String city,
            int wins, int losses)
        {
			Name = name;
			City = city;
            Wins = wins;
            Losses = losses;
        }

        public Team()
        {

        }
    }

    [Table(Name = "Player")]
    public class Player
    {
        [Column(IsPrimaryKey = true)]
		public String Name { get; set; }
        [Column]
        public decimal Number { get; set; }
        [Column]
        public String Team { get; set; }
        [Column]
        public String Position { get; set; }

        public Player(String name, decimal number, String team, String position)
        {
			Name = name;
            Number = number;
            Team = team;
            Position = position;

        }

        public Player()
        {

        }
    }

    [Table(Name = "Game")]
    public class Game
    {
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column]
        public String TeamOne { get; set; }
        [Column]
        public String TeamTwo { get; set; }
        [Column]
        public int TeamOnePoints { get; set; }
        [Column]
        public int TeamTwoPoints { get; set; }

        public Game(int id, String teamOne, String teamTwo,
            int teamOnePoints, int teamTwoPoints)
        {
            Id = id;
            TeamOne = teamOne;
            TeamTwo = teamTwo;
            TeamOnePoints = teamOnePoints;
            TeamTwoPoints = teamTwoPoints;
        }

        public Game()
        {

        }
    }

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BasketballStatsForm());
        }
    }
}
