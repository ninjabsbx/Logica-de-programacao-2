using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;

int N = int.Parse(Console.ReadLine());
int soma = 0;
Console.WriteLine("Digite os valores  ");
for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(" ");

    for (int j = 0; j < N; j++)
    {
        int valor = int.Parse(valores[j]);
        if (i < j)
        {
            soma += valor;
        }
    }
}
Console.WriteLine(soma);
