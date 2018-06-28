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
                car.modelo = Console.ReadLine();
                car.km = double.Parse(Console.ReadLine());
                car.pot = double.Parse(Console.ReadLine());
                Console.WriteLine(Classificar(car));
            }
        }
        static string Classificar(Carro c)
        {
            string classVeic;
            string classPot;
            if (c.km <= 5000)
            {
                classVeic = "Novo";
            }
            else if (c.km > 5000 && c.km <= 25000)
            {
                classVeic = "Seminovo";
            }
            else
            {
                classVeic = "Velho";
            }
            if (c.pot > 170)
            {
                classPot = "Potente";
            }
            else if (c.pot >= 80 && c.pot <= 170)
            {
                classPot = "Médio";
            }
            else
            {
                classPot = "Popular";
            }
            return string.Format("{0}-{1}-{2}", c.modelo, classVeic, classPot);
        }
    }
}
