using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PaulikKV.Sprint1.TaskReview.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            double res = (((2 + Math.Pow(Math.Cos(x + y), 2)) / (1 + Math.Abs(x - ((3 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)))))) + x * y);
            return Math.Round(res, 3) ;
        }
    }
}
