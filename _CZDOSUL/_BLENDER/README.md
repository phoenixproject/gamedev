# czdosul
CST em Jogos Digitais - Modelagem Digital (aplicada no Blender)

## Definições sobre a interface do Blender

### Cena básica ou cena padrão da abertura do Blender

A cena padrão é formada por um cubo, pela câmera e uma fonte de luz

### Viewport ou Cena 3D ou Workspace

É basicamente é o contém a cena básica

## Estrutura básica do Blender

### Menu de gerenciamento de janelas

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/01_menu_janelas.png?raw=true "Menu de janelas")

O Blender tem um menu para cada janela e no primeiro ícone à esquerda
pode escolher qual a janela queremos trabalhar no momento.

É tudo que você pode importar para o seu jogo (sons, imagens, etc). Quando se está programando games em Java esse
diretório costuma ser chamado de res.

Mais a direita (não mostrado na figura) encontramos os menus relacionados ao 3D View e ao Viewport (eles mudam conforme
a janela escolhida).

### Menu View

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/02_menu_view.png?raw=true "Menu View")

Neste menu destacamos o item Tool Shelf que é a barra de ferramentas do Blender que fica na área superior
à esquerda como mostrado na seta e o item Properties que quando selecionado exibe na extrema direita da tela
as propriedades do objeto selecionado.

### Atributos dos objetos

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/04_atributos_objetos.png?raw=true "Atributos dos objetos")

Esta área é utilizada para acessar e modificar valores dos atributos ou de outros objetos relacionados ao objeto selecionado.

### Outline

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/05_outline.png?raw=true "Timeline")

Esta área mostra tudo o que está na nossa cena 3D ou a grosso modo a área de exibição de camadas do Photoshop.

### Timeline ou Linha do Tempo

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/03_timeline.png?raw=true "Timeline")

Esta área é utilizada para quem pretende trabalhar com animações.

### Plugin Screencast Keys

Para poder visualizar tudo o que está acontecendo com o mouse e o teclado é possível utilizar um plugin chamado Screencast Keys.
É possível importá-lo utilizando o Menu Janelas > Text Editor > Open > (informar o local de onde está o script) > Run Script.

O script pode ser encontrado aqui:
![Screencast Keys (script)](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_EXTENSIONS/screencastkeys.py?raw=false "Screencast Keys")

E também neste endereço é possível encontrar sua última versão feita para o Blendr 2.6.
[Screencast Keys versão antiga](https://archive.blender.org/wiki/index.php/Extensions:2.6/Py/Scripts/3D_interaction/Screencast_Key_Status_Tool/)<br/>

Após a execução do script é possível encontrá-lo no menu de objetos.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/06_screencastkeys.png?raw=true "Timeline")

Esta área é utilizada para quem pretende trabalhar com animações.

### Teclas de atalho

O software detecta as teclas de atalho a partir de onde se encontra o cursor do mouse.

#### Botão Scroll do mouse em Operações de Visualização

Girando este botão é possível se distanciar e se aproximar da cena.

Clicando e segurando este botão é possível rotacionar a visão da cena, tanto movendo o mouse
para cima e pra baixo quanto para esquerda e direita.

Segurando a tecla Shift junto a e este botão é possível deslocar a vista do que está sendo
visto na cena 3D.

### Modo de visualizações da Cena e Atalhos

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/03_modosdevisualizacao.png?raw=true "Modos de Visualização")

Na área superior à direita da cena 3D é exibido qual o modo de visualização está sendo utilizado na cena 3d
(no caso acima é a User Perpective).

No menu View é possível escolher quais modos de visualização podem ser utilizados (Cameras, Left, Right, Back,
Front, Bottom, Camera). Também é possível alterar estes modos de visualização pelo teclado númérico ou com
as teclas dele sendo utilizadas em conjunto com a tecla Crtl).

Ainda no menu View existe um item em que permite visualizar a cena por Perpectiva ou Orthogonal (exibindo apenas
os eixos Y e Z).

### Duplicação/Remoção de painéis

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/08_duplicacaoremocaopanels.png?raw=true "Duplicação/Remoção de Painéis")

Na área superior à direita de cada painél é exibido alguns traços na diagonal formando um triângulo e partir
dele podemos adicionar ou ocultar um painel no Blender conforme clicamos com o o botão esquerdo do mouse e arrastamos.

Para adicionar (ou clonar ou dividir) um novo painel clicamos com o botão esquerdo do mouse e arrastamos o painel para a esquerda.

Para remover (ou ocultar) um painel clicamos com o botão esquerdo do mouse e arrastamos o painel para a direita sobrepondo
o painel existente que está a direita.

### Dividir/Juntar (Split/Join) área de trabalho na horizontal e na vertical

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/09_splitareahorizontal.png?raw=true "Split Área Horizontal")

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/10_splitareavertical.png?raw=true "Split Área Vertical")

Estacionando o mouse em uma borda lateral ou superior de uma área de trabalho do Blender é possível dividir ou
juntar áreas de trabalho

Para Dividir a área clicamos com o botão direito do mouse, escolhemos a opção Split.

Para Juntar a área clicamos com o botão direito do mouse, escolhemos a opção Join e
informamos qual área deverá ser mesclada com a indicada.

### Escolha de layouts pré definidos para trabalho

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/11_layoutspredefinidos.png?raw=true "Lista de layouts pré definidos")

O Blender possui alguns layouts pré definidos para determinadas preferência de modo de trabalho. Para
que seja possível basta clicar na área superior como mostrada na imagem e trocar o modo.

### Busca de comandos em área de trabalho

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/12_buscacomandos.png?raw=true "Busca de Comandos")

Caso seja preciso buscar algum comando durante o trabalho basta pressionar a tecla espaço que um menu
contendo um índice com todos os comandos possíveis se abrirá com a função auto completar filtrando
os resultado enquanto digita.