using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start prog!!!");

            string ss = "ab";
            string pp = ".*..c*";
            bool result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "gc"; pp = "g.*c"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "aaaaa"; pp = "aaaa"; result = false;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "aaba"; pp = ".*aa.a"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "a"; pp = "ab*"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "a"; pp = "a.*"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "a"; pp = "a*c"; result = false;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "ab"; pp = ".*c"; result = false;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "aa"; pp = "a*"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "ab"; pp = ".*"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            ss = "aab"; pp = "c*a*b"; result = true;
            Console.ForegroundColor = (IsMatch(ss, pp) != result) ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($"{ss} - {pp} - Wait {result}: result - {IsMatch(ss, pp)}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Good bye");
            // ------------------------------------------------------------------------------------------------------
        }


        static public bool IsMatch(string s, string p)
        {
            // work with pattern - calc min len of string --------------------------
            // and create work pattern ------------------
            int minlen = p.Length;
            char[] arr = new char[minlen];
            int j = 0;
            int inds = 0;
            int indp = 0;
            int starind = -1;
            int laststarind = -1;
            int step1_stop = -1;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    minlen -= 2;
                    j--;
                    arr[j] = (char)0;
                    laststarind = i;
                }
                else
                {
                    arr[j] = p[i];
                    j++;
                }
            }

            if (s.Length < minlen)
            {
                return false;
            }

            // fisrt check - before * --------------------------------------------------------
            for (indp = 0; indp < p.Length; indp++)
            {
                if (indp + 1 < p.Length && p[indp + 1] == '*')
                {
                    starind = indp + 1;
                    break;
                }

                if (p[indp] != '.' && p[indp] != s[inds])
                {
                    return false;
                }
                else
                {
                    inds++;
                }

                if (inds == s.Length)
                {
                    indp++;
                    break;
                }
            }

            // here check stop for cycle by count or exit by break ?
            if (starind == -1)
            {
                return (inds == indp && indp == p.Length && inds == s.Length);
            }

            // ------------ next step - middle check -------------------------------------------
            else
            {

            }

            // ------------------- last check - end -------------------------------------------
            step1_stop = inds - 1;
            if (laststarind != -1 && laststarind != p.Length - 1)
            {
                indp = p.Length - 1;
                indp = p.Length - 1;
                inds = s.Length - 1;
                int countp = 0;
                int counts = 0;
                for (; laststarind < indp; indp--)
                {
                    if (inds == step1_stop)
                    {
                        counts = -1;
                        break;
                    }
 
                    if (p[indp] != '.' && p[indp] != s[inds])
                    {
                        return false;
                    }
                    else
                    {
                        inds--;
                        counts++;
                    }

                    countp++;
                }
               
                
                // if (countp == counts) 
                return (countp == counts);
            }

            return true;
        }

        /* static public bool IsMatch(string s, string p)
        {
            int j = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '.')
                {
                    if (i + 1 < p.Length && p[i + 1] == '*')
                    {
                        // ------------------------ here combination .* ---------------------------------------------
                        i++;
                        if (i + 1 < p.Length)
                        {
                            if (p[i + 1] == '.')
                            {
                                if (i + 2 < p.Length && p[i + 2] == '*')
                                {
                                    // next '.'
                                    i++;
                                }
                                else
                                {
                                    // next only '.' 
                                    i++;
                                    for (int k = s.Length - 1; j < k; k--)
                                    {
                                        if (p[i + 1] == s[k])
                                        {
                                            j = k;
                                        }
                                    }
                                    if (j + 1 < s.Length)
                                    {
                                        j++;
                                    }
                                    else { return false; }
                                }
                            }

                            else
                            {
                                // next symbol 'x'
                                for (int k = s.Length - 1; j < k; k--)
                                {
                                    if (p[i + 1] == s[k])
                                    {
                                        j = k;
                                    }
                                }
                            }
                        }
                        else
                        {
                            return true;
                        }

                    }
                    else
                    {
                        // ------------------------ here is only point '.'
                        if (j + 1 < s.Length)
                        {
                            j++;
                        }
                        else
                        {
                            if (i == p.Length - 1) { return true; }
                            return false;
                        }
                    }
                }
                else
                {
                    if (i + 1 < p.Length && p[i + 1] == '*')
                    {
                        // --------------------- here combination x*
                        i++;
                        if (j == s.Length)
                        {
                            return (i == p.Length - 1);
                        }
                        while (s[j] == p[i - 1])
                        {
                            j++;
                            if (j == s.Length) { return true; }
                        }
                    }
                    else
                    {
                        // ------------------------ here is only one letter --------------
                        if (j == s.Length)
                        {
                            // return (i == p.Length - 1);
                            return false;
                        }


                        if (s[j] == p[i])
                        {
                            j++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (j < s.Length) { return false; }
            return true;
        }

         static public bool IsMatch2(string s, string p)
        {
            int j = 0;
            bool flagInfinity = false;
            char prevelem = (char)0;
            if (s.Length == 0 || p.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '.') {
                    j++;
                } 
                
                else if (p[i] == '*') {
                    if (prevelem == '.')
                    {
                        if (i+1 < p.Length)
                        {
                            i++;
                            for (int k = s.Length-1; j < k; k--)
                            {

                            }
                        }
                        else { return true; }
                    }
                    else
                    {
                        while (s[j] == prevelem)
                        {
                            j++;
                            if (j == s.Length) { return true; }
                        }
                    }
                }
                
                else {
                    // ---------- letter ------------------------------------------------------------- //                    
                    if (p[i] == s[j])
                    {
                        j++;
                    } else
                    {
                        if (i + 1 < p.Length && p[i + 1] != '*')
                        {
                            return false;
                        }
                    }
                }

                prevelem = p[i];
            }
            
            if (j != s.Length) { return false;  }
            return true;
        }*/

    }
}