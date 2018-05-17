using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args) // static, jo mēs no šīs klases netaisam objektu
        {
            //Objektu izveido, lai piekļūtu klasei un funkcijai
            Test TestaObjekts = new Test();
            int rezultats = TestaObjekts.Saskaitisana(3,7);

            Console.WriteLine("Izvade no klases: " + rezultats);

            Test TestaObjekts2 = new Test(); // šis jau ir cits objekts

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;
            Console.WriteLine("Izvade no TestaObjekts: " + TestaObjekts.skaitlis);
            Console.WriteLine("Izvade no TestaObjekts2: " + TestaObjekts2.skaitlis);

            Console.Read();
        }
    }
}
