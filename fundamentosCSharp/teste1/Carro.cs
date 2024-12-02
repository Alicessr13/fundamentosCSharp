using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosCSharp.teste1;
class Carro
{
    public  string Model {  get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor {  get; set; }

    public void NomeDoModelo() => Console.WriteLine(Model);

    public Carro(string model)
    {
        Model = model;
    }

}

public enum Cor {
    Vermelho,
    Azul,
    Amarelo
}
