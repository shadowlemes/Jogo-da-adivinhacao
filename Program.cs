using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Jogo Advinhação");
            Console.ResetColor();

            Console.WriteLine("\nInforme seu nome:");
            string nomeJogador = Console.ReadLine()!;
            Console.Clear();
            int numeroSecreto = new Random().Next(1, 101);
            Console.WriteLine($"Olá {nomeJogador}, pressione qualquer tecla para iniciar o game:");
            Console.ReadLine();
            Console.Clear();

            int tentativas = 5;

            Console.WriteLine("\nAdivinhe o número de 1 até 100:");

            //loop
            while (true)
            {
                int numeroDigitado = int.Parse(Console.ReadLine()!);

                if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine($"\nO número {numeroDigitado} é maior do que o número secreto.\nTentativa {tentativas}.\n");
                }
                if (numeroDigitado < numeroSecreto)
                {
                    Console.WriteLine($"\nO número {numeroDigitado} é menor do que o número secreto.\nTentativa {tentativas}.\n");
                }
                //Quando usuário acertar o número
                if (numeroDigitado == numeroSecreto)
                {
                    Console.Clear();
                    Console.WriteLine("\nParabéns " + nomeJogador + ", você acertou com " + tentativas + " tentativas, o número secreto era " + numeroSecreto + ".");
                    break;
                }
                if (tentativas == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fim de jogo, você não possui mais tentativas");
                    Console.ResetColor();
                    Main();
                }
                tentativas++;
            }
        }
    }
}