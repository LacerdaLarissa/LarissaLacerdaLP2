using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Robo jose = new Robo();
            jose.x = 400;
            jose.y = 400;

            ConsoleKey tecla;

            do
            {
                Console.WriteLine("José está em [{0}{1}]", jose.x, jose.y);

                tecla = Console.ReadKey().Key;
                if (tecla == ConsoleKey.UpArrow)
                {
                    jose.y--;
                    if (jose.y < 0)
                        jose.y = 800;
                }
                if (tecla == ConsoleKey.DownArrow)
                {
                    jose.y++;
                    if (jose.y > 800)
                        jose.y = 0;
                }
                if (tecla == ConsoleKey.LeftArrow)
                {
                    jose.x--;
                    if (jose.x < 0)
                        jose.x = 800;
                }
                if (tecla == ConsoleKey.RightArrow)
                {
                    jose.x++;
                    if (jose.x > 800)
                        jose.x = 0;
                }

            } while (tecla != ConsoleKey.Escape);
        Console.WriteLine("Terminou...");
        }
    }
}
