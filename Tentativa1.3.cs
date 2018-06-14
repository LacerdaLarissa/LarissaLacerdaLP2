using System;
using System.Collections.Generic;
using System.Linq
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          int N= int.Parse(Console.ReadLine());
          Carro c= new Carro();

          for (i=0; i<N; i++)
          {
            c.Modelo = Console.ReadLine();
            c.Potencia= double.Parse(Console.ReadLine());
            cKmRodado= double.Parse(Console.ReadLine());
          }
           Console.WriteLine("{0}\N", c.Classificar());
        }
    }
}
