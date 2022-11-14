/*
 * This file consists of functions for printing and query parsing
 */

using solve;

namespace help
{
    public class Helper
    {
        public static void PrintAllData(ref List<List<string>> parsedData) // Print the table
        {
            foreach (var i in parsedData)
            {
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
        
        public static void PrintPairs(ref List<List<string>> ans, string file) // Print two columns
        {
            if (file != "")
            {
                string[] res = new string[ans.Count];
                for (int i = 0; i < ans.Count; i++)
                {
                    res[i] = ans[i][0] + "," + ans[i][1];
                }

                File.WriteAllLines(file, res);
            }
            else
            {
                for (int i = 0; i < ans.Count; i++)
                {
                    Console.WriteLine(ans[i][0] + " " + ans[i][1]);
                }
            }
        }
        
        public static void PrintAllVariants() // Print what we can do
        {
            Console.WriteLine("Enter type of the query:");
            Console.WriteLine("1\\nType - Print info about ports of given type");
            Console.WriteLine("2\\nType - Save to file info about ports of given type");
            Console.WriteLine("3\\nCountry - Print info about biggest port and list of ports of the given country");
            Console.WriteLine("4\\nCountry - Save to file info about biggest port and list of ports of the given country");
            Console.WriteLine("5\\nNumber - Print info about ports with the value of departures greater than difference between biggest value and Number");
            Console.WriteLine("6\\nNumber - Save to file info about ports with the value of departures greater than difference between biggest value and Number");
            Console.WriteLine("7\\nCountry - Print number of ports in all countries");
            Console.WriteLine("8 - All info about all of the most busy ports");
            Console.WriteLine("9 - All info about all of the least busy ports");
            Console.WriteLine("10\\nSea - Number of ports in given sea");
            Console.WriteLine("11\\nCountry\\nValue - Number of ports of given country, which arrivals is less than given value");
            Console.WriteLine("12 - Stop the program");
        }

        public static bool StartQuery(ref List<List<string>> parsedData, int query) // Query parser
        {
            switch (query)
            {
                case 1:
                {
                    string type = Console.ReadLine();
                    Solver.InfoAboutPorts(ref parsedData, type);
                    break;
                }
                case 2:
                {
                    string type = Console.ReadLine();
                    Solver.InfoAboutPorts(ref parsedData, type, " Port-" + type + ".csv");
                    break;
                }
                case 3:
                {
                    string country = Console.ReadLine();
                    Solver.InfoAboutCountry(ref parsedData, country);
                    break;
                }
                case 4:
                {
                    string country = Console.ReadLine();
                    Solver.InfoAboutCountry(ref parsedData, country, " Port-Country-" + country + ".csv");
                    break;
                }
                case 5:
                {
                    if (!Int32.TryParse(Console.ReadLine(), out int value) || value < 0)
                    {
                        Console.WriteLine("Incorrect data! Try again");
                        break;
                    }
                    Solver.BiggestDeparture(ref parsedData, value);
                    break;
                }
                case 6:
                {
                    if (!Int32.TryParse(Console.ReadLine(), out int value) || value < 0)
                    {
                        Console.WriteLine("Incorrect data! Try again");
                        break;
                    }
                    Solver.BiggestDeparture(ref parsedData, value, "Departures-Port.csv");
                    break;
                }
                case 7:
                {
                    string country = Console.ReadLine();
                    Solver.TotalPorts(ref parsedData, country);
                    break;
                }
                case 8:
                {
                    Solver.InfoBusy(ref parsedData);
                    break;
                }
                case 9:
                {
                    Solver.InfoFree(ref parsedData);
                    break;
                }
                case 10:
                {
                    string sea = Console.ReadLine();
                    Solver.CountPortsSea(ref parsedData, sea);
                    break;
                }
                case 11:
                {
                    string country = Console.ReadLine();
                    if (!Int32.TryParse(Console.ReadLine(), out int val) || val < 0)
                    {
                        Console.WriteLine("Incorrect data! Try again");
                        break;
                    }

                    Solver.InfoCountryArrival(ref parsedData, country, val);
                    break;
                }
                case 12:
                {
                    return false;
                }
                default:
                {
                    Console.WriteLine("Incorrect data! Try again!");
                    break;
                }
            }
            return true;
        }
    }
}