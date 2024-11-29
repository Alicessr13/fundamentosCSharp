
using fundamentosCSharp.teste1;

namespace fundamentosCSharp;

class Program
{
     static void Main()
    {
        //Console.WriteLine("Ola, mundo!");
        //Console. = abre o console e WriteLine = escreve uma linha, texto sempre em "" 

        Carro meuCarro = new Carro(); //criando o objeto Carro dentro da variavel meuCarro do tipo Carro

        meuCarro.Ligar();
        meuCarro.Desligar();
    }
}



