using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2ChallengeFinished
{
    internal class Player
    {
        //Attributes
        private string name;

        private int score;

        private int livesLeft;
        //Methods - contstructor
        public Player(string name)

        {

            this.name = name;

        }


        //Overloaded constructor
        public Player(string name, int startingLives)

        {

            this.name = name;

            livesLeft = startingLives;

        }

        //Methods - getters and setters & tasks
        public int GetScore()
        {
            return score;
        }

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        public void Kill()
        {
            // We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;

            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }
    }
}
