using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Carro
    {
        static void Main(string[] args)
        {
          public double KmRodado;
          public double Potencia;
          public string Modelo;
          
          public static string Classificar (string ClassificTemp, string ClassificPot)
          {
            string Resultado= Modelo + ClassificTemp + ClassificPot;
            if(KmRodado>=5000)
             ClassificTemp="Novo";
          
            else if (KmRodado<5000 && KmRodado<=25000)
            ClassificTemp="Seminovo";
          
            else //(KmRodado>25000)
            ClassificTemp="Velho";
          
            if (Potencia<80)
            ClassificPot="Popular";
          
            else if(Potencia>=80 && Potencia<170)
           ClassificPot"Médio";
          
            else
            ClassificPot="Potente";
            
            Console.WriteLine("{0}", Resultado);
            return Resultado;
          }
        
        }
    }
}
