/*
 * Main program, in which we interact with user
 */

using checkData;
using split;
using help;

class Program
{

    public static void Main(string[] args)
    {
        while (true)
        {
            // Try to enter path
            Console.WriteLine("Enter the absolute path"); 
            string name = Console.ReadLine();
            if (!File.Exists(name))
            {
                Console.WriteLine("Wrong path! If you want to try again, press F11");
                if (Console.ReadKey().Key == ConsoleKey.F11)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            string[] data = File.ReadAllLines(name);
            List<List<string>> parsedData = Splitter.ParseInfo(data);

            // Check if everything is ok
            if (Data.Bad(ref parsedData))
            {
                Console.WriteLine("Error! Incorrect data. Try another file. If you want to try again, press F11");
                if (Console.ReadKey().Key == ConsoleKey.F11)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            // Answer the queries
            while (true)
            {
                Helper.PrintAllVariants();

                if (!Int32.TryParse(Console.ReadLine(), out int query) || (query <= 0 || query > 12))
                {
                    Console.WriteLine("Bad query! Try again");
                    continue;
                } 
                
                if (!Helper.StartQuery(ref parsedData, query))
                {
                    break;
                }
            } 

            break;
        }
    }
}