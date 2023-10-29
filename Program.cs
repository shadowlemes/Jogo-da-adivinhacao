Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░  ██████╗░░█████╗░
░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██╔══██╗
░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██║░░██║███████║
██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║░░██║██╔══██║
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██████╔╝██║░░██║
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═════╝░╚═╝░░╚═╝

░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║███████║██║░░╚═╝███████║██║░░██║
██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══██║██║░░██╗██╔══██║██║░░██║
██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
Console.WriteLine("\nInforme seu nome por favor:");
//Primeiro vamos criar a variável
int numeroSecreto = new Random().Next(1, 101);

//Variável que armazane as tentativas realizadas
int tentativas = 0;

// Captura o nome do jogador
string nomeJogador = Console.ReadLine()!;
Console.Clear(); //Esse trecho limpa as mensagem anteriores, trazendo somente as seguintes 

// Exibe o nome do jogador
Console.WriteLine("Olá " + nomeJogador + ", pressione qualquer tecla para iniciar o game:");
Console.ReadLine();
Console.Clear();

while (true)
{
    Console.WriteLine("\nAdivinhe o número de 1 até 100:");

    //Aqui vamos criar um loop
    while (true)
    {
        //Aqui pede para que o usuário digite o número e senha convertido para int
        int numeroDigitado = int.Parse(Console.ReadLine()!);        

        //Verificar se o número é maior ou menor que o da variavel armazenada
        if (numeroDigitado > numeroSecreto)
        {
            Console.Clear();
            Thread.Sleep(1000); //Esse trecho traz delay para a mensagem seguinte
            Console.WriteLine("\nO número digitado é maior do que o número secreto.");
        }
        else if (numeroDigitado < numeroSecreto)
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("\nO número digitado é menor do que o número secreto.");
        }

        //Quando usuário acertar o número
        else
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("\nParabéns " + nomeJogador + ", você acertou com " + tentativas + " tentativas, o número secreto era " + numeroSecreto + ".");
            break;
        }
        tentativas++;
    }
}
