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

        private int Privatais1;
        
        //Labāk katram mainīgajam savu Get un Set
        public int Get () //piekļūt mainīgajam (privat) izmanto funkciju (to parasti nosauc ar Get)
        {
            return Privatais1;
        }

        public void Set (int value) //piekļūt mainīgajam (privat) un piešķirt vērtību izmanto funkciju (to parasti nosauc ar Set)
        {
            if (value != 0)
            {
                Privatais1 = value;
            }
            else
            {
                Privatais1 = 1;
            }
        }

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
