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
            Carro[] car = new Carro[n];
            for(int i = 0; i < n; i++)
            {
                car[i] = new Carro();
                car[i].modelo = Console.RL();
                car[i].km = double.Parse(C.RL());
                car[i].pot = double.Parse(C.RL());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Classificar(car[i]));
            }
        }
        static string Classificar(Carro a)
        {
            string ClassVeic;
            string ClassPot;
            
            if (a.km <= 5000) 
            ClassVeic="Novo";
                
            else if (a.km > 5000 && a.km <= 25000)
            ClassVeic="Seminovo";
                
            else//km > 25000
            ClassVeic="Velho";
                
            if (a.pot < 80)
            ClassPot="Popular";
                    
            else if(a.pot >= 80 && a.pot < 170)
            ClassPot="Médio";
                
            else//pot > 170
            ClassPot="Potente";
            
            return string.Format("{0} - {1} - {2}", a.modelo, ClassVeic, ClassPot);
        }
    }
}
