using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.UsoltsevAD.Sprint2.Task6.V9.Lib;
namespace Tyuiu.UsoltsevAD.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Усольцев А.Д. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Усольцев А.Д. | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая определяет дату следующего дня,             *");
            Console.WriteLine("* принимая от пользователя текущий месяц и день.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите месяц (числом, где 1 - это январь, а 12 - это декабрь):");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день (от 1 до 31):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Дата следующего дня: {ds.FindDateOfNextDay(m, n)}");
            Console.ReadKey();
        }
    }
}
