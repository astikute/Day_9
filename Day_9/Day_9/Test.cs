using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9 //šeit static neparādās!
    //namespace jābūt vienādiem
{
    class Test
    {
        //public (piekļūst ārpus Test faila) un private (izmanto tikai klasē Test)
        public int skaitlis; //mainīgais

        public int Saskaitisana(int a, int b)
        {
            Izvade();
            return a + b;
        }

        private void Izvade()
        {
            Console.WriteLine("tests!");
        }
    }
}
