using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.TaskReview.V20.Lib;

namespace Tyuiu.PaulikKV.Sprint1.TaskReview.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Sprint Review                                                     *");
            Console.WriteLine("* Задание 7                                                               *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет математическое выражение *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем. Ответ округлите   *");
            Console.WriteLine("* до 3 знаков после запятой *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x,y;
            Console.WriteLine("Введите число X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y:");
            y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Значение выражения =  " + res);
            Console.ReadKey();
        }
    }
}
