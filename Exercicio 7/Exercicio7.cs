using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;
Console.WriteLine("quantidade de linhas");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantos valores nas linhas");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Digite os valores");
int[,] matriz = new int[M, N];
for (int i = 0; i < M; i++)
{
    string[] valores = Console.ReadLine().Split(" ");

    for (int j = 0; j < N; j++)
    {
        matriz[i, j] = int.Parse(valores[j]);
    }
}
Console.WriteLine("qual fila para girar");
int O = int.Parse(Console.ReadLine());
for (int i = 0; i < M; i++)
{
    string fila = "";
    for (int j = 0; j < N; j++)
    {
        if(i + 1 != O || j < N - 1)
            fila += matriz[i, j].ToString() + " ";
        else
            fila = matriz[i, j].ToString() + " " + fila;
    }
    Console.WriteLine(fila);
}