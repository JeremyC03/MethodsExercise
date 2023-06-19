using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Functions
    {
        public int Add(int num1, int num2)
        {
            int add = num1 + num2;
            return add;
        }
        public int Subtract(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }
        public int Multiply(int num1, int num2)
        {
            int mult = num1 * num2;
            return mult;
        }
        public int Divide(int num1, int num2)
        {
            int div = num1 / num2;
            return div;
        }
        public int Modulus(int num1, int num2)
        {
            int mod = num1 % num2;
            return mod;
        }
    }
}
