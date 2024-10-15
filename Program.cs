using System.Net.Http.Headers;

namespace Gissa_numret
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            //ny instans av random 
            Random random = new Random();
            //säkerställer att numret är mellan 1 och 20
            int number = random.Next(1, 20);
            int liv = 5;
            //en for sats för att kontrollera liv
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? du får fem försök");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Du har {liv} liv");



   
                Console.WriteLine($"Skriv gissning mellan 1 och 20: {i} ");
                // en while loop i if satsen för att kontrollera att inmatningen är korrekt
                int guess1 = 0;
                while (true)
                {
                    // tryparse för att få rätt datatyp
                    int.TryParse(Console.ReadLine(), out guess1);
                    if (guess1 > 0 && guess1 <= 20)
                    {
                        Console.WriteLine("Din inmating har lyckats");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fel inmatning");
                    }

                }

                //if sats för att kontrollera vinst eller förlust
                if (guess1 == number)
                Console.WriteLine("Du vann! Woohoo!");
                if (guess1 < number)
                {
                    Console.WriteLine($"Din gissning var för låg, du har förlorat ett liv");
                    liv--;
                }
                if (guess1 > number)
                    {
                    Console.WriteLine("Din gissing far för hög");
                    liv--;
                    }
                if (liv == 0)
                {
                    Console.WriteLine("Du vann tyvärr inte och har slut på liv");
                    break;
                }
            }

        }

    }
}
