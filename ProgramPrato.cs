using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComPOO();
        }
        static void ComPOO()
        {
             int n = int.Parse(Console.ReadLine());

            Prato[] pratos = new Prato[n];

            for (int i = 0; i < n; i++)
            {
                Prato p = new Prato();

                p.Nome = Console.ReadLine();
                p.Rendimento = double.Parse(Console.ReadLine());
                p.Custo = double.Parse(Console.ReadLine());

                pratos[i] = p;
            }

            Prato maisCaro = pratos[0];   // Referências
            Prato maiorRend = pratos[0];
            Prato melhorCB = pratos[0];

            for (int i = 1; i < n; i++)
            {
                if (pratos[i].Custo > maisCaro.Custo)
                    maisCaro = pratos[i];
                if (pratos[i].Rendimento > maiorRend.Rendimento)
                    maiorRend = pratos[i];
                if (pratos[i].CustoBenef() > melhorCB.CustoBenef())
                    melhorCB = pratos[i];
            }

            Console.WriteLine("Mais caro: {0}", maisCaro.Nome);
            Console.WriteLine("de maior rendimento: {0}", maiorRend.Nome);
            Console.WriteLine("de melhor custo x benefício: {0}", melhorCB.Nome);
        
        }
        static void SemPOO()
        {
            int i, Qtd;
            Console.WriteLine("Informe a quantidade de receitas");
            Qtd = int.Parse(Console.ReadLine());
            double MaisCara = 0, MaiorRend = 0, MelhorCB=200000;
            double[] Custo = new double[Qtd];
            double[] Rendimento = new double[Qtd];
            string[] Nome = new string[Qtd];
            string NomeMaiorRend= "", NomeMaisCara="", NomeMelhorCB="";


            for (i = 0; i < Qtd; i++)
            {
                Console.WriteLine("Informe o nome da receita");
                Nome[i] = Console.ReadLine();

                Console.WriteLine("Informe o Peso");
                Rendimento[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o custo");
                Custo[i] = double.Parse(Console.ReadLine());
            }

            for (i = 0; i < Qtd; i++)
            {
                if (Custo[i] > MaisCara)
                {
                    MaisCara = Custo[i];
                    NomeMaisCara = Nome[i];
                }

                if (Rendimento[i] > MaiorRend)
                {
                    MaiorRend = Rendimento[i];
                    NomeMaiorRend = Nome[i];
                }
                double CB = Rendimento[i] / Custo[i];
                if (CB > MelhorCB)
                {
                    MelhorCB = CB;
                    NomeMelhorCB = Nome[i];
                }
            }
            Console.WriteLine("A receita mais cara é {0}", NomeMaisCara);
            Console.WriteLine("A receita com maior rendimento é {0}", NomeMaiorRend);
            Console.WriteLine("A receita melhor custo benifício é {0}", NomeMelhorCB);

           
        }
    }
}
