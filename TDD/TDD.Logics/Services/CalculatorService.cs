using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Logics.Contracts;

namespace TDD.Logics.Services
{
    public class CalculatorService : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Divide(int x, int y)
        {
            try
            {
                if (x == 0 && y == 0)
                {
                    throw new ArgumentException("Zero divide by zero is Infinity");
                }
                return x / y;
            }

            catch (ArgumentException)
            {
                throw;
            }
            catch (DivideByZeroException)
            {
                throw;
            }

        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }


    }
}
