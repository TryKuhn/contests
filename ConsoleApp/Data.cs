/*
 * This file helps to check if file is good
 */

namespace checkData
{
    public class Data
    {
        public static bool Bad(ref List<List<string>> parsedData) // Checker
        {
            if (parsedData.Count == 0)
            {
                Console.WriteLine("Empty file!");
                return true;
            }

            HashSet<string> use = new HashSet<string>();
            for (int i = 0; i < parsedData.Count; i++)
            {
                if (parsedData[i].Count != 12)
                {
                    return true;
                }

                if (i == 0)
                {
                    continue;
                }

                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Vessels in Port" || parsedData[0][j] == "Departures(Last 24 Hours)" ||
                        parsedData[0][j] == "Arrivals(Last 24 Hours)" || parsedData[0][j] == "Expected Arrivals" ||
                        parsedData[0][j] == "Country" || parsedData[0][j] == "Port Name" ||
                        parsedData[0][j] == "UN Code" ||
                        parsedData[0][j] == "Type" || parsedData[0][j] == "Area Local" ||
                        parsedData[0][j] == "Area Global" ||
                        parsedData[0][j] == "Also known as")
                    {
                        use.Add(parsedData[0][j]);
                    }

                    if (parsedData[0][j] == "Vessels in Port" || parsedData[0][j] == "Departures(Last 24 Hours)" ||
                        parsedData[0][j] == "Arrivals(Last 24 Hours)" || parsedData[0][j] == "Expected Arrivals")
                    {
                        if (!Int32.TryParse(parsedData[i][j], out int cur) || (cur < 0))
                        {
                            return true;
                        }
                    }
                }
            }

            if (use.Count != 11)
            {
                return true;
            }

            return false;
        }
    }
}