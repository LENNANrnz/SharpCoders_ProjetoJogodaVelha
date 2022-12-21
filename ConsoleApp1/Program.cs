using System;

namespace JogoDaVelha
{


    public class Program
    {

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

            string[] jogo = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            string valorMarcado;


            for (int i = 0; i <= 9; i++)
            {

                Console.Clear();

                Console.Write($"__{jogo[0]}__|__{jogo[1]}__|__{jogo[2]}__\n" +
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
                        Console.Write($"o ganhador é {NomeJogador[0]}");
                        break;
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"o ganhador é {NomeJogador[1]}");
                        break;
                    }

                }

                if (i % 2 == 0)
                {
                    Console.Write($"Sua vez {NomeJogador[0]},Digite o numero que deseja marcar o X: ");
                    valorMarcado = Console.ReadLine();
                    int j = int.Parse(valorMarcado);
                    jogo[j] = "X";

                }
                else if (i % 2 != 0)
                {
                    Console.Write($"Sua vez {NomeJogador[1]},Digite o numero que deseja marcar o O: ");
                    valorMarcado = Console.ReadLine();
                    int j = int.Parse(valorMarcado);
                    jogo[j] = "O";
                }



            }

        }
    }
}