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
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Carro car = new Carro();
                car.modelo = C.RL();
                car.km = double.Parse(C.RL());
                car.pot = double.Parse(C.RL());
                C.WL(Classificar(car));
            }
        }
        static string Classificar(Carro c)
        {
            string ClassVeic;
            string ClassPot;
            
            if (c.km <= 5000) 
            ClassVeic= "Novo";
                
            else if (c.km > 5000 && c.km <= 25000)
            ClassVeic="Seminovo";
                
            else//km > 25000
            ClassVeic="Velho";
                
            if (c.pot < 80)
            ClassPot="Popular";
                    
            else if(c.pot >= 80 && c.pot < 170)
            ClassPot="Médio";
                
            else//pot > 170
            ClassPot="Potente";
          
            
            return string.Format("{0} - {1} - {2}", c.modelo, ClassVeic, ClassPot);
        }
    }
}
