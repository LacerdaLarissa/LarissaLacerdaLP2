﻿using System;
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

            Console.Write("Dê-me um valor de raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = AreaDoCirculo(raio);
            Console.WriteLine("Área: {0}", area);

            double vol = VolumeDaEsfera(raio);
            Console.WriteLine("Volume: {0}", vol);


            Console.Write("Dê-me o lado de um quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double areaQ = AreaQuadrado(lado);
            Console.WriteLine("Área do quadrado: {0}", areaQ);

            double periQ = PerimetroQuadrado(lado);
            Console.WriteLine("Perimetro do quadrado: {0}", periQ);

            Console.Write("base e Altura do triângulo: ");
            double B = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine("Área do triangulo: {0}", AreaTriang(B, H));

        }

        static double AreaDoCirculo (double raio)
        {
            double result;
            result = Math.PI * (raio * raio);
            return result;
        }

        static double VolumeDaEsfera (double raio)
        {
            double volu;
            volu = (4/3 * Math.PI) * Math.Pow(raio,3);
            return volu;
        }

        static double AreaQuadrado (double lado)
        {
            double area= lado * lado;
            return area;
        }

        static double PerimetroQuadrado (double lado)
        {
            double peri = lado * 4;
            return peri;
        }

        static double AreaTriang(double H, double B)
        {
            return  (B * H) / 2;
            
        }
        
       

    }
}
