Jogo de Adivinhação em C#
Este projeto é um simples jogo de adivinhação de números desenvolvido em C#. O jogador tem o objetivo de adivinhar um número secreto gerado aleatoriamente, com base em dicas que informam se o número digitado é maior ou menor que o número secreto. Esse projeto foi criado para fins de aprendizado e para demonstrar habilidades básicas em programação em C#.

Funcionalidades
-Geração de número aleatório entre 1 e 100.
-Interação com o usuário para receber tentativas de adivinhação.
-Dicas indicando se o número tentado é maior ou menor que o número secreto.
-Mensagem de parabéns ao acertar o número.
-Limite de tentativas.

Conceitos Utilizados
Entrada e Saída de Dados: O jogo solicita o nome do jogador e as tentativas através do Console.ReadLine() e exibe informações com Console.WriteLine().
Geração de Número Aleatório: O número secreto é gerado usando Random().Next(1, 101), tornando cada jogo único.
Controle de Fluxo: Utilização de estruturas de controle como if para verificar as tentativas do jogador e while para manter o loop de tentativas até o jogador acertar.
Tratamento Visual: O uso de Console.ForegroundColor e Console.ResetColor() para melhorar a experiência visual do jogador.
Como Jogar

O jogador insere o nome ao iniciar o jogo.
O sistema gera um número secreto entre 1 e 100.
O jogador deve adivinhar o número, recebendo dicas se o número inserido é maior ou menor que o secreto.
O jogo continua até que o jogador acerte o número ou o limite de tentativas seja atingido.


Requisitos
.NET 6.0 ou superior.

Melhorias Futuras
Adicionar um sistema de limite de tentativas com contagem regressiva.
Melhorar o feedback visual com mais personalização de cores.
Implementar tratamento de erros mais robusto para entradas inválidas.

Se você tiver algum feedback ou sugestão sobre o projeto, fique à vontade para me contatar.
