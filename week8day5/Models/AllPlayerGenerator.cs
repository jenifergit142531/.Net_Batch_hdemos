using System.Net.Cache;

namespace week8day5.Models
{
    public class AllPlayerGenerator : IAllPlayers
    {

        private readonly string[] maleNames = { "Jon", "Mark", "Adam", "Steve", "patrick" };
        private readonly string[] femaleNames = { "Amy", "sara", "April", "June", "Kate" };

        public Player CreateNewPlayer()
        {
            string playerName;
            var random = new Random();
            var playerNameIndex = random.Next(5);
            var playerHairColorIndex = random.Next(4);
            var playerGenderIndex = random.Next(2);
            if (playerGenderIndex == 0)
                playerName = maleNames[playerNameIndex];
            else
                playerName = femaleNames[playerNameIndex];

            var playerAge = random.Next(18, 40);
            var playerScore = random.Next(1000, 5000);

            return new Player
            {
                Name = playerName,
                Gender = (Gender)playerGenderIndex,
                Haircolor = (Haircolor)playerHairColorIndex,
                Age = playerAge,
                Score = playerScore,
                Race = "Human"

            };

        }

        public string AllPlayerMessage()
        {
            return "This is a All Player Group ";
        }

       
    }
}

    

