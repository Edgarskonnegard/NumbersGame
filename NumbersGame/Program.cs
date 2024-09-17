namespace NumbersGame
{
    internal class Program
    {
        static bool CheckGuess(int i, int correctValue) // Kollar om gissningen är korrekt
        {
            if (i == correctValue)
            {
                Console.WriteLine("Wohoo! Du gjorde det!");
                return true;
            }
            else if (i <= correctValue)
            {
                Console.WriteLine("Tyvärr du gissade för lågt!");
                return false;
            }
            else
            {
                Console.WriteLine("Tyvärr du gissade för högt!");
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            // Genererar ett slumpmässigt tal mellan 1 och 20.
            Random rng = new Random(); 
            int num = rng.Next(1, 21);

            int userGuess = 0;
            int count = 0;

            while (count < 5)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (CheckGuess(userGuess, num))
                    {
                        break;
                    }

                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Skriv endast heltal! Du har {5-count} försök kvar.");
                }
            }

            if (count == 5)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }

        }
    }
}
