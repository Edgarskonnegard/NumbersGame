namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random rng = new Random();
            int num = rng.Next(1, 21);
            int userGuess;
            int count = 0;
            while (count < 5)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());
                count++;

            }

        }
    }
}
