using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Elevadores
    {
        public int AndarAtual;
        public int TotalAndares;
        public int AndarDesejado;
        public int Capacidade;
        public int PessoasPresentes;
        
        //if(Cacidade<PessoasPresentes)
        //C.W("Sai");
        
        //else if(Capacidade>PessoasPresentes)
        //C.W("Entra");


        public string Entra( int X )
        {
            int X= Capacidade-PessoasPresentes;
            return int X;
        }
        
        public string Sai( int Y )
        {
            int Y= PessoasPresentes-Capacidade;
            return int Y;
        }
        
        public string Vai ( )
        {
            //subir= AndarDeejado-AndarAtual;
            //descer= AndarAtual-AndarDesejado;
            return Vai;
        }
        
        public string Emergencia( )
        {
            Console.Write("Ligue para o Corpo de Bombeiros (193)");
            Console.Beep;
            Console.Beep;
            Console.Beep;
            return Emergencia;
        }
    }
}
