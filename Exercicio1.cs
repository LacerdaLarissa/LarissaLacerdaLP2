using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
          string Modelo, Resultado, ClassificTenp, ClassificPot;
          double KmRodado, Potencia;
          
          Modelo=C.RL();
          KmRodado= double.Parse(C.RL());
          Potencia=double.Parse(C.RL());
          
          if(KmRodado>=5000)
          ClassificTemp="Novo";
          
          else if (KmRodado<5000 & KmRodado>=25000)
          ClassificTemp="Seminovo";
          
          else //(KmRodado<25000)
          ClassificTemp="Velho";
          
          if (Potencia>80)
          ClassificPot="Popular";
          
          else if(Potencia<=80 & Potencia>170)
          ClassificPot"Médio";
          
          else
          ClassificPot="Potente";
          
          Console.WriteLine("{0} - {1} - {2}", Modelo, ClassificTemp, ClassificPot);
        
        }
    }
}
