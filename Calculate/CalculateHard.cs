using Calculates.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculates
{
    internal class CalculateHard : ICalculateHard
    {
        private const float PI = 3.14f;
        public double Pow(double num1, double num2)
        {
            double j = num1;
            if (num2 == 0) return 1;
            else if (num2 == 1) return num1;
            for (int i = 1; i < num2; i++)
            {
                j *= num1;
            }
            return j;
        }
        public double Sqrt(double num1)
        {
            return 0; //??
        }
        public double Sin(double num1)
        {
            return num1 * PI / 180;
        }
        public double Cos(double num1)
        {
            return num1 * PI / 60;
        }
        public double Tan(double num1)
        {
            return num1 * PI / 90;
        }
    }
}
