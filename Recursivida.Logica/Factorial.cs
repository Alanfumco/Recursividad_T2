using System;
using System.Collections.Generic;
using System.Text;

namespace Recursivida.Logica
{
    public class Factorial
    {
        public int MiFactorial(int n)
        {
            //caso base
            if (n == 1) {
                return 1;
            }

            //caso general
            return n * MiFactorial(n - 1);
        }
    }
}