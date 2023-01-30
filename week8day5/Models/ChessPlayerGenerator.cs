namespace week8day5.Models
{
    public class ChessPlayerGenerator : IPlayerGenerator
    {
        public Player CreateChessPlayers()
        {
            return new Player()
            {
                Name = "Jenifeer",
                Age = 30,
                Gender=Gender.Female,
                Haircolor=Haircolor.Brown,
                Score=1500,
                Race="Hooman"

            };
        }

        

       
    }
}
