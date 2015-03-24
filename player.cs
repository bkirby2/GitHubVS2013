using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagQuiz
{
    class Player : Person
    {
        
        private int score;
        public int Rank {get; set;}
        public double RawScore {get; set;}
        public double AdjScore {get; set;}

        public Player (string firstName, string lastName, DateTime birthday)
            : base(firstName, lastName, birthday)
        {
            
        }

        //public Player(string firstName, string lastName, int age)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Age = age;
        //    this.Score = 0;
        //}

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int Age { get; set; }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value * 20;
            }
        }
    }
}
