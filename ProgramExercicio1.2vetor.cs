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
          int n = Console.ReadLine();
          Double [] qtd = new double [n];
          
          string [] modelo = New string [n];
          string  ClassVeic, ClassPot;
          double [] km = new double [n];
          double [] pot = new double [n];
          int i;
          
          for(i=0; i<N; i++)
          {
            modelo[i] = C.RL();
            km [i] = double.Parse(C.RL());
            pot [i] = double.Parse(C.RL());
              
            if(km[i] <= 5000)
+           ClassVeic="Novo";
+          
+           else if (km[i] > 5000 && km[i] <= 25000)
+           ClassVeic="Seminovo";
+          
+           else
+           ClassVeic="Velho";
+          
+           if (pot[i] < 80)
+           ClassPot="Popular";
+          
+           else if(pot[i] >= 80 && pot[i] < 170)
+           ClassPot"Médio";
+          
+           else
+           ClassPot="Potente";
          }
        
            Console.writeLine("{0 }- {1} - {2}",Modelo[i], ClassVeic, ClasscPot);
        }
    }
}
