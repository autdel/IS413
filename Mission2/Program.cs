using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] totals = new int[11];

            for (int i = 0; i < 11; i++)
            {
                totals[i] = 0;
            }

            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate? ");

            int rolls = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < rolls; i++)
            {
                //  Console.WriteLine(r.Next(1, 7));
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);

                int rollSum = roll1 + roll2;

                totals[rollSum - 2]++;
            }


            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n\nEach '*' represents 1 % of the " +
                "total number of rolls.\nTotal number of rolls = " +  rolls + ".\nNote: These values are rounded.\n");

            for (int i = 0; i < totals.Length; i++)
            {
                int printNum = i + 2;
                
                double onePerc = (double)(rolls * 0.01);
                double numAst = onePerc * totals[i];

                string asterisk = "";

                for (int j = 0; j < numAst; j++)
                {
                    asterisk += "*";
                }
                Console.WriteLine(printNum + ": " + asterisk);
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n");
            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
