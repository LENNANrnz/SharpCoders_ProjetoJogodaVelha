using System;

namespace JogoDaVelha
{


    public class Program
    {
        static void IniciarJogo(List<string> NomeJogador, int contadorpl1, int contadorpl2, int contadoDeEmpate)
        {
            string[] jogo = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            string valorMarcado;

            bool player1win = false;
            bool player2win = false;
            bool empate = false;
            int contplayer1 = 0;
            int contplayer2 = 0;
            int contempate = 0;

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
                        player1win = true;

                        break;
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine($"o ganhador é {NomeJogador[1]}");
                        player2win = true;
                        break;
                    }

                }
                else if (i == 9)
                {
                    Console.WriteLine("EMPATE");
                    empate = true;
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

            //Mostrar tabela

            if (player1win == true)
            {
                contplayer1 = 1;
                contadorpl1 += contplayer1;
            }
            else if (player2win == true)
            {
                contplayer2 = 1;
                contadorpl2 += contplayer2;
            }
            else if (empate == true)
            {
                contempate = 1;

                contadoDeEmpate += contempate;


            }

           // Console.WriteLine($"empate {contadoDeEmpate} player 1 {contadorpl1} player 2 {contadorpl2}");

            MenuFinal(NomeJogador, contadorpl1,  contadorpl2,  contadoDeEmpate);


        }

        static void MenuFinal(List<string> NomeJogador, int contadorpl1, int contadorpl2, int contadoDeEmpate)
        {

            int opcaoDesejada;
            do
            {
                Console.WriteLine("1 - Jogar novamente");

                Console.WriteLine("2 - Mostrar Tabela");

                Console.WriteLine("9 - Resetar");

                Console.WriteLine("0 - Sair do jogo");

                opcaoDesejada = int.Parse(Console.ReadLine());

                switch (opcaoDesejada)
                {
                    case 1:
                        IniciarJogo(NomeJogador, contadorpl1, contadorpl2, contadoDeEmpate);
                        break;

                    case 2: MostrarTabela(NomeJogador, contadorpl1, contadorpl2, contadoDeEmpate);
                        break;

                    case 9:
                        Console.Clear();
                        Main();
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


        static void MostrarTabela(List<string> NomeJogador, int contadorpl1, int contadorpl2, int contadoDeEmpate)
        {
            Console.WriteLine($"{NomeJogador[0]} = {contadorpl1} Vitórias");
            Console.WriteLine($"{NomeJogador[1]} = {contadorpl2} Vitórias");
            Console.WriteLine($"{contadoDeEmpate} Empates");

        }
        public static void Main()
        {
            List<string> NomeJogador = new List<string>();

            int contadorpl1 = 0;
            int contadorpl2 = 0;
            int contadoDeEmpate = 0;


            RegistrarJogador(NomeJogador);

            IniciarJogo(NomeJogador, contadorpl1, contadorpl2, contadoDeEmpate);
        }
    }
}