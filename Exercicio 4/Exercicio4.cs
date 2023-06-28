using System;
using System.Globalization;

int N = int.Parse(Console.ReadLine());

int mais_alto = 0;
int mais_baixo = 0;
int quantia_de_homens = 0;
int quantia_de_mulheres = 0;
decimal alturaatual;
Decimal soma_alturas = 0;

char[] genero = new char[N];
Decimal[] altura = new Decimal[N];

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
if (decimal.TryParse(valores[0], NumberStyles.Number, CultureInfo.InvariantCulture, out alturaatual))
    {
        altura[i] = alturaatual;
    }
    else
    {
        Console.WriteLine("Altura inválida na posição " + (i + 1));
        continue;
    }    genero[i] = char.Parse(valores[1]);

    if (genero[i] == 'M')
    {
        quantia_de_homens += 1;
    }
    else if (genero[i] == 'F')
    {
        quantia_de_mulheres += 1;
        soma_alturas += altura[i];
    }

    if (altura[i] >= altura[mais_alto])
    {
        mais_alto = i;
    }
    if (altura[i] <= altura[mais_baixo])
    {
        mais_baixo = i;
    }
}
Console.WriteLine("Menor altura: " + altura[mais_baixo].ToString("F2"));
Console.WriteLine("Maior altura: " + altura[mais_alto].ToString("F2"));
Console.WriteLine("Media da altura de mulheres:" + (soma_alturas / quantia_de_mulheres).ToString("F2"));
Console.WriteLine("Numero de homens: " + quantia_de_homens);