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
            string modelo;
            double km;
            double pot;
            string classVeic = "";
            string classPot = "" ;
            for(int i = 0; i < n; i++)
            {
                modelo = Console.ReadLine();
                km = double.Parse(Console.ReadLine());
                pot = double.Parse(Console.ReadLine());
            
                if (km <= 5000)
                {
                    classVeic = "Novo";
                }
                else if (km > 5000 && km <= 25000)
                {
                    classVeic = "Seminovo";
                }
                else
                {
                    classVeic = "Velho";
                }
                if (pot > 170)
                {
                    classPot = "Potente";
                }
                else if (pot >= 80 && pot <= 170)
                {
                    classPot = "Médio";
                }
                else
                {
                    classPot = "Popular";
                }
                Console.WriteLine("{0}-{1}-{2}\n", modelo, classVeic, classPot);
            }
        }
    }
}
