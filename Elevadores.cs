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
        public int Capacidade;
        public int PessoasPresentes;
                
        public void Entra( int X )
        {
            if (Capacidade>=PessoasPresentes+X);
            PessoasPresentes= PessoasPresentes + X;
        }
        
        public void Sai( int X )
        {
            if (PessoasPresentes+X>=Capacidade);
            PessoasPresentes= PessoasPresentes - X;
        }
        
        public void Vai ( int AndarDesejado )
        {   
            
            if (AndarDesejado>=0 && AndarDesejado<=TotalAndares)
            AndarAtual= AndarDesejado;
            //subir= AndarDesejado-AndarAtual;
            //descer= AndarAtual-AndarDesejado;
            
        }
        
        public void Emergencia( )
        {
            Console.Write("Ligando para o Corpo de Bombeiros (193)");
            Console.Beep();
            Console.Beep();
            Console.Beep();
        }
    }
}
