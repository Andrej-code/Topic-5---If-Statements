namespace Topic_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string magicWord, name, waterTemp;
            int age;
            double waterKelvin, waterCelsius, waterFarhrenit;

            //Console.WriteLine("Task 1 - The Magic Word");
            //Console.WriteLine();
            //Console.Write("What is the magic word? ");
            //magicWord = Console.ReadLine();
            //if (magicWord == "please") 
            //Console.Write("You're welcome. ");

            //Console.Read();


            //Console.WriteLine("Task 2 - How old are you?");
            //Console.WriteLine();
            //Console.Write("Hey, What is your name? ");
            //name = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Okay, " + name + ", how old are you? ");
            //Console.WriteLine();
            //age = Console.Read();

            //if (age < 16)
            //    Console.WriteLine("You can't drive. " + name);

            //if (age > 18)
            //    Console.WriteLine("You can't vote. " + name);

            //if (age > 25)
            //    Console.WriteLine("You can't rent a car. " + name);

            //if (age < 25)
            //    Console.WriteLine("You can do any that's legal. " + name);

            //Console.Read();

            Console.WriteLine("Task 3 - Will it Frezze?");
            Console.WriteLine();

            waterCelsius = 0;
            waterFarhrenit = 32;
            waterKelvin = 272;
            waterTemp = Console.ReadLine();

            Console.WriteLine("What is the frezzing temperature of water?");
            Double.TryParse((Console.ReadLine(),out waterTemp);
            Console.WriteLine();
            if (waterTemp = waterCelsius)
            {
                Console.WriteLine("Ahh yes, " + waterCelsius + "degrees Celsius is correct.");
            }
                

            if (waterTemp = waterFarhrenit)
            {
                Console.WriteLine("Ahh yes, " + waterFarhrenit + "degrees farhenit is correct.");
            }
      

            if (waterTemp = waterKelvin)
            {
                Console.WriteLine("Ahh yes, " + waterKelvin + "degress Kelvin is correct.");
            }
      

        }
    }
}
