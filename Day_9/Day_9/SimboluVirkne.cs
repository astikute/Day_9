using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class SimboluVirkne
    {
        private string SimVirkne;

        public string Get()
        {
            return SimVirkne;
        }

        public void Set(string virkne1, string virkne2, string virkne3)
        {
            SimVirkne = virkne1 + virkne2 + virkne3;
        }

        public string SavienotVirkni(string virkne1, string virkne2, string virkne3)
        {
            return virkne1 + virkne2 + virkne3;
        }
    }
}
