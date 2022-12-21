using System;

namespace JogoDaVelha
{


    public class Program
    {
        static void IniciarJogo(List<string> NomeJogador)
        {
            int contadorplayer1 = 0;
            int contadorplayer2 = 0;
            int contadorEmpate = 0;

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

                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"o ganhador é {NomeJogador[0]}");
                        contadorplayer1= +1;
                        break;
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine($"o ganhador é {NomeJogador[1]}");
                        contadorplayer2 = +1;
                        break;
                    }

                }
                else if (i == 9)
                {
                    Console.WriteLine("EMPATE");
                    contadorEmpate = +1;
                    break;

                }

                if (i % 2 == 0)
                {
                    Console.Write($"Sua vez {NomeJogador[0]},Digite o numero que deseja marcar o X: ");
                    valorMarcado = Console.ReadLine();

                    while (valorMarcado != "0" && valorMarcado != "1" && valorMarcado != "2" && valorMarcado != "3" && valorMarcado != "4"
                    && valorMarcado != "5" && valorMarcado != "6" && valorMarcado != "7" && valorMarcado != "8")
                    {
                        Console.Write("Valor inválido, digite novamente um número válido :");
                        valorMarcado = Console.ReadLine();
                    };
                    int j = int.Parse(valorMarcado);
                    jogo[j] = "X";

                }
                else if (i % 2 != 0)
                {
                    Console.Write($"Sua vez {NomeJogador[1]},Digite o numero que deseja marcar o O: ");
                    valorMarcado = Console.ReadLine();
                    while (valorMarcado != "0" && valorMarcado != "1" && valorMarcado != "2" && valorMarcado != "3" && valorMarcado != "4"
                  && valorMarcado != "5" && valorMarcado != "6" && valorMarcado != "7" && valorMarcado != "8")
                    {
                        Console.Write("Valor inválido, digite novamente um número válido :");
                        valorMarcado = Console.ReadLine();
                    };
                    int j = int.Parse(valorMarcado);
                    jogo[j] = "O";
                }

                

            }

        
            Console.WriteLine();
            MenuFinal(NomeJogador, contadorplayer1, contadorplayer2, contadorEmpate);


        }


        static void MenuFinal(List<string> NomeJogador, int contadorplayer1, int contadorplayer2, int contadorEmpate)
        {
            


            int opcaoDesejada;
            do
            {
                Console.WriteLine("1 - Jogar novamente");
                Console.WriteLine("2 - Mostrar tabela");
                Console.WriteLine("0 - Sair do jogo");

                opcaoDesejada = int.Parse(Console.ReadLine());

                switch (opcaoDesejada)
                {

                    case 1:
                        IniciarJogo(NomeJogador);
                        break;
                    case 2:
                        MostrarTabela(NomeJogador, contadorEmpate, contadorplayer2, contadorplayer1);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do jogo...");
                        
                        break;

                }
            } while (opcaoDesejada != 0);


        }

        static void MostrarTabela(List<string> NomeJogador, int contadorplayer1, int contadorplayer2, int contadorEmpate)
        {

            Console.WriteLine($"{NomeJogador[0]} = {contadorplayer1} Vitórias");
            Console.WriteLine();
            Console.WriteLine($"{NomeJogador[1]} = {contadorplayer2} Vitórias");
            Console.WriteLine();
            Console.WriteLine($"{contadorEmpate}  Empates");
            Console.WriteLine();
        }

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