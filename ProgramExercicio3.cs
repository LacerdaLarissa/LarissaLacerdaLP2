using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Datas
    {
     class Data
    {
        public int dia;
        public int mes;
        public int ano;

        public bool validar()
        {
            if((mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && dia > 0 && dia <= 31)
            return true;
            
            else if((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 0 && dia <= 30)
            return true;
            
            else if(mes == 2 && dia > 0 && dia <= 28)
            return true;
            
            else
            return false;

        }

        public string emTexto()
        {
               if(validar())
               {
                   return string.Format("{0}/{1}/{2}", dia, mes, ano);
               }
               else
               {
                   return string.Format("Data inválida.");
               }
        } 

        public string porExtenso()
        {
                if(mes == 1)
                return string.Format("{0} de Janeiro de {1}", dia, ano);
                
                else if(mes == 2)
                return string.Format("{0} de Fevereiro de {1}", dia, ano);
            
                else if(mes == 3)
                return string.Format("{0} de Março de {1}", dia, ano);
                
                else if(mes == 4)
                return string.Format("{0} de Abril de {1}", dia, ano);
                
                else if(mes == 5)
                return string.Format("{0} de Maio de {1}", dia, ano);
                
                else if(mes == 6)
                return string.Format("{0} de Junho de {1}", dia, ano);
                
                else if(mes == 7)
                return string.Format("{0} de Julho de {1}", dia, ano);
                
                else if(mes == 8)
                return string.Format("{0} de Agosto de {1}", dia, ano);
                
                else if(mes == 9)
                return string.Format("{0} de Setembro de {1}", dia, ano);
                
                else if(mes == 10)
                return string.Format("{0} de Outubro de {1}", dia, ano);
                
                else if(mes == 11)
                return string.Format("{0} de Novembro de {1}", dia, ano);
                                         
                else
                return string.Format("{0} de Dezembro de {1}", dia, ano);
                
        }

        public void diaSeguinte()
        {
                if(mes == 12 && dia == 31)
                {
                    dia = 1;
                    mes = 1;
                    ano += 1;
                }
                else if(mes == 2 && dia == 28)
                {
                    dia = 1;
                    mes += 1;
                }
                else if(dia == 31)
                {
                    dia = 1;
                    mes += 1;
                }
                else if((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia == 30)
                {
                    dia = 1;
                    mes += 1;
                }
                else
                {
                    dia += 1;
                }
        } 

        public void diaAnterior()
        {
                if(mes == 1 && dia == 1)
                {
                    dia = 31;
                    mes = 12;
                    ano -= 1;
                }
                else if((mes == 5 || mes == 7 || mes == 10 || mes == 12) && dia == 1)
                {
                    dia = 30;
                    mes -= 1;
                }
                else if((mes == 2 || mes == 4 || mes == 6 || mes == 8 || mes == 9 || mes == 11) && dia == 1)
                {
                    dia = 31;
                    mes -= 1;
                }
                else if(mes == 3 && dia == 1)
                {
                    dia = 28;
                    mes -= 1;
                }
                else
                {
                    dia -= 1;
                }
         }
    }


 Data day = new Data();

            C.WL("Insira uma data completa.");
            day.dia = int.Parse(C.RL());
            day.mes = int.Parse(C.RL());
            day.ano = int.Parse(C.RL());
            C.WL(day.emTexto());
            C.WL(day.diaAnterior());
            
            C.WL("Deseja avançar ou retornar alguma data?");
            opcao = C.RL();
        
            if (opcao == "avancar")
            {
                day.diaSeguinte();
            }
            else
            {
                day.diaAnterior();
            }
    }
}
