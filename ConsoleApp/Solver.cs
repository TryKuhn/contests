/*
 * Main file with realisation of all described functions 
 */

using help;

namespace solve
{
    public class Solver
    {
        public static void InfoAboutPorts(ref List<List<string>> parsedData, string type, string file = "") // Gives information about Ports/Anchorages
        {
            List<List<string>> ans = new List<List<string>>();
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                List<string> info = new List<string>();
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Port Name" || parsedData[0][j] == "UN Code")
                    {
                        info.Add(parsedData[i][j]);
                    }

                    if (parsedData[0][j] == "Type" && type == parsedData[i][j])
                    {
                        add = true;
                    }
                }

                if (add || i == 0)
                {
                    ans.Add(info);
                }
            }

            Helper.PrintPairs(ref ans, file);
        }

        public static void InfoAboutCountry(ref List<List<string>> parsedData, string country, string file = "") // Gives information about all ports of the country
        {
            int cnt = -1;
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                int cur = -1;

                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Country" && parsedData[i][j] == country)
                    {
                        add = true;
                    }

                    if (i > 0 && parsedData[0][j] == "Vessels in Port")
                    {
                        cur = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (add)
                {
                    if (cnt < cur)
                    {
                        cnt = cur;
                    }
                }
            }

            List<List<string>> ans = new List<List<string>>();
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                List<string> curInfo = new List<string>();
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Port Name" || parsedData[0][j] == "UN Code")
                    {
                        curInfo.Add(parsedData[i][j]);
                    }

                    if (i > 0 && parsedData[0][j] == "Vessels in Port" && Int32.Parse(parsedData[i][j]) == cnt)
                    {
                        add = true;
                    }
                }

                if (i == 0 || add)
                {
                    ans.Add(curInfo);
                }
            }
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                List<string> curInfo = new List<string>();
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Port Name" || parsedData[0][j] == "UN Code")
                    {
                        curInfo.Add(parsedData[i][j]);
                    }

                    if (i > 0 && parsedData[0][j] == "Country" && parsedData[i][j] == country)
                    {
                        add = true;
                    }
                }

                if (i == 0 || add)
                {
                    ans.Add(curInfo);
                }
            }
            
            Helper.PrintPairs(ref ans, file);
        }

        public static void BiggestDeparture(ref List<List<string>> parsedData, int value, string file = "") // Gives information about biggest ports
        {
            int mx = -1;
            for (int i = 1; i < parsedData.Count; i++)
            {
                bool add = false;
                int val = -1;
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Departures(Last 24 Hours)")
                    {
                        add = true;
                        val = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (add && val > mx)
                {
                    mx = val;
                }
            }

            List<List<string>> ans = new List<List<string>>();
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                int val = -1;
                List<string> cur = new List<string>();
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Port Name" || parsedData[0][j] == "UN Code")
                    {
                        cur.Add(parsedData[i][j]);
                    }

                    if (i > 0 && parsedData[0][j] == "Departures(Last 24 Hours)")
                    {
                        add = true;
                        val = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (i == 0 || (add && mx - val <= value))
                {
                    ans.Add(cur);
                }
            }

            Helper.PrintPairs(ref ans, file);
        }

        public static void TotalPorts(ref List<List<string>> parsedData, string country) // Gives information about number of ports of every country
        {
            int ans = 0;
            for (int i = 1; i < parsedData.Count; i++)
            {
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Country" && parsedData[i][j] == country)
                    {
                        ans++;
                    }
                }
            }

            Console.WriteLine(ans);
        }

        public static void InfoBusy(ref List<List<string>> parsedData) // Gives information about the busiest ports
        {
            int mx = -1;
            for (int i = 1; i < parsedData.Count; i++)
            {
                bool add = false;
                int val = -1;
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Vessels in Port")
                    {
                        add = true;
                        val = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (add && val > mx)
                {
                    mx = val;
                }
            }

            List<List<string>> ans = new List<List<string>>();
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                int val = -1;
                List<string> cur = new List<string>();
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Port Name" || parsedData[0][j] == "UN Code")
                    {
                        cur.Add(parsedData[i][j]);
                    }

                    if (i > 0 && parsedData[0][j] == "Vessels in Port")
                    {
                        add = true;
                        val = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (i == 0 || (add && mx == val))
                {
                    ans.Add(cur);
                }
            }

            Helper.PrintPairs(ref ans, "");
        }

        public static void InfoFree(ref List<List<string>> parsedData) // Gives information about the freest ports
        {
            int mn = Int32.MaxValue;
            for (int i = 1; i < parsedData.Count; i++)
            {
                bool add = false;
                int val = -1;
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Vessels in Port")
                    {
                        add = true;
                        val = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (add && val < mn)
                {
                    mn = val;
                }
            }

            List<List<string>> ans = new List<List<string>>();
            for (int i = 0; i < parsedData.Count; i++)
            {
                bool add = false;
                int val = -1;
                List<string> cur = new List<string>();
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Port Name" || parsedData[0][j] == "UN Code")
                    {
                        cur.Add(parsedData[i][j]);
                    }

                    if (i > 0 && parsedData[0][j] == "Vessels in Port")
                    {
                        add = true;
                        val = Int32.Parse(parsedData[i][j]);
                    }
                }

                if (i == 0 || (add && mn == val))
                {
                    ans.Add(cur);
                }
            }

            Helper.PrintPairs(ref ans, "");
        }

        public static void CountPortsSea(ref List<List<string>> parsedData, string sea) // Gives information about number of ports in every sea
        {
            int ans = 0;
            for (int i = 1; i < parsedData.Count; i++)
            {
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Area Local" && parsedData[i][j] == sea)
                    {
                        ans++;
                    }
                }
            }

            Console.WriteLine(ans);
        }

        public static void InfoCountryArrival(ref List<List<string>> parsedData, string country, int value) // Gives information about ports of the country, which everyday arrival is less than given value
        {
            int ans = 0;
            for (int i = 1; i < parsedData.Count; i++)
            {
                bool add = false;
                bool less = false;
                for (int j = 0; j < parsedData[i].Count; j++)
                {
                    if (parsedData[0][j] == "Country" && parsedData[i][j] == country)
                    {
                        add = true;
                    }
                    if (parsedData[0][j] == "Arrivals(Last 24 Hours)" && Int32.Parse(parsedData[i][j]) < value)
                    {
                        less = true;
                    }
                }

                if (add && less)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}