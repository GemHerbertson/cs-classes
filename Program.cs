using System;

namespace cSharpClasses
{
    class PrintingClass {
        public void PrintingFunction() 
        {
            Console.WriteLine("*print*");
        }

        public void AnotherFunction()
        {
            Console.WriteLine("*print*");
        }

        public void AllTheData() 
        {
            Console.WriteLine("Hopefully, something is printed below me.");
            PrintingFunction();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintingClass myNewPrintingClass = new PrintingClass();
            myNewPrintingClass.AllTheData();

            Horse HorseyMcHorseFace = new Horse("Horsey McHorse Face", "McDougal", "Ronald McDonald", 24, 11);
            Console.WriteLine(HorseyMcHorseFace.HorseName + "" + HorseyMcHorseFace.JockeyName + "" + HorseyMcHorseFace.TrainerName + "" + HorseyMcHorseFace.HorseAge + "" + HorseyMcHorseFace.NumberOfWins);
            // HorseyMcHorseFace.HorseName = "Horsey McHorse Face";
            // HorseyMcHorseFace.JockeyName = "McDougal";
            // HorseyMcHorseFace.TrainerName = "Ronald McDonald";
            // HorseyMcHorseFace.HorseAge = 24;
            // HorseyMcHorseFace.NumberOfWins = 11;

            somewhereElse.Error myNewError = new somewhereElse.Error();
            myNewError.ErrorMessage = "Just say NO!";
        }
    }
}
