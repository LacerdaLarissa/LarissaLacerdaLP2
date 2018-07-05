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
            double km, pot;
            
             for (int i = 0; i < n; i++)
             {
                modelo= C.RL();
                km = double.Parse(C.RL());
                pot = double.Parse(C.RL());
                C.WL(Classificar(modelo, km, pot));
             }
        }
        static string Classificar(string modelo, double km, double pot)
        {
            string ClassVeic;
            string ClassPot;
            
            if (km <= 5000) 
            ClassVeic="Novo";
                
            else if (km > 5000 && km <= 25000)
            ClassVeic="Seminovo";
                
            else//km > 25000
            ClassVeic="Velho";
                
            if (pot < 80)
            ClassPot="Popular";
                    
            else if(pot >= 80 && pot < 170)
            ClassPot="Médio";
                
            else//pot > 170
            ClassPot="Potente";
          
            
            return string.Format("{0} - {1} - {2}", modelo, ClassVeic, ClassPot);
        }
    }
}
