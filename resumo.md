linguagem da microsoft, open source de alto nivel(mais perto da linguagem humana), se destina a ser simples moderna e economica (consumo de memoria e processamento)

pode ser usado em api, aplicativos windows, mac, android e ios, sites,

linguagem orientada a objetos, tudo e um objeto(bom para organização e reutilização)

c# possui um colector de lixo, garbage collector, que age automaticamente e não é necessário se preocupar em liberar memoria, ele mesmo limpa, limpa partes não referenciadas

linguagem tipada, precisa definir o tipo das váriaveis e o compilador valida (evita erros)

segurança, fornece um bom nivel de segurança para as aplicações

csharp vai ser compilado para CLR

gerenciamento de momória feito automaticamente

IDE = ambiente de desenvolvimento integrado, ajuda no desenvolvimento, compila, autocomplete, debug

//comentários

/\* \*/ comentário mais de uma linha

projeto = onde implementa os códigos (classes, funções, imagens, arquivos)

solution = container que vai agrupar os projetos que estão relacionados, quando abre a solution no visual studio ja abre todos os projetos dentro da solution

projeto do tipo console gera um executavel que abre um terminal, outros tipos de projetos geram coisas diferentes (como bibliotecas)

se na parte de executar o projeto não estiver aparecendo nada, nas váriaveis de ambiente (path) o com a pasta program files dotnet precisa estar acima da pasta x86 do dotnet

namespace = forma de organizar o conteudo dentro do projeto (classe, interface), classes podem ter nomes iguais desde que em namespaces diferentes, nome do namespace = nome do projeto,
se tiver mais pastas dentro do projeto faz a junção nome do projeto + nome da pasta exemplo: iniciandoCSharp.teste1,
em versões mais antigas do c# após o namespace precisa abrir {} e escrever o código dentro, em versões mais atuais não precisa e pode colocar ;
em opções, text editor, general, pode definir se prefere {} ou ; na criação do namespace

classe = molde para construir um objeto real, e esse molde define caracteristicas do objeto, exemplo: classe usuário, propriedade nome email telefone, também pode definir comportamentos que
podem ser transformados em funções

exemplo:
class Program
{

}

para escrever uma instrução/passo a passo no código escreve uma função, ao criar função precisa pensar se ela precisa devolver algum valor ou não, função sem devolver valor e void,
os nomes precisam ser significativos e é case sensitive
projeto console aplication ao ser executado ele vai procurar a função Main para iniciar o projeto

exemplo:
static void Main() //função Main dentro da classe
{
Console.WriteLine("Ola, mundo!");
//Console. = abre o console e WriteLine = escreve uma linha, texto sempre em ""
}

para usar uma função em outra classe precisa instanciar um objeto da classe dentro da outra

exemplo: Carro meuCarro = new Carro(); criando o objeto Carro dentro da variavel meuCarro do tipo Carro

objeto = meuCarro, tipo = Carro, que é uma instancia/objeto da classe carro

para poder usar a função em outra classe precisa ter o public na frente, se estiver dentro de outro namespace ou pasta precisa usar o using iniciandoCSharp.teste1;

exemplo: public void Ligar()
{
Console.WriteLine("Carro ligado");
}

modificadores de acesso:

public = qualquer classe que tiver uma instancia dessa classe pode acessar essa função

private = somente a propria classe pode usar essa função

internal = somente classes que estão dentro do projeto podem acessar

se não colocar modificador de acesso na função vai ser private

classe só tem 2 modificadores, public ou internal, se não marca o padrão e internal
