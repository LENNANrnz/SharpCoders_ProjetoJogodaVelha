using System;

namespace JogoDaVelha
{


    public class Program
    {
        static void IniciarJogo(List<string> NomeJogador)
        {
            string[] jogo = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            string valorMarcado;

            for (int i = 0; i <= 9; i++)
            {
                Console.Clear();
                Console.Write(
                       $"__{jogo[0]}__|__{jogo[1]}__|__{jogo[2]}__\n" +
                       $"__{jogo[3]}__|__{jogo[4]}__|__{jogo[5]}__\n" +
                       $"  {jogo[6]}  |  {jogo[7]}  |  {jogo[8]}  \n\n");

                if (jogo[0] == jogo[1] && jogo[0] == jogo[2] || jogo[3] == jogo[4] && jogo[3] == jogo[5] ||
                    jogo[6] == jogo[7] && jogo[6] == jogo[8] || jogo[0] == jogo[3] && jogo[0] == jogo[6] ||
                    jogo[1] == jogo[4] && jogo[1] == jogo[7] || jogo[2] == jogo[5] && jogo[2] == jogo[8] ||
                    jogo[2] == jogo[4] && jogo[2] == jogo[6] || jogo[0] == jogo[4] && jogo[0] == jogo[8]
                    )
                {

                    //Mostra o se houve guanhador ou empate

                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"o ganhador é {NomeJogador[0]}");
                        break;
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine($"o ganhador é {NomeJogador[1]}");
                        break;
                    }

                }
                else if (i == 9)
                {
                    Console.WriteLine("EMPATE");
                    break;
                }

                //mostra a vez da pessoa

                if (i % 2 == 0)
                {
                    Console.Write($"Sua vez {NomeJogador[0]},digite o numero que deseja marcar o X: ");
                    valorMarcado = Console.ReadLine();

                    while (valorMarcado != "0" && valorMarcado != "1" && valorMarcado != "2" && valorMarcado != "3" && valorMarcado != "4"
                    && valorMarcado != "5" && valorMarcado != "6" && valorMarcado != "7" && valorMarcado != "8")
                    {
                        Console.Write("Valor inválido, digite novamente um número válido :");
                        valorMarcado = Console.ReadLine();

                    };

                    int j = int.Parse(valorMarcado);

                    //mostra quando quadrado ja está selecinado

                    if (jogo[j] == "X")
                    {
                        while (jogo[j] == "X")
                        {
                            Console.Write("Quadrado já selecionado, digite um quadrado disponível: ");
                            valorMarcado = Console.ReadLine();
                            j = int.Parse(valorMarcado);
                        }
                    }

                    if (jogo[j] == "O")
                    {
                        while (jogo[j] == "O")
                        {

                            Console.Write("Quadrado já selecionado, digite um quadrado disponível: ");
                            valorMarcado = Console.ReadLine();
                            j = int.Parse(valorMarcado);

                        };
                        jogo[j] = "X";
                    }
                    else
                    {
                        jogo[j] = "X";
                    }


                }

                //mostra a vez da pessoa

                else if (i % 2 != 0)
                {
                    Console.Write($"Sua vez {NomeJogador[1]},digite o numero que deseja marcar o O: ");
                    valorMarcado = Console.ReadLine();
                    while (valorMarcado != "0" && valorMarcado != "1" && valorMarcado != "2" && valorMarcado != "3" && valorMarcado != "4"
                  && valorMarcado != "5" && valorMarcado != "6" && valorMarcado != "7" && valorMarcado != "8")
                    {
                        Console.Write("Valor inválido, digite novamente um número válido :");
                        valorMarcado = Console.ReadLine();
                    };
                    int j = int.Parse(valorMarcado);

                    //mostra quando quadrado ja está selecinado

                    if (jogo[j] == "O")
                    {
                        while (jogo[j] == "O")
                        {
                            Console.Write("Quadrado já selecionado, digite um quadrado disponível: ");
                            valorMarcado = Console.ReadLine();
                            j = int.Parse(valorMarcado);
                        }
                    }

                    if (jogo[j] == "X")
                    {
                        while (jogo[j] == "X")
                        {

                            Console.WriteLine("Quadrado já selecionado, digite um quadrado disponível: ");
                            valorMarcado = Console.ReadLine();
                            j = int.Parse(valorMarcado);

                        };
                        jogo[j] = "O";
                    }
                    else
                    {
                        jogo[j] = "O";
                    }
                }
            }
            Console.WriteLine();

            MenuFinal(NomeJogador);


        }

        static void MenuFinal(List<string> NomeJogador)
        {

            int opcaoDesejada;
            do
            {
                Console.WriteLine("1 - Jogar novamente");

                Console.WriteLine("0 - Sair do jogo");

                opcaoDesejada = int.Parse(Console.ReadLine());

                switch (opcaoDesejada)
                {
                    case 1:
                        IniciarJogo(NomeJogador);
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do jogo...");
                        break;
                }
            } while (opcaoDesejada != 0 && opcaoDesejada != 1);


        }
        //Registra nome de jogador 

        static void RegistrarJogador(List<string> NomeJogador)
        {
            Console.WriteLine("Digite o nome do jogador 1: ");
            NomeJogador.Add(Console.ReadLine());

            Console.WriteLine("Digite o nome do jogador 2: ");
            NomeJogador.Add(Console.ReadLine());

        }
        public static void Main()
        {
            List<string> NomeJogador = new List<string>();


            RegistrarJogador(NomeJogador);

            IniciarJogo(NomeJogador);
        }
    }
}