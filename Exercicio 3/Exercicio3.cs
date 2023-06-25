using System.Globalization;
Console.WriteLine("Digite quantos pessoas");
int N = int.Parse(Console.ReadLine());
String[] nome = new String[N];
int[] idade = new int[N];
int mais_velho = 0;
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Digite o nome da pessoa " + (i + 1).ToString());
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa " + (i + 1).ToString());
    idade[i] = int.Parse(Console.ReadLine());
    if (idade[i] >= idade[mais_velho])
    {
        mais_velho = i;
    }
}
Console.WriteLine("Pessoa mais velha: " + nome[mais_velho]);
