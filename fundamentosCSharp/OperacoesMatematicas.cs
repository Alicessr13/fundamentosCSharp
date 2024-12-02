using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosCSharp
{
    internal class OperacoesMatematicas
    {
        public (int resultadoAdicao,string autor) Adicionar(int valor1, int valor2)
        {
            return (valor1 + valor2, "Alice");
        }

        public void Teste(int valor1, int valor2 = 7)
        {
            Console.WriteLine(valor1 + valor2);
        }

        public static int Somar(int valor1, int valor2) => valor1 + valor2;
    }
}
