
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

        int[,] inteiros2 = new int[10,10];

        inteiros2[0,3] = 2;

        Console.WriteLine(inteiros2[0,0]);
        Console.WriteLine(inteiros2[0,2]);
        Console.WriteLine(inteiros2[0,3]);

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

        matematica.Teste(valor1:3);

        var resuldadoSoma = OperacoesMatematicas.Somar(1, 2);
    }
}



