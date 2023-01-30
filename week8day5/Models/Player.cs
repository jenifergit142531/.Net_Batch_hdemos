namespace week8day5.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public Haircolor Haircolor { get; set; }
        public string Race { get; set; }

        

    }

    public enum Gender
    {
        Male = 0,
        Female =1
    }

    public enum Haircolor
    {
        Blue = 0,
        Black =1,
        Brown = 2,
        White = 3
    }
}
