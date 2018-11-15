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
        public int Id { get; set; }
        [Column]
        public String City { get; set; }
        [Column]
        public String Name { get; set; }
        [Column]
        public int Wins { get; set; }
        [Column]
        public int Losses { get; set; }
        public Team(int id, String city, String name,
            int wins, int losses)
        {
            Id = id;
            City = city;
            Name = name;
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
        public int Id { get; set; }
        [Column]
        public String FirstName { get; set; }
        [Column]
        public String LastName { get; set; }
        [Column]
        public int Number { get; set; }
        [Column]
        public int Team { get; set; }
        [Column]
        public String Position { get; set; }
        [Column]
        public int Points { get; set; }
        [Column]
        public int Rebounds { get; set; }
        [Column]
        public int Assists { get; set; }
        [Column]
        public int Turnovers { get; set; }
        [Column]
        public int Blocks { get; set; }
        [Column]
        public int Steals { get; set; }

        public Player(int id, String firstName, String lastName,
            int number, int team, String position, int points,
            int rebounds, int assists, int turnovers,
            int blocks, int steals)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            Team = team;
            Position = position;
            Points = points;
            Rebounds = rebounds;
            Assists = assists;
            Turnovers = turnovers;
            Blocks = blocks;
            Steals = steals;

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
        public int TeamOne { get; set; }
        [Column]
        public int TeamTwo { get; set; }
        [Column]
        public int TeamOnePoints { get; set; }
        [Column]
        public int TeamTwoPoints { get; set; }

        public Game(int id, int teamOne, int teamTwo,
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
