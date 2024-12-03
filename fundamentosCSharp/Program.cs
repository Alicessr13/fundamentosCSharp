
using System.Data;
using fundamentosCSharp.teste1;

namespace fundamentosCSharp;

class Program
{

    enum NiveldeDificuldade
    {
        Baixo,
        Medio,
        Alto
    }
    static void Main()
    {
        //Console.WriteLine("Ola, mundo!");
        //Console. = abre o console e WriteLine = escreve uma linha, texto sempre em "" 

        Carro meuCarro = new Carro("Lamborghini");
        //criando o objeto Carro dentro da variavel meuCarro do tipo Carro

        //meuCarro.Model = "Lamborghini";
        //meuCarro.Cor = Cor.Azul;
        //meuCarro.LancadoEm = new DateOnly(2021, 01,01);

        meuCarro.NomeDoModelo();

        NiveldeDificuldade nivel = NiveldeDificuldade.Medio;

        int? idade = null;

        int[] inteiros = new int[10];

        Console.WriteLine(inteiros.Length);

        inteiros[0] = 1;

        int[,] inteiros2 = new int[10, 10];

        inteiros2[0, 3] = 2;

        Console.WriteLine(inteiros2[0, 0]);
        Console.WriteLine(inteiros2[0, 2]);
        Console.WriteLine(inteiros2[0, 3]);

        List<int> lista = new List<int>();

        lista.Add(1);
        lista.Add(5);

        Console.WriteLine(lista.Count);

        lista.Remove(5);

        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Alice");

        string valor = dicionario[1];
        Console.WriteLine(valor);

        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(5);
        set.Add(1);
        Console.WriteLine(set.Count);

        var matematica = new OperacoesMatematicas();
        var resultado = matematica.Adicionar(1, 7);
        Console.WriteLine(resultado.resultadoAdicao);
        Console.WriteLine(resultado.autor);

        matematica.Teste(valor1: 3);

        var resuldadoSoma = OperacoesMatematicas.Somar(1, 2);

        int num = 10;

        if (num > 0)
        {
            Console.WriteLine("Numero positivo");
        }
        else if (num == 0)
        {
            Console.WriteLine("Numero igual a zero");
        }
        else
        {
            Console.WriteLine("Numero negativo");
        }

        int numero = 7;
        string autor = numero == 7 ? "Alice" : "Stephanie";

        Console.WriteLine(autor);

        switch (nivel)
        {
            case NiveldeDificuldade.Alto:
                {
                    Console.WriteLine("Nivel alto");
                }
                break;

            case NiveldeDificuldade.Medio:
                { Console.WriteLine("Nivel medio"); }
                break;

            case NiveldeDificuldade.Baixo:
                {
                    Console.WriteLine("Nivel baixo");
                }
                break;

            default:
                {
                    Console.WriteLine("sem nivel");
                    break;
                }

        }

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("contador: " + i);
        }

        var lista2 = new List<string> { "Alice", "Stephanie", "Soares", "Ribeiro" };
        foreach (var item in lista2)
        {
            Console.WriteLine(item);
        }

        int num1 = 0;
        while (num1 < 10)
        {
            Console.WriteLine(num1);
            num1++;
        }

        int num2 = 10;
        do
        {
            Console.WriteLine("teste");
        }while (num2 < 10);

        int num3 = 0;

        while(num3 < 10){

            num3++;
            if (num3 == 5)
            {
                break;
            }
            Console.WriteLine(num3);
        }

        Teste(5);
    }

    static string Teste(int num)
    {
        Console.WriteLine("teste1");
        if (num == 5)
        {
            Console.WriteLine("teste2");
            return "Alice";
        }

        Console.WriteLine("teste3");
        return "Stephanie";
    }
}



