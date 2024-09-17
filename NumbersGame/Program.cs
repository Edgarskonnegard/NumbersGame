namespace NumbersGame
{
    internal class Program
    {
        /// <summary>
        /// A method to check a guess with a specified target value and prints a message regarding the guessed values accuracy.
        /// </summary>
        /// <param name="guess">The players guess</param>
        /// <param name="correctValue">The target value</param>
        /// <returns></returns>
        static bool CheckGuess(int guess, int correctValue) // Kollar om gissningen är korrekt
        {
            if (guess == correctValue)
            {
                Console.WriteLine("Wohoo! Du gjorde det!");
                return true;
            }
            else if (guess <= correctValue)
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

            // Generate a random number between 1 and 20 from the class Random with the method Next.
            Random rng = new Random(); 
            int target = rng.Next(1, 21);

            int playerGuess = 0;
            int count = 0;

            // Loop for the five attempts the player has.
            while (count < 5)
            {
                // Uses try catch to prevent user from an invalid input.
                try
                {
                    playerGuess = Convert.ToInt32(Console.ReadLine());
                    if (CheckGuess(playerGuess, target))
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

            // "Game over" message for player. 
            if (count == 5)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }

        }
    }
}
