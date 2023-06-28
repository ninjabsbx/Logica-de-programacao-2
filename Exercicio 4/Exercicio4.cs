using System;
using System.Globalization;
using System.Xml.Schema;

namespace ConsoleApp14
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int maioraltura = 0;
            int quantia_de_homems = 0;
            int quantia_de_mulheres = 0;


            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int altura = int.Parse(valores[0]);
                char genero = char.Parse(valores[1]);

                if (genero == 'M')
                {
                    quantia_de_homems += altura;
                }
                else if (genero == 'F')
                {
                    quantia_de_mulheres += altura ;
                }
            }
        }
    }
}
