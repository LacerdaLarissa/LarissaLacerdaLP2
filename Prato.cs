using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Prato
    {
        public string Nome;
        public double Custo;
        public double Rendimento;

        public double CustoBenef()
        {
            double CustoBenef = Rendimento/Custo;
            return CustoBenef;
        }
    }
}
