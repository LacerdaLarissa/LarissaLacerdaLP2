using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno ();

            Console.WriteLine("nome: ");
            al.nome = Console.ReadLine();

            Console.WriteLine("Ano Nascimento: ");
            al.anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Telefone: ");
            al.tel = Console.ReadLine();

            Console.WriteLine("Nota 1 cert: ");
            al.nota1C = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2 cert: ");
            al.nota2C = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3 cert: ");
            al.nota3C = double.Parse(Console.ReadLine());


            Aluno al2 = new Aluno();

            Console.WriteLine("nome: ");
            al2.nome = Console.ReadLine();

            Console.WriteLine("Ano Nascimento: ");
            al2.anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Telefone: ");
            al2.tel = Console.ReadLine();

            Console.WriteLine("Nota 1 cert: ");
            al2.nota1C = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2 cert: ");
            al2.nota2C = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3 cert: ");
            al2.nota3C = double.Parse(Console.ReadLine());

        }
    }
}
