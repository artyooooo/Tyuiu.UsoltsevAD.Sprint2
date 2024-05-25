using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UsoltsevAD.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            double ySinX = Math.Sin(x);
            double yLower = 0.5;

            // Проверка нахождения точки в заштрихованной области
            if (y >= yLower && y <= ySinX)
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
