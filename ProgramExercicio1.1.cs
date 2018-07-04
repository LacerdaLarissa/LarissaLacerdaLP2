using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Veiculo
    {
        static void Main(string[] args)
        {
          string modelo, ClassVeic= "", ClassPot= "";
          double km, pot;
          
          modelo=C.RL();
          km = double.Parse(C.RL());
          pot = double.Parse(C.RL());
          
          if (km <= 5000)
          ClassVeic="Novo";
          
          else if (km > 5000 && km <= 25000)
          ClassVeic="Seminovo";
          
          else //(km > 25000)
          ClassVeic="Velho";
          
          if (pot < 80)
          ClassPot="Popular";
          
          else if(pot >= 80 && pot < 170)
          ClassPot="Médio";
          
          else//km > 170
          ClassPot="Potente";
          
          Console.WriteLine("{0} - {1} - {2}", modelo, ClassVeic, ClassPot);
        
        }
    }
}
