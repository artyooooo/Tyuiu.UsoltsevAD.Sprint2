using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UsoltsevAD.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            string text = $"{x}{y}";
            string[] array = new string[] {"210", "211", "212", "213", "33", "34", "35", "310", "311", "312", "313",
            "42", "43", "44", "45", "410", "411", "412", "52", "53", "54", "55", "56", "57",
            "58", "59", "510", "511", "512", "63", "64", "65", "66", "67", "68",
            "73", "74", "75", "76", "77", "78", "86", "87", "88", 
            "96", "97", "98", "106", "107", "108", "113", 
            "114", "115", "116", "117", "118", "119", "1110", "1111", "1112", "1113",
            "127", "128", "129", "1210", "1213", "1313"};
            if (array.Contains(text))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
