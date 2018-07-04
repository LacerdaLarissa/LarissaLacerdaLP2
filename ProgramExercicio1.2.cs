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
            int n = int.Parse(C.RL());
            string modelo, ClassVeic= "", ClassPot= "";
            double km, pot;
             
            for(int i = 0; i < n; i++)
            {
                modelo = C.RL();
                km = double.Parse(C.RL());
                pot = double.Parse(C.RL());
            
                if (km <= 5000) 
                ClassVeic = "Novo";
                
                else if (km > 5000 && km <= 25000)
                ClassVeic = "Seminovo";
                
                else
                ClassVeic = "Velho";
                
                if (pot < 80)
                ClassPot = "Popular
                    
                else if(pot >= 80 && pot < 170)
                ClassPot="Médio";
                
                else//km > 170
                ClassPot="Potente";
          
                
                Console.WriteLine("{0}-{1}-{2}\n", modelo, ClassVeic, ClassPot);
            }
        }
    }
}
