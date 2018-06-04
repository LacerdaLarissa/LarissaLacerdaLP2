using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cachorro c1 = new Cachorro();

            c1.dono = "Larissa";
            c1.nome = "Billy";
            c1.raça = "vira-lata";
            c1.brinquedo = "ladrão";
            c1.sexo = 'M';
            c1.peso = 8.000 ;
            c1.pedigree = false;

            Console.WriteLine("O cachorro {0} está brincando com um(a) {1}", c1.nome, c1.brinquedo);


        }
    }
}
