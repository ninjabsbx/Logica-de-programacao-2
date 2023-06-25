using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Determine qual e a pessoa mais velha");
static void Main(String[] args)
{
//leitura de dados
Console.WriteLine();
}
public class pessoa
{
    //construtores
    public pessoa(String nome, int idade)
    {
        this.nome = nome;
        this.Idade = idade;
    }
    //propriedades

    private string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = value.ToUpper(); }
    }
    public int Idade { get; set; }
    //metodos
    public void exibirdados()
    {
        Console.WriteLine("Nome : " + this.Nome);
        Console.WriteLine("Idade :" + this.Idade);
    }
}
 