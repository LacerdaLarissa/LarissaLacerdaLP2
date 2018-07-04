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
             for (int i = 0; i < n; i++)
             {
                C.WL(Classificar(car));
             }
        }
        static string Classificar(Carro c)
        {
            string ClassVeic;
            string ClassPot;
            
            if (c.km <= 5000) 
            ClassVeic = "Novo";
                
            else if (c.km > 5000 && c.km <= 25000)
            ClassVeic = "Seminovo";
                
            else//c.km > 25000
            ClassVeic = "Velho";
                
            if (c.pot < 80)
            ClassPot = "Popular";
                    
            else if(c.pot >= 80 && c.pot < 170)
            ClassPot="Médio";
                
            else//c.pot > 170
            ClassPot="Potente";
          
            
            return string.Format("{0} - {1} - {2}", c.modelo, ClassVeic, ClassPot);
        }
    }
}
