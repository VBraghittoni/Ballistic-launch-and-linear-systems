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

            Console.WriteLine("Alerta: mantenha suas unidades para você. Acharemos resultados nas unidades em que os valores inseridos estão.");
            Console.WriteLine("Digite 1 para circuitos elétricos ou 2 lançamento balístico.");
            string option = Console.ReadLine();
            double x = 0;
            double h = 0;

            //Elétrica:
            if (option == "1")
            {

            }

            //Física:
            else
            {
                double g = 9.8;

                while (true)
                {
                    Console.WriteLine("Digite o valor da distância horizontal (X): ");
                    try
                    {
                        x = Convert.ToSingle(Console.ReadLine());
                        if (x > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("O valor precisa ser maior que 0. Tente novamente.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("O valor não é um número. Tente novamente.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Digite o valor da distância vertical (H): ");
                    try
                    {
                        h = Convert.ToSingle(Console.ReadLine());
                        if (h > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("O valor precisa ser maior que 0. Tente novamente.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("O valor não é um número. Tente novamente.");
                    }
                }

                double boundRadianos = Math.Atan(h / x);
                double boundGraus = (boundRadianos * 180) / Math.PI;
                double angulo;
                Console.WriteLine($"Baseando-se nas distâncias passadas, sabemos que o valor do ângulo deve ser \nmenor que (π/2) radianos = 90° \nmaior que: {boundRadianos} OU radianos = {boundGraus}°.");

                Console.WriteLine("Digite 1 para digitar o ângulo em radianos e 2 para digitar o ângulo em graus: ");
                string option1 = Console.ReadLine();

                while (true)
                {
                    if (option1 == "1")
                    {
                        Console.WriteLine("Digite o ângulo em radianos: ");
                        double tentativa = Convert.ToSingle(Console.ReadLine());
                        if (boundRadianos < tentativa && tentativa < Math.PI)
                        {
                            angulo = tentativa;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ângulo inválido. Tente novamente.");
                        }
                    }
                    else if (option1 == "2")
                    {
                        Console.WriteLine("Digite o ângulo em graus: ");
                        double tentativa = Convert.ToSingle(Console.ReadLine());
                        if (boundGraus < tentativa && tentativa < 180)
                        {
                            angulo = Math.PI * tentativa / 180;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ângulo inválido. Tente novamente.");
                        }
                    }
                    else
                    {

                    }
                }

                double t = Math.Sqrt(((x * Math.Sin(angulo) / Math.Cos(angulo)) - h) / 4.9);

                double v0 = x / (Math.Cos(angulo) * t);

                Console.WriteLine("A velocidade inicial necessária é {0} e sua duração de tempo para acontecer é {1}\n\nA equação que ilustra esse movimento é y = x*({2}) + x^2*({3})", t, v0, (Math.Sin(angulo) / Math.Cos(angulo)), (-g / (2 * v0 * v0 * Math.Cos(angulo) * Math.Cos(angulo))));

                double v0y = v0 * Math.Sin(angulo);



                if ((v0y - g * t) > 0)
                {
                    Console.WriteLine("Considerando tal velocidade, o projétil estará subindo quando acertar o alvo");
                }
                if ((v0y - g * t) == 0)
                {
                    Console.WriteLine("Considerando tal velocidade, o projétil estará em pico quando acertar o alvo");
                }
                if ((v0y - g * t) < 0)
                {
                    Console.WriteLine("Considerando tal velocidade, o projétil estará caindo quando acertar o alvo");
                }
            }

            Console.ReadKey();
        }
    }
}
