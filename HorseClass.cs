using System;

namespace cSharpClasses 
{
    class Horse 
    {
        public string HorseName;
        public string JockeyName;
        public string TrainerName;
        public int HorseAge;
        public int NumberOfWins;

        // public void RaceHorseDeets() 
        // {
        //     Console.WriteLine("The horses' name is: {0}", HorseName);
        //     Console.WriteLine("The jockey's name is: {0}", JockeyName);
        //     Console.WriteLine("The trainer name is: {0}", TrainerName);
        //     Console.WriteLine("The age of the horse is: {0}", HorseAge);
        //     Console.WriteLine("The horse has won {0} times", NumberOfWins);
        // }
        public void RaceHorseConstructor(string HName, string JName, string TName, int HAge, int NWins) 
        {
            HorseName = HName;
            JockeyName = JName;
            TrainerName = TName;
            HorseAge = HAge;
            NumberOfWins = NWins;
        }
    }
}