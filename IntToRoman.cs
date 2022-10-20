using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class IntToRoman
    {
        static public string IntToRoman_var1(int num)
        {
            string[] tousends = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] dec = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] eds = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return tousends[num / 1000] + hundreds[(num % 1000) / 100] + dec[(num % 100) / 10] + eds[num % 10];
        }

        static public string IntToRoman_var2(int num)
        {
            string[] tousends = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] dec = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] eds = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return $"{tousends[num / 1000]}{hundreds[(num % 1000) / 100]}{dec[(num % 100) / 10]}{eds[num % 10]}";
        }

        static string[] tou = { "", "M", "MM", "MMM" };
        static string[] hun = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        static string[] dec1 = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        static string[] eds2 = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        static public string IntToRoman_var3(int num)
        {
            return $"{tou[num / 1000]}{hun[(num % 1000) / 100]}{dec1[(num % 100) / 10]}{eds2[num % 10]}";
        }

        static public string IntToRoman_var4(int num)
        {
            string[] tau = { "", "M", "MM", "MMM", "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return tau[num / 1000] + tau[((num % 1000) / 100) + 4] + tau[((num % 100) / 10) + 14] + tau[(num % 10) + 24];
        }
        // 1000 - 0
        // 100  - +4 
        // 10   - +14
        // 1    - +24


        static public string IntToRoman_var5(int num)
        {
            int tau = num / 1000;
            int hun = (num % 1000) / 100;
            int dec = (num % 100) / 10;
            int eds = num % 10;

            var res = new StringBuilder();
            switch (tau)
            {
                case 0:
                    break;
                case 1:
                    {
                        res.Append("M");
                        break;
                    }
                case 2:
                    {
                        res.Append("MM");
                        break;
                    }
                case 3:
                    {
                        res.Append("MM");
                        break;
                    }
            }

            switch (hun)
            {
                case 0:
                    break;
                case 1:
                    {
                        res.Append("C");
                        break;
                    }
                case 2:
                    {
                        res.Append("CC");
                        break;
                    }
                case 3:
                    {
                        res.Append("CCC");
                        break;
                    }
                case 4:
                    {
                        res.Append("CD");
                        break;
                    }
                case 5:
                    {
                        res.Append("D");
                        break;
                    }
                case 6:
                    {
                        res.Append("DC");
                        break;
                    }
                case 7:
                    {
                        res.Append("DCC");
                        break;
                    }
                case 8:
                    {
                        res.Append("DCCC");
                        break;
                    }
                case 9:
                    {
                        res.Append("CM");
                        break;
                    }
            }


            switch (dec)
            {
                case 0:
                    break;
                case 1:
                    {
                        res.Append("X");
                        break;
                    }
                case 2:
                    {
                        res.Append("XX");
                        break;
                    }
                case 3:
                    {
                        res.Append("XXX");
                        break;
                    }
                case 4:
                    {
                        res.Append("XL");
                        break;
                    }
                case 5:
                    {
                        res.Append("L");
                        break;
                    }
                case 6:
                    {
                        res.Append("LX");
                        break;
                    }
                case 7:
                    {
                        res.Append("LXX");
                        break;
                    }
                case 8:
                    {
                        res.Append("LXXX");
                        break;
                    }
                case 9:
                    {
                        res.Append("XC");
                        break;
                    }
            }


            switch (eds)
            {
                case 0:
                    break;
                case 1:
                    {
                        res.Append("I");
                        break;
                    }
                case 2:
                    {
                        res.Append("II");
                        break;
                    }
                case 3:
                    {
                        res.Append("III");
                        break;
                    }
                case 4:
                    {
                        res.Append("IV");
                        break;
                    }
                case 5:
                    {
                        res.Append("V");
                        break;
                    }
                case 6:
                    {
                        res.Append("VI");
                        break;
                    }
                case 7:
                    {
                        res.Append("VII");
                        break;
                    }
                case 8:
                    {
                        res.Append("VIII");
                        break;
                    }
                case 9:
                    {
                        res.Append("IX");
                        break;
                    }
            }

            return res.ToString();
        }

    }
}
