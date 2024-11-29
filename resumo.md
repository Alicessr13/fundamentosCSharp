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
