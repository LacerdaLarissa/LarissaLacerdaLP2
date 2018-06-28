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
          int N=Console.ReadLine();
          Double [] qtd = new double [N];
          
          string [] Modelo = New string [N];
          string Resultado, ClassificTemp, ClassificPot;
          double [] KmRodado= new double [N];
          double [] Potencia= new double [N];
          int i;
          
          for(i=0; i<N; i++)
          {
            Modelo[i]=Console.ReadLine();
            KmRodado [i]= double.Parse(C.RL());
            Potencia [i]= double.Parse(C.RL());
            if(KmRodado[i]<=5000)
+           ClassificTemp="Novo";
+          
+           else if (KmRodado[i]>5000 && KmRodado[i]<=25000)
+           ClassificTemp="Seminovo";
+          
+           else //(KmRodado[i]>25000)
+           ClassificTemp="Velho";
+          
+           if (Potencia[i]<80)
+           ClassificPot="Popular";
+          
+           else if(Potencia[i]>=80 && Potencia<170)
+           ClassificPot"Médio";
+          
+           else
+           ClassificPot="Potente";
          }
        
            Console.writeLine("{0}-{1}-{2}",Modelo[i], ClassificTemp, ClassificPot);
        }
    }
}
