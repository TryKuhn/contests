/*
 * Splits all data into the table
 */

namespace split
{
    public class Splitter
    {
        public static List<string> DoSplit(string curData) // Split one string
        {
            List<string> ans = new List<string>();

            bool started = false;

            List<int> borders = new List<int>();

            borders.Add(-1);
            for (int i = 0; i < curData.Length; i++)
            {
                if (curData[i] == '"')
                {
                    started = !started;
                }
                else if (curData[i] == ',' && !started)
                {
                    borders.Add(i);
                }
            }

            borders.Add(curData.Length);

            for (int i = 0; i + 1 < borders.Count; i++)
            {
                ans.Add(curData.Substring(borders[i] + 1, (borders[i + 1] - borders[i] - 1)));
            }

            return ans;
        }

        public static List<List<string>> ParseInfo(string[] data) // Split all strings
        {
            List<List<string>> parsedData = new List<List<string>>();

            for (int i = 0; i < data.Length; i++)
            {
                parsedData.Add(Splitter.DoSplit(data[i]));
            }

            return parsedData;
        }
    }
}