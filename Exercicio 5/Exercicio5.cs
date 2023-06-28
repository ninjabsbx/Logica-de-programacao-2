using System.Globalization;

int N = int.Parse(Console.ReadLine());
int[] maior = new int[N];

Console.WriteLine("Digite os valores  ");
for (int i = 0; i < N; i++)
{
    maior[i] = 0;
    string[] valores = Console.ReadLine().Split(" ");

    for (int j = 0; j < N; j++)
    {
        int valor = int.Parse(valores[j]);
        if (valor > maior[i])
        {
            maior[i] = valor;
        }
    }
}
for (int i = 0; i < N; i++)
{
    Console.WriteLine(maior[i]);
}
