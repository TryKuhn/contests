using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    private static string[] ReadCodeLines(string codePath)
    {
        string[] cur = File.ReadAllLines(codePath);
        return cur;
    }

    private static bool ShouldAdd(string s)
    {
        bool ok = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                ok = true;
            }
        }

        return ok;
    }

    private static void DeleteMultiLine(ref string[] code)
    {
        List<Tuple<Tuple<int, int>, Tuple<int, int>>> crd = new List<Tuple<Tuple<int, int>, Tuple<int, int>>>();
        bool opened = false;
        bool start = false;
        
        for (int i = 0; i < code.Length; i++)
        {
            start = false;
            for (int j = 0; j + 1 < code[i].Length; j++)
            {
                if (!opened && !start && code[i][j] != ' ' && code[i][j] != '/')
                {
                    break;
                } else if (!start && code[i][j] != ' ')
                {
                    start = true;
                }
                    if (!opened && code[i][j] == '/' && code[i][j + 1] == '/')
                {
                    crd.Add(new Tuple<Tuple<int, int>, Tuple<int, int>>(new Tuple<int, int>(i, j), new Tuple<int, int>(i, code[i].Length - 1)));
                    break;
                }
                if (!opened && code[i][j] == '/' && code[i][j + 1] == '*')
                {
                    opened = true;
                    crd.Add(new Tuple<Tuple<int, int>, Tuple<int, int>>(new Tuple<int, int>(i, j), new Tuple<int, int>(-1, -1)));
                    j++;
                    continue;
                }

                if (opened && code[i][j] == '*' && code[i][j + 1] == '/')
                {
                    opened = false;
                    crd[crd.Count - 1] = new Tuple<Tuple<int, int>, Tuple<int, int>>(crd[crd.Count - 1].Item1, new Tuple<int, int>(i, j + 1));
                    j++;
                    continue;
                }
            }
        }

        foreach (var i in crd)
        {
            Console.WriteLine(i);
        }

        List<string> ans = new List<string>();

        int idx = 0;

        for (int i = 0; i < code.Length; i++)
        {
            if (idx != crd.Count && (i > crd[idx].Item1.Item1 && i < crd[idx].Item2.Item1))
            {
                continue;
            }

            string add = new string("");
            if (idx != crd.Count && (crd[idx].Item1.Item1 == i || crd[idx].Item2.Item1 == i))
            {
                for (int j = 0; j < code[i].Length; j++)
                {
                    if (idx != crd.Count && crd[idx].Item1.Item1 == crd[idx].Item2.Item1 && crd[idx].Item1.Item1 == i)
                    {
                        if (j >= crd[idx].Item1.Item2 && j <= crd[idx].Item2.Item2)
                        {
                            if (crd[idx].Item2.Item1 == i && crd[idx].Item2.Item2 == j)
                            {
                                idx++;
                            }
                            continue;
                        }
                    }
                    if (idx != crd.Count && (crd[idx].Item1.Item1 == i || crd[idx].Item2.Item1 == i) && (crd[idx].Item1.Item1 != crd[idx].Item2.Item1) && ((j >= crd[idx].Item1.Item2 && crd[idx].Item1.Item1 == i) || (j <= crd[idx].Item2.Item2 && crd[idx].Item2.Item1 == i)))
                    {
                        if (crd[idx].Item2.Item1 == i && crd[idx].Item2.Item2 == j)
                        {
                            idx++;
                        }
                        continue;
                    }

                    add = add + code[i][j]; // !!! NOT OPTIMALLY
                }
            }
            else
            {
                add = code[i];
            }

            if (ShouldAdd(add))
            {
                ans.Add(add);
            }
        }

        string[] ret = new string[ans.Count];
        for (int i = 0; i < ans.Count; i++)
        {
            ret[i] = ans[i];
        }

        code = ret;
    }


    private static string[] CleanCode(string[] codeWithComments)
    {
        DeleteMultiLine(ref codeWithComments);
        return codeWithComments;
    }

    private static void WriteCode(string codeFilePath, string[] codeLines)
    {
        File.WriteAllLines(codeFilePath, codeLines);
    }
}
