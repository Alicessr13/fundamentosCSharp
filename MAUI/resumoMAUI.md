Criando projeto MAUI
![alt text](image.png)

É um unico projeto soportado por várias plataformas (Windows, iOS, Android, MAC)

pasta dependencias ficam os pacotes de cada plataforma
pasta propriedades tem um arquivo de configuração para inicilizar no windows
pasta plataforms tem arquivos nativos, de configuração, classes e recursos de cada plataforma
pasta recursos centraliza recursos do MAUI (fontes, icones, imagens, estilos)

fluxo de execução: começa a ser executado nas classes nativas de cada plataforma, main que chama o MAUI program
![alt text](image-1.png)

no MAUI program configura a classe a ser executada inicialmente, fontes que serão carregadas, injeções de dependências, etc
ou seja classe MAUIProgram e uma classe de configuração, dentro da classe pode ver qual é o proximo arquivo do fluxo por meio do metodo UseMauiApp que executa o App.xaml
![alt text](image-2.png)
![alt text](image-3.png)
conceito code behind: tem 2 arquivos um xaml para cuidar da interface da tela e um c# para cuidar da lógica
2 arquivos diferentes associados/vinculados
![alt text](image-4.png)

xaml linguagem de marcação da microsoft e uma variação do xml

MauiProgram chama app, onde tem o metodo InitializeComponent(); que le o xml e cria classes/objetos 
![alt text](image-5.png)
no app tem o MainPage que chama o AppShell(); no AppShell.xaml tem o content que chama um arquivo main page
no main page tem as tags que criam a tela (MainPage.xaml) e o código por trás da tela (MainPage.xaml.cs)

para alterar nome de exibição, versão, id, plataformas suportadas, etc pode ser em propriedades do projeto (.net vai replicar no arquivo de configuração de cada plataforma, ou pode configurar especificamente por plataforma)
![alt text](image-7.png)
ou clicando 2 vezes no projeto
![alt text](image-8.png)