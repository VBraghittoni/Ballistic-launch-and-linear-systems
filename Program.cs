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
            bool Definido(string n)
            {
                if (n == null)
                {
                    return false;
                }
                return true;
            }

            int ContaIndefinidos(string[] array)
            {
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (!Definido(array[i]))
                    {
                        result++;
                    }
                }
                return result;
            }
            //teste
            Console.WriteLine("Alerta: mantenha suas unidades para você. Acharemos resultados nas unidades em que os valores inseridos estão.");
            Console.WriteLine("Digite 1 para circuitos elétricos ou 2 movimentos.");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {

            }
            if (option == 2)
            {
                Console.WriteLine("Digite 1 para M.R.U. ou 2 para M.R.U.V.");
                int option2 = Convert.ToInt32(Console.ReadLine());
                if (option2 == 1)
                {
                    Console.WriteLine("Hora de inserir as variáveis!");

                    string[] array = new string[4];

                    while (true)
                    {
                        Console.WriteLine("Qual variável deseja inserir? Digite: \n 1 - Posição inicial \n 2 - Posição final \n 3 - Velocidade \n 4 - Tempo decorrido \n 5 - Cansei de inserir variáveis! Me mostra os resultados!!");
                        int option3 = Convert.ToInt32(Console.ReadLine());
                        if (option3 == 5)
                        {

                            if (ContaIndefinidos(array) != 1)
                            {
                                Console.WriteLine("Não foi possível achar valores adicionais com as suas informações. Insira mais valores.");
                            }

                            float[] arrayNumeros = new float[array.Length];

                            for (int i = 0; i < array.Length; i++)
                            {
                                arrayNumeros[i] = Convert.ToInt32(array[i]);

                            }

                            if (!Definido(array[0]))
                            {
                                arrayNumeros[0] = arrayNumeros[1] - arrayNumeros[2]*arrayNumeros[3];
                                Console.WriteLine("A posição inicial é {0}", arrayNumeros[0]);
                            }

                            if (!Definido(array[1]))
                            {
                                arrayNumeros[1] = arrayNumeros[0] + arrayNumeros[2] * arrayNumeros[3];
                                Console.WriteLine("A posição final é {0}", arrayNumeros[1]);
                            }

                            if (!Definido(array[2]))
                            {
                                arrayNumeros[2] = (arrayNumeros[1] - arrayNumeros[0]) / arrayNumeros[3];
                                Console.WriteLine("A velocidade durante o movimento foi de {0}", arrayNumeros[2]);
                            }
                            if (!Definido(array[3]))
                            {
                                arrayNumeros[3] = (arrayNumeros[1] - arrayNumeros[0]) / arrayNumeros[2];
                                Console.WriteLine("A velocidade durante o movimento foi de {0}", arrayNumeros[3]);
                            }



                        }
                        Console.WriteLine("Digite o valor: ");
                        string valorRecebido = Console.ReadLine();
                        bool sucesso = float.TryParse(valorRecebido, out float numero);

                        if (sucesso)
                        {
                            switch (option3)
                            {
                                case 1:
                                    array[0] = valorRecebido;
                                    break;
                                case 2:
                                    array[1] = valorRecebido;
                                    break;
                                case 3:
                                    if (valorRecebido == "0")
                                    {
                                        Console.WriteLine("Erro! Sem velocidade, não há movimento!!");
                                        break;
                                    }
                                    else
                                    {
                                        array[2] = valorRecebido;
                                        break;
                                    }

                                case 4:
                                    if (valorRecebido == "0")
                                    {
                                        Console.WriteLine("Erro! Sem tempo, não há movimento!!");
                                        break;
                                    }
                                    else
                                    {
                                        array[3] = valorRecebido;
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("O que foi digitado não pode ser convertido para número. Use somente algarismos de 0 a 9.");
                        }

                    }
                }
                if (option2 == 2)
                {
                    Console.WriteLine("Hora de inserir as variáveis!");

                    string[] array = new string[4];

                    while (true)
                    {
                        Console.WriteLine("Qual variável deseja inserir? Digite: \n 1 - Posição inicial \n 2 - Posição final \n 3 - Velocidade média \n 4 - Velocidade inicial \n 5- Velocidade final \n 6 - Tempo decorrido \n 7 - Espaço percorrido \n 8 - Aceleração \n 9 - Cansei de inserir variáveis! Me mostra os resultados!!");
                        int option3 = Convert.ToInt32(Console.ReadLine());
                        if (option3 == 9)
                        {

                            if (ContaIndefinidos(array) != 1)
                            {
                                Console.WriteLine("Não foi possível achar valores adicionais com as suas informações. Insira mais valores.");
                            }

                            float[] arrayNumeros = new float[array.Length];

                            for (int i = 0; i < array.Length; i++)
                            {
                                arrayNumeros[i] = Convert.ToInt32(array[i]);

                            }

                            if (!Definido(array[0]))
                            {
                                arrayNumeros[0] = arrayNumeros[1] - arrayNumeros[2] * arrayNumeros[3];
                                Console.WriteLine("A posição inicial é {0}", arrayNumeros[0]);
                            }

                            if (!Definido(array[1]))
                            {
                                arrayNumeros[1] = arrayNumeros[0] + arrayNumeros[2] * arrayNumeros[3];
                                Console.WriteLine("A posição final é {0}", arrayNumeros[1]);
                            }

                            if (!Definido(array[2]))
                            {
                                arrayNumeros[2] = (arrayNumeros[1] - arrayNumeros[0]) / arrayNumeros[3];
                                Console.WriteLine("A velocidade durante o movimento foi de {0}", arrayNumeros[2]);
                            }
                            if (!Definido(array[3]))
                            {
                                arrayNumeros[3] = (arrayNumeros[1] - arrayNumeros[0]) / arrayNumeros[2];
                                Console.WriteLine("A velocidade durante o movimento foi de {0}", arrayNumeros[3]);
                            }



                        }
                        Console.WriteLine("Digite o valor: ");
                        string valorRecebido = Console.ReadLine();
                        bool sucesso = float.TryParse(valorRecebido, out float numero);

                        if (sucesso)
                        {
                            switch (option3)
                            {
                                case 1:
                                    array[0] = valorRecebido;
                                    break;
                                case 2:
                                    array[1] = valorRecebido;
                                    break;
                                case 3:
                                    if (valorRecebido == "0")
                                    {
                                        Console.WriteLine("Erro! Sem velocidade, não há movimento!!");
                                        break;
                                    }
                                    else
                                    {
                                        array[2] = valorRecebido;
                                        break;
                                    }

                                case 4:
                                    if (valorRecebido == "0")
                                    {
                                        Console.WriteLine("Erro! Sem tempo, não há movimento!!");
                                        break;
                                    }
                                    else
                                    {
                                        array[3] = valorRecebido;
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("O que foi digitado não pode ser convertido para número. Use somente algarismos de 0 a 9.");
                        }

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
