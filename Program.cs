using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuitos_e_movimentos
{
    internal class Program
    {


        static void Main(string[] args)
        {

    

            float[] formulaQuadratica(float a, float b, float c){
                float[] result = new int[2];
                result[0] = (-b+Math.Sqrt(b*b-4*a*c))/2*a
                result[1] = (-b-Math.Sqrt(b*b-4*a*c))/2*a
                return result;
            }

            Console.WriteLine("Alerta: mantenha suas unidades para você. Acharemos resultados nas unidades em que os valores inseridos estão.\n");
            Console.WriteLine("Digite 1 para circuitos elétricos ou 2 lançamento balístico.");
            int option = Convert.ToInt32(Console.ReadLine());
            
            if(option == 1)
            {

            }

            else
            {      
                float g = 9.8;

                while(true)
                {
                    Console.WriteLine("Digite o valor da distância horizontal (X): ");
                    try{
                       float x = Convert.ToSingle(Console.ReadLine());
                        if(x > 0){
                            break;
                        } else{
                            Console.WriteLine("O valor precisa ser maior que 0. Tente novamente.")
                        }
                    }catch{
                        Console.WriteLine("O valor não é um número. Tente novamente.")
                    }
                }

                while(true)
                {
                    Console.WriteLine("Digite o valor da distância vertical (H): ");
                    try{
                       float h = Convert.ToSingle(Console.ReadLine());
                        if(h > 0){
                            break;
                        } else{
                            Console.WriteLine("O valor precisa ser maior que 0. Tente novamente.")
                        }
                    }catch{
                        Console.WriteLine("O valor não é um número. Tente novamente.")
                    }
                } 
                if(g*x*x/2 > h)
                {
                    Console.WriteLine("O alvo será atingido quando o projétil estiver em movimento ascendente.");
                }

                if(g*x*x/2 == h)
                {
                    Console.WriteLine("O alvo será atingido quando o projétil estiver no pico de sua altura.");
                }

                if(g*x*x/2 < h)
                {
                    Console.WriteLine("O alvo será atingido quando o projétil estiver em movimento descendente.");
                }


                float boundRadianos = Math.Atan(j/x);
                float boundGraus = bound*180/Math.PI;
                float angulo;
                


                Console.WrieLine("Vamos inserir o valor do ângulo.\n Ele deve ser menor que (π/2) radianos = 90º e maior que {0} radianos = {1}º.", boundRadianos, boundGraus);

                Console.WriteLine("Digite 1 para digitar o ângulo em radianos e 2 para digitar o ângulo em graus;");
                int option = Convert.ToInt32(Console.ReadLine());

                while(true)
                {
                    if(option==1){
                        Console.WriteLine("Digite o ângulo em radianos: ");
                        float tentativa = Convert.ToSingle(Console.ReadLine());
                        if(boundRadianos<tentativa && tentativa<Math.PI){
                            angulo = tentativa;
                            break;
                        } else{
                            Console.WriteLine("Ângulo inválido. Tente novamente.")
                        }
                    }
                    else{
                        Console.WriteLine("Digite o ângulo em graus: ");
                        float tentativa = Convert.ToSingle(Console.ReadLine());
                        if(boundGraus<tentativa && tentativa<180){
                            angulo = Math.PI*tentativa/180;
                            break;
                        } else{
                            Console.WriteLine("Ângulo inválido. Tente novamente.")
                        }                        
                    }
                }

                float t = Math.Sqrt(((x*Math.Sin(angulo)/Math.Cos(angulo))-h)/4.9);

                float v0 = x/(Math.Cos(angulo)*t);       

                Console.WriteLine("A velocidade inicial necessária é {0}, e sua duração de tempo para acontecer é {1}", t, v0);

            }

            Console.ReadKey();
        }
    }
}
