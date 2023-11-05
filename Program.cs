using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLinearELancamentoBalistico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Alerta: mantenha suas unidades para você. Acharemos resultados nas unidades em que os valores inseridos estão.\n\n");
            Console.WriteLine("Digite 1 para resolvermos sistemas lineares ou 2 para lançamento balístico.");
            string opcao1 = Console.ReadLine();


            //Elétrica:
            if (opcao1 == "1")
            {

                Console.WriteLine("Resolução de sistemas de equações lineares para multimalhas em elétrica");
                
                Console.Write("Quantas equações você deseja inserir? ");
                int numEquacoes = int.Parse(Console.ReadLine());

                Console.WriteLine("Aviso: o coeficiente de formato Akk (linha = coluna) precisará ser diferente de 0. \nPortanto, a enésima equação não deverá ter seu enésimo coeficiente sendo nulo.\n Insira as suas equações em uma ordem que satisfaça essa exigência.");

                Console.WriteLine("Coloque suas equações no formato:\n A11.x + A12.y = A13\n A21.x + A22.y = A23");
                
                double[,] sistema = new double[numEquacoes, numEquacoes + 1];

                for (int i = 0; i < numEquacoes; i++)
                {
                    for (int j = 0; j < numEquacoes + 1; j++)
                    {
                        Console.Write($"Insira o valor do coeficiente A[{i + 1}{j + 1}]: ");
                        sistema[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                // Resolvendo o sistema de equações usando eliminação de Gauss
                for (int i = 0; i < numEquacoes; i++)
                {
                    double pivo = sistema[i, i];
                    if (pivo == 0)
                    {
                        Console.WriteLine("O pivô não pode ser zero.\n Uma das duas situações ocorreu: \n1- Algum coeficiente no formato Akk foi colocado como 0 \n2-Suas equações tinham informações redundantes \nO programa irá encerrar.");
                        Console.ReadKey();
                        return;
                    }

                    for (int j = i; j < numEquacoes + 1; j++)
                    {
                        sistema[i, j] /= pivo;
                    }

                    for (int k = 0; k < numEquacoes; k++)
                    {
                        if (k != i)
                        {
                            double fator = sistema[k, i];
                            for (int j = i; j < numEquacoes + 1; j++)
                            {
                                sistema[k, j] -= fator * sistema[i, j];
                            }
                        }
                    }
                }

                // Exibir as soluções
                Console.WriteLine("\nSolução:");
                for (int i = 0; i < numEquacoes; i++)
                {
                    Console.WriteLine($"A[{i + 1}] = {sistema[i, numEquacoes]:F4}");
                }

            }

            //Física:
            else
            {

                double x = 0;
                double h = 0;
                double g = 9.8;

                while (true)
                {
                    Console.WriteLine("Digite o valor da distância horizontal do alvo (X): ");
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
                    Console.WriteLine("Digite o valor da distância vertical do alvo (H): ");
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

                double minRadianos = Math.Atan(h / x);
                double minGraus = (minRadianos * 180) / Math.PI;
                double anguloRadianos;
                Console.WriteLine($"Baseando-se nas distâncias passadas, sabemos que o valor do ângulo deve ser \nmenor que (π/2) radianos = 90° \nmaior que: {minRadianos} OU radianos = {minGraus}°.");

                Console.WriteLine("Digite 1 para digitar o ângulo em radianos e 2 para digitar o ângulo em graus: ");
                string opcao2 = Console.ReadLine();

                while (true)
                {
                    if (opcao2 == "1")
                    {
                        Console.WriteLine("Digite o ângulo em radianos: ");
                        double tentativa = Convert.ToSingle(Console.ReadLine());
                        if (minRadianos < tentativa && tentativa < (Math.PI/2))
                        {
                            anguloRadianos = tentativa;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ângulo inválido. Tente novamente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Digite o ângulo em graus: ");
                        double tentativa = Convert.ToSingle(Console.ReadLine());
                        if (minGraus < tentativa && tentativa < 180)
                        {
                            anguloRadianos = Math.PI * tentativa / 180;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ângulo inválido. Tente novamente.");
                        }
                    }
                }

                double t = Math.Sqrt(((x * Math.Sin(anguloRadianos) / Math.Cos(anguloRadianos)) - h) / (g/2));

                double v0 = x / (Math.Cos(anguloRadianos) * t);

                Console.WriteLine("A velocidade inicial necessária é {0} e sua duração de tempo para acontecer é {1}\n\nA equação que ilustra esse movimento é y = x*({2}) + x^2*({3})", t, v0, (Math.Sin(anguloRadianos) / Math.Cos(anguloRadianos)), (-g / (2 * v0 * v0 * Math.Cos(anguloRadianos) * Math.Cos(anguloRadianos))));

                double v0y = v0 * Math.Sin(anguloRadianos);



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
