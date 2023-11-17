Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 1000);

do
{
    Console.Write("Digite um número entre 1 e 1000: ");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }else if(chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor");
    }

}while (true);
Console.WriteLine("O jogo acabou. Você acertou o número secreto!");