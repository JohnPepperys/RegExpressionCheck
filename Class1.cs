using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        static public string IntToRoman(int num)
        {
            // char[,] tousends = { { 0 }, { 'M' }, { 'M', 'M' }, { 'M', 'M', 'M' } };
            //char[,] hundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            //char[,] dec = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            // char[,] eds = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            // return tousends[num / 1000] + hundreds[(num % 1000) / 100] + dec[(num % 100) / 10] + eds[num % 10];
            // return $"{tousends[num / 1000]}{hundreds[(num % 1000) / 100]}{dec[(num % 100) / 10]}{eds[num % 10]}";
            return "";
        }

        /*  static public string IntToRoman(int num)
        {
            char[] result = new char[20];
            int count = 0;
            if (num < 1 || num > 3999) {
                return "";
            }

            /// ------ 1000 -----------
            int tousend = num / 1000;
            switch (tousend) {
                case 3:
                    result[0] = 'M';
                    result[1] = 'M';
                    result[2] = 'M';
                    count += 3;
                    break;

                case 2:
                    result[0] = 'M';
                    result[1] = 'M';
                    count += 2;
                    break;
                case 1:
                    result[0] = 'M';
                    count++;
                    break;
                case 0:
                    break;
            }

            /// ------ 100 -------------
            int tempnum = num - (tousend * 1000);
            int hundreds = tempnum / 100;

            switch (hundreds)
            {
                case 9:
                    result[count] += 'C';
                    result[count+1] += 'M';
                    count += 2;
                    break;
                case 8:
                    result[count] += 'D';
                    result[count + 1] += 'C';
                    result[count + 2] += 'C';
                    result[count + 3] += 'C';
                    count += 4;
                    break;
                case 7:
                    result[count] += 'D';
                    result[count + 1] += 'C';
                    result[count + 2] += 'C';
                    count += 3;
                    break;
                case 6:
                    result[count] += 'D';
                    result[count + 1] += 'C';
                    count += 2;
                    break;
                case 5:
                    result[count] += 'D';
                    count++;
                    break;
                case 4:
                    result[count] += 'C';
                    result[count + 1] += 'D';
                    count += 2;
                    break;
                case 3:
                    result[count] += 'C';
                    result[count + 1] += 'C';
                    result[count + 2] += 'C';
                    count += 3;
                    break;
                case 2:
                    result[count] += 'C';
                    result[count + 1] += 'C';
                    count += 2;
                    break;
                case 1:
                    result[count] += 'C';
                    count++;
                    break;
                case 0:
                    break;
            }
            /// ------- 10 ------------
            tempnum = tempnum - (hundreds * 100);
            int decim = tempnum / 10;
            switch (decim)
            {
                case 9:
                    result[count] += 'X';
                    result[count + 1] += 'C';
                    count += 2;
                    break;
                case 8:
                    result[count] += 'L';
                    result[count + 1] += 'X';
                    result[count + 2] += 'X';
                    result[count + 3] += 'X';
                    count += 4;
                    break;
                case 7:
                    result[count] += 'L';
                    result[count + 1] += 'X';
                    result[count + 2] += 'X';
                    count += 3;
                    break;
                case 6:
                    result[count] += 'L';
                    result[count + 1] += 'X';
                    count += 2;
                    break;
                case 5:
                    result[count] += 'L';
                    count++;
                    break;
                case 4:
                    result[count] += 'X';
                    result[count + 1] += 'L';
                    count += 2;
                    break;
                case 3:
                    result[count] += 'X';
                    result[count + 1] += 'X';
                    result[count + 2] += 'X';
                    count += 3;
                    break;
                case 2:
                    result[count] += 'X';
                    result[count + 1] += 'X';
                    count += 2;
                    break;
                case 1:
                    result[count] += 'X';
                    count++;
                    break;
                case 0:
                    break;
            }

            /// --------- 1 ---------------
            tempnum = num % 10;
            switch (tempnum)
            {
                case 9:
                    result[count] += 'I';
                    result[count+1] += 'X';
                    count += 2;
                    break;
                case 8:
                    result[count] += 'V';
                    result[count + 1] += 'I';
                    result[count + 2] += 'I';
                    result[count + 3] += 'I';
                    count += 4;
                    break;
                case 7:
                    result[count] += 'V';
                    result[count + 1] += 'I';
                    result[count + 2] += 'I';
                    count += 3;
                    break;
                case 6:
                    result[count] += 'V';
                    result[count + 1] += 'I';
                    count += 2;
                    break;
                case 5:
                    result[count] += 'V';
                    count++;
                    break;
                case 4:
                    result[count] += 'I';
                    result[count + 1] += 'V';
                    count += 2;
                    break;
                case 3:
                    result[count] += 'I';
                    result[count + 1] += 'I';
                    result[count + 2] += 'I';
                    count += 3;
                    break;
                case 2:
                    result[count] += 'I';
                    result[count + 1] += 'I';
                    count += 2;
                    break;
                case 1:
                    result[count] += 'I';
                    count++;
                    break;
                case 0:
                    break;
            }

            var res = new string(result);
            return res.Substring(0, count);
        }*/
        // --------------------------------------------------------------------------------------------------------------------------------------------------------

    }





    // --------------------------------------------------------------------------------------------------------------------------------------------------------
    public class Solution
    {
        static public string Convert(string s, int numRows)
        {
            if (numRows == 1) { return s; }
            var len = s.Length;
            if (len <= numRows) { return s; }
            if (numRows == 2)
            {
                char[] arr = new char[len];
                if (len % 2 == 0)
                {
                    for (int i = 0; i < len / 2; i++)
                    {
                        arr[i] = s[i * 2];
                        arr[len / 2 + i] = s[i * 2 + 1];
                    }
                }
                else
                {
                    for (int i = 0; i < (len / 2); i++)
                    {
                        arr[i] = s[i * 2];
                        arr[len / 2 + 1 + i] = s[i * 2 + 1];
                    }
                    arr[len / 2] = s[len - 1];
                }
                return new String(arr);
            }

            var step = numRows + numRows - 2;
            char[] result = new char[len];
            int row = 0;
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                result[i] = s[k++ * step + row];
                if (row != 0 && row != numRows - 1)
                {
                    if ((k * step - row) > len - 1)
                    {
                        k = 0;
                        row++;
                    }
                    else
                    {
                        result[++i] = s[k * step - row];
                    }
                }
                if ((k * step + row) >= len)
                {
                    k = 0;
                    row++;
                }
            }
            return new String(result);
        }


        //-----------------------------------------------------------------------------------------------=---------------------------------------------------------

        static public string Convert2(string s, int numRows)
        {
            if (numRows == 1) { return s; }
            var len = s.Length;
            if (len <= numRows) { return s; }
            if (numRows == 2)
            {
                return ":OK";
            }
            int step = 2 * numRows - 2;
            int segment = len / step + 1;
            string[] arrstr = new string[segment];
            int i = 0, j = 0, ind = 0;
            char[] arr = new char[len];
            for (; i < segment - 1; i++)
            {
                arrstr[i] = s.Substring(i * step, step);
                Console.WriteLine($"{arrstr[i]} and len {arrstr[i].Length}");

                arr[j] = arrstr[i][0];

                arr[segment + j] = arrstr[i][1];
                arr[segment + j + 1] = arrstr[i][step - 1];

                arr[segment + step + j] = arrstr[i][2];
                arr[segment + step + j + 1] = arrstr[i][step - 2];

                arr[2 * step + segment + j] = arrstr[i][3];
                j++;
            }
            arrstr[i] = s.Substring(i * step, len - (i * step));
            Console.WriteLine($"{arrstr[i]} and len {arrstr[i].Length}");

            return new String(arr);
        }
        //---------------------------------------------------------------------------------------------- = ------------------------------------------------------------


        static public void PaintofZ(string s, int numRows)
        {
            Console.WriteLine(s);
            Console.WriteLine("");

            if (numRows == 1) { Console.WriteLine(s); }
            char[][] arr = new char[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                arr[i] = new char[s.Length];
                for (int j = 0; j < s.Length; j++)
                {
                    arr[i][j] = '-';
                }
            }

            int x = 0; int y = 0;
            int flag = 0;
            for (int i = 0; i < s.Length; i++)
            {
                arr[y][x] = s[i];
                if (flag == 0)
                {
                    y++;
                }
                if (flag == 1) { y--; x++; }
                if (y == numRows - 1) { flag = 1; }
                if (y == 0) { flag = 0; }
            }

            for (int i = 0; i < numRows; i++)
            {
                Console.WriteLine(new String(arr[i]));
            }
            Console.WriteLine("");
        }

    }
}
