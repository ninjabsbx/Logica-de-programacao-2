using System.Globalization;
Console.WriteLine("Digite quantos valores para colocar");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Digite valores para o Vetor A");
double[] A = new double[N];
double[] B = new double[N];
double[] C = new double[N];
for (int i = 0; i < N; i++) 
{
    A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
Console.WriteLine("Digite valores para o Vetor B");
for (int i = 0; i < N; i++)
{
    B[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    C[i] = A[i] + B[i];
}
String C_str = "C: ";
for (int i = 0; i < N; i++)
{
    C_str += C[i] + " ";
}
Console.WriteLine(C_str);
