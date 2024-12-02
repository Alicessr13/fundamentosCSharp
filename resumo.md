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

tipos númericos:
inteiro, diferença entre eles é o intervalo de números aceitos, tem outros tipos inteiros mas de exemplo esses:
int = 7;
long = 7;
uint = 7 (inteiro sem sinal,somente com números positivos);
int numero = 1_000 pode ser usado o underline para separar as casas dos números

ponto flutuante, decimais, utiliza ponto ao invés de vírgula, diferença e a precisão
double = 3.14; (precisão 15 a 17)
float = 3.14f (precisa colocar f senão ele reconhece o número como double, precisão 6 a 9);
decimal = 3.14m (mesmo caso do f, precisão 28 a 29)

tipo booleano, falso ou verdadeiro
bool ativo = false;
bool ativo2 = true

texto, cada caracter tem uma numeração que começa em zero, espaço também e um caracter
char letra = 'a'; (somente 1 caracter)
string texto = " Alice "; (conjunto de caracter)
char primeiraLetra = texto[0]

string nomeSemEspaço = texto.Trim(); = tira espaço final e começo
bool começaCom = texto.StartsWith("A"); = retorna true ou false se começa com o caracter, é case sensitive, também tem o EndsWith
string troca = texto.Replace('A', '1'); = altera um caracter por outro, primeiro o caracter antigo, depois o novo
bool existe = texto.Contains('Ali'); = verifica se no texto contem o caracter ou conjunto de caracteres
bool existe = texto.Equals('Ali'); = verifica se é exatamente igual

string paragrafo = texto + " " + texto2 + " " + 7; concatenação
string paragrafo2 = $"A primeira frase: {texto} segunda frase {texto2} {7}"; outro modo de concatenar em versões mais novas
\n pula linha, \t um tab, para não dar o tab ou pular linha e \\t \\n ou coloca @ no inicio da string, @"C:\teste";
StringBuilder usado se for concatenar muitas strings e variaveis por questão de performance

string texto3 = "O usuário {0} gosta do numero {1}";
string resultado = string.Format(texto, "Alice", 7); vai formatar o texto e colocar nos valores 0 e 1 as informações colocadas no format em ordem, gera uma nova string

DateOnly dia = new DateOnly(2023,12,1); resultado 01-Dec-23
string diaEmText = dia.ToShortDateString(); resultado 01-Dec-23
string diaEmText = dia.ToLongDateString(); resultado Friday, December 1, 2023
string diaEmText = dia.ToString(new CultureInfo("pt-BR")); resultado 01/12/2023
string diaEmText = dia.ToString("d", new CultureInfo("pt-BR")); resultado sexta-feira, 1 de dezembro de 2023, mais formatos na documentação
string diaEmText = dia.ToString("dd MMMM yyyy", new CultureInfo("pt-BR")); resultado 1 dezembro 2023

DateTime dia = new DateTime(2023,12,1, 20, 07, 1); data e hora, primeiro as horas depois os minutos depois os segundos
DateTime hoje = new DateTime.Now; pega a hora e data atual do servidor
DateTime hoje = new DateTime.Today; pega somente a data e por padrão vem hora meia noite
DateTime hoje = new DateTime.UtcNow; pega a hora universal ainda sendo possivel calcular para ver a hora da maquina do usuário utc=gmt

enum, variavel com mais de uma opção, define os valores possiveis e escolhe uma opção, precisa criar fora da função, pode dar um número para o valor, não precisa ser em sequencia, 
mas precisam ser positivos e não podem ser duplicados

criar:
enum NiveldeDificuldade
{
    Baixo = 0,
    Medio = 1,
    Alto = 2
}

escolher: NiveldeDificuldade nivel = NiveldeDificuldade.Medio;

tipo var, deixa o compilador selecionar o tipo de variavel, sempre precisa passar um valor na declaração
var valor = "Alice";
var valor2 = 13;

object, é um tipo de dados que pode apontar para qualquer tipo de dados

a palavra-chave var define uma variável local com um tipo implícito, enquanto object é um tipo de referência que serve de base para todos os outros tipos

null, representar a ausência de um valor ou referência em tipos que podem aceitar valores nulos, para valores numericos precisa colocar ? no tipo da variavel
int? idade = null;
HasValue é usada para verificar se uma variável de tipo anulável contém um valor ou é null, resultado true se tiver valor ou false se for null
Value retorna o valor armazenado em uma variável anulável, se ela não for null, se for null e usar o value retorna uma exceção

array variaveis para armazenar coleção de valores do mesmo tipo, acesso pelas posições, primeira posição sempre é zero, tamanho fixo (pode aumentar ou diminuir mas e muito custoso para o computador fazer)
int[] inteiros = new int[10]; array de int com tamanho 10, posições 0 até o 9
Console.WriteLine(inteiros.Length); ver tamanho do array
inteiros[0] = 1; primeira posição valor 1
int[] inteiros = [1,2,3]; quando ja sabe os valores do array, tamanho do array 3
int[,] inteiros2 = new int[10,10]; array de duas dimensões, 10 linhas por 10 colunas, podem ter mais dimensões
inteiros2[0,0] = 2; valor 2 na linha 0 coluna 0
inteiros2[0,3] = 5; valor 5 linha 0 coluna 3
por default se não colocar valor fica 0

lista, variavel para armazenar coleções de valores do mesmo tipo, mas não tem tamanho fixo, também tem posições e começa com 0, tem somente 1 dimensão
List<int> lista = new List<int>();
Console.WriteLine(lista.Count); ver tamanho da lista
lista.Add(5); adicionar elemento a lista
lista.Remove(5); remover elemento da lista passando o valor, se tinha um elemento depois ele assume a posição do elemento removido
lista.RemoveAt(0); remover elemento passando a posição
lista.Clear(); remove todos os elementos
acessar elemento: lista[0] passa a posição, lista.First() primeiro elemento, lista.Last ultimo elemento, lista.ElementAt(0) passa a posição
string resultado = string.Join(" ",lista); juntar uma lista em uma string so, passa a lista e o que vai ser usado de separação

pode ter lista de instancia de classe
lista de objetos pode receber valores de tipos diferentes

dicionario, para cada chave tem um valor associado, chaves precisam ser valores unicos não pode duplicar
Dictionary<int, string> dicionario = new Dictionary<int, string>(); chave de valor inteiro e elemento string
dicionario.Add(1, "Alice"); adicionando chave e valor
dicionario[1]; acessa os valores pela chave  
dicionario.ContainsKey("Alice"); verifica se existe o valor, returna true ou false

HashSet, parecido com lista mas os valores precisam ser unicos, não da erro mas não adiciona o valor
HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(5);
set.Add(1);
Console.WriteLine(set.Count); resultado é 2 pois não adicionou o valor

funções com parametros
função publica de retorno vazio, recebe 2 parametros que precisam ser passados ao chamar a função
public void Adicionar(int valor1, int valor2){ 
    var resultado = valor1 + valor2;
    Console.WriteLine(resultado);
}

chamando a função:
    var matematica = new OperacoesMatematicas();
    matematica.Adicionar(1,7);

    para melhor entendimento do código pode se passar parametros nomeados, com parametros nomeados pode alterar a ordem dos parametros passados
    matematica.Adicionar( valor1: 1, valor2: 7);

    sempre dar nome significativo para função e para as variaveis

função devolvendo valor precisa passar o tipo do resultado que será devolvido e passar o retorno com o return
public int Adicionar(int valor1, int valor2)
{
    return valor1+valor2;
}

se a função tem somente 1 linha de código ela pode ser resumida:
public int Adicionar(int valor1, int valor2) => valor1 + valor2;

public int Adicionar(int valor1, int valor2) => Console.WriteLine(valor1+valor2);

função que devolve mais de 1 valor
public (int,string) Adicionar(int valor1, int valor2)
{
    return (valor1 + valor2, "Alice");
}

Console.WriteLine(resultado.); acessando o primeiro valor retornado
Console.WriteLine(resultado.Item2); acessando o segundo valor retornado

passando nome para o retorno 
public (int resultadoAdicao,string autor) Adicionar(int valor1, int valor2)
{
    return (valor1 + valor2, "Alice");
}
 Console.WriteLine(resultado.resultadoAdicao);
 Console.WriteLine(resultado.autor);
 (int resultado, string nome) = matematica.Adicionar(1, 7); recebendo os valores em variaveis diferentes

para tornar um parametro opcional pode se passar um valor para ele na função, valores opcionais devem ser os ultimos da função, devem aparecer somente após os valores obrigatórios
public void Teste(int valor1, int valor2 = 7)
{
    Console.WriteLine(valor1 + valor2);
}

matematica.Teste(valor1:3); se não passar o valor2 ele vai por padrão 7, se passar o valor2 ele vai sobreescrever o valor 7

propriedades das classes precisam do get e set para poder acessar a variavel, get para recuperar o valor, set para passar um valor
public string Model {  get; set; }
pode ter uma variavel/propriedade com mesmo nome do tipo, mas não mesmo nome da classe
meuCarro.Model = "Lamborghini"; passando valor
Carro meuCarro = new Carro //passando valor na instanciação
{
    Model = "Lamborghini",
};
public required string Model {  get; set; } required deixa a propriedade obrigatória
mas para obrigar a passar o valor pode ser criado uns construtor para ser chamado sempre que instanciar a classe
public Carro(string model)
{
    Model = model;
}
Carro meuCarro = new Carro("Lamborghini");