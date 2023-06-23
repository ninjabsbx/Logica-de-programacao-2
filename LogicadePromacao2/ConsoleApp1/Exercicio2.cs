using System.Globalization;
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Digite valores para somar a media aritmetica");
double[] A = new double[N];
double media = 0;
for (int i = 0; i < N; i++)
{
    A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    media += A[i];
}
media /= N;
Console.WriteLine("Media:");
Console.WriteLine(media);
for (int i = 0; i < N; i++)
{
    if (A[i] < media)
        Console.WriteLine(A[i]);
}




