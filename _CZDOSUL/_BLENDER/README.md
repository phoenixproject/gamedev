# czdosul
CST em Jogos Digitais - Modelagem Digital (aplicada no Blender)

## Definições sobre a interface do Blender

### Cena básica ou cena padrão da abertura do Blender

A cena padrão é formada por um cubo, pela câmera e uma fonte de luz

### Viewport ou Cena 3D ou Workspace

É basicamente é o contém a cena básica

# LMB, RMB

Left Mouse Button, Right Mouse Button

### Gizmo

As setas que apontam para os eixos X, Y e Z em cadas objeto são chamadas de Gizmo e podem mover não só os objetos, mas
também ser utilizao nas interações para com ele.

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

E também neste endereço é possível encontrar sua última versão feita para o Blender 2.6.
[Screencast Keys versão antiga](https://archive.blender.org/wiki/index.php/Extensions:2.6/Py/Scripts/3D_interaction/Screencast_Key_Status_Tool/)<br/>

Após a execução do script é possível encontrá-lo no menu de objetos.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/06_screencastkeys.png?raw=true "Timeline")

#### Botão Scroll do mouse em Operações de Visualização

Girando este botão é possível se distanciar e se aproximar da cena.

Clicando e segurando este botão é possível rotacionar a visão da cena, tanto movendo o mouse
para cima e pra baixo quanto para esquerda e direita.

Segurando a tecla Shift junto a e este botão é possível deslocar a vista do que está sendo
visto na cena 3D.

### Seleção de Objetos

No Blender a seleção de objetos é feita com o botão direito do mouse, diferente do que fazem
outros apps de modelagem.

### (Blender 2.7) Modo de visualizações da Cena e Atalhos

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/07_modosdevisualizacao.png?raw=true "Modos de Visualização")

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

### Edição de Objetos

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/13_edicaodeobjetos.png?raw=true "Edição de Objetos")

Caso precise alterar um face, os componentes do vértice ou edge é necessário alter para modo de edição de objetos ou pressionar a tecla TAB.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/14_edicaodeobjetosabrangente.png?raw=true "Edição de Objetos Funções")

Quando o objeto selecionado está em modo edição é possível utilizar os botões acima circulados que permitem selecionar múltiplos vértices,
selecionar múltiplos edges e múltiplas faces.

Para selecionar/remover múltiplos itens a tecla SHIFT deverá estar pressionada.

### Display/Shade methods

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/15_displayshademethods.png?raw=true "Display/Shade")

Durante o trabalho de edição de objetos por vezes é necessário alterar a visualização do objeto entre sem ou com preenchimento
(Wireframe e Solid) e isso é feito no menu Display/Shade.

### Translação e Escala

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/16_translacaoescala.png?raw=true "Translação e Escala")

Quando selecionado o objeto é possível trabalhar com translação e escala nos itens circulados acima.

### Exclusão de intervalo de vértices

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/17_exclusao.png?raw=true "Exclusão de Vértices em Intervalo")

Quando selecionado dado intervalo de objetos, ao pressionar a tecla X um menu se abrirá com várias opções referente a ação Delete e já na 1ª opção
"Vértices" sendo selecionada serão excluídos.

### Espelhamento de objetos

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/18_espelhamento_01.png?raw=true "Espelhamento de Objetos")

No menu mais à direita, onde podemos alterar os atributos de nossos objetos, existe uma opção representada por uma ferramenta, clicando nela e em
seguida em Add Modifier escolhemos a opção Mirror.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/18_espelhamento_02.png?raw=true "Espelhamento de Objetos (escolha do eixo)")

Nessa área o eixo (X, Y ou Z) utilizado para fazer o mirror (espelhamento) é baseado no pivô do objeto (indentificado no círculo vermelho à esquerda
na imagem acima).

Lembrando de que quando habilitado o Mirror, tudo o que é feito de um lado do objeto é replicado em seu lado simétrico, ou seu lado espelhado. Portanto
para que seja possível editar o objeto normalmente sem que ele seja afetado pela edição de seu lado espelhado basta clicar no botão Apply.

### Juntar Objetos (Object Join)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/19_objectjoin.png?raw=true "Object Join")

Quando existem mais de um objeto sendo trabalho no Blender é possível juntá-lo selecionando-os com a tecla SHIFT pressionada e em seguida
ir no menu Object > Join (ou utilizar o atalho CRTL + J).

### UV Image Editor

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/20_uv_imageeditor.png?raw=true "UV Image Editor")

Para escolher o UV Image Editor siga no Menu Principal > UV Image Editor.

### Remove Doubles (removendo vértices duplicados)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/21_removedoubles.png?raw=true "Remove Doubles (removendo vértices duplicados)")

Para remover vértices duplicados selecione todos os vértices do objeto com a tecla A, em seguida pressione a tecla Espaço e digite Remove Doubles ou apenas
selecione os vérices, pressione a tecla W e no menu que se abrirá selecione Remove Doubles.

### Projetar uma imagem UV 3D como é vista para uma 2D

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/22_projectfromview.png?raw=true "Projetar 3D em 2D (Project from view)")

Para projetar uma imagem 3D como é vista na tela para uma 2D basta após selecionados os vértices que deseja que seja transformado em 2D
no Image UV Editor ir em Mesh > UV Unwrap > Project from View. Nessa hora acontece um mapeamento e sempre que você alterar a visão do seu
objeto 3D basta em seguida pressionar a tecla U e no menu que se abrirá selecionar a opção Project from View para que seu modelo UV mapeado
também seja projetado como está no 3D. 
Lembrando que para interagir com o objeto em UV as teclas G, R e S funcionam como no objeto comum.

### Criar uma imagem do tipo UV Grid

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/23_imagem_uvgrid.png?raw=true "Imagem tipo UV Grid")

Para criar uma imagem do tipo UV Grid clique no botão New logo abaixo da área de imagem da área UV 3D exibida na figura acima, e na caixa
Generated Type clique em UV Grid.


### Utilizando um tipo de material que não sofra influência da luz (Shadeless)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/24_shadeless.png?raw=true "Shadeless")

Para trabalhar um material em cima de um objeto para que ele não sofra influência da luz, após clicar na opção Material (circulado de vermelho) devemos
marcar a opção Shadeless mais abaixo (com determinada área do objeto já pré selecionada).

### Juntando vértices manualmente

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/25_juntarvertices.png?raw=true "Juntando Vértices")

Para juntar vértices manualmente basta deixar a tecla B pressionada e ir arrastando o mouse com o botão esquerdo pressionado. A cada vértice selecionado
deve-se soltar o botão esquerdo para selecionar outro vértice. Ao final após todos os vértices selecionados como desejado pressione a tecla F que serão
criados novos vértices ligando os pontos selecionados.

### Preenchendo faces com vértices pré selecionados (ou menu Mesh | Face | Make Edge/Face)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/26_preencher_vertices_1.png?raw=true "Selecionando os Vértices")

Para criar um nova face primeiro é necessário selecionar determinados vértices que estão a sua volta.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/27_preencher_vertices_2.png?raw=true "Criando uma nova face")

E depois pressionar a tecla F.

### Dissolve Edges (Removendo linhas entre vértices)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/28_dissolve_edges.png?raw=true "Dissolve Edges")

Para remover uma linha entre vértices selecione a edge (linha), pressione a tecla X (ou Delete) e no menu Delete, escolha a opção Dissolve Edges.
Repare que na figura foram circulados 2 vértices que estão no meio da linha quase que imperceptíveis.

### Juntar Vértices (Merge - At Center)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/29_juntar_vertices.png?raw=true "Juntar Vértices")

Para juntar vértices selecione os que deverão ser juntados com as teclas Alt + M e no menu que se abrirá selecione o item At Center.

### Juntar Linhas (Bridge Edge Loops)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/30_bridge_edge_loops_1.png?raw=true "Selecionar Linhas")

Para juntar linhas selecione as que deverão ser juntadas a partir de seus vértices (usando a seleção de vértices normal com a tecla B e botão 
esquerdo do mouse) e pressionando a tecla Espaço digite Bridge Edge Loops, selecione a opção e clique com o mouse.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/31_bridge_edge_loops_2.png?raw=true "Linhas Selecionadas formando Faces")

Após o comando realizado a seleção ficará como a que está acima.

### Para duplicar objetos vá o menu Object > Duplicate Objects.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/32_duplicate_objects.png?raw=true "Duplicar Objetos")

### Para duplicar vértices de um mesh selecione os vértices a serem duplicados, vá em Mesh > Add Duplicate

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/33_duplicate_mesh.png?raw=true "Add Duplicate")

Ou pressine as teclas SHIFT + D após os vértices terem sido selecionados.

### Background Image

Para adicionar uma imagem de background no painel Properties deve-se marcar a opção Background Images
e em seguida clicar em Add image.

### Add Loops

Para adicionar mais polígonos a seu objeto 3D é necessário ir em Mesh > Edges > Edges Loops.
(após criado o 1º loop utiliza-se o botão Scroll do mouse para aumentar o número de polígonos).

### (Blender 2.8) Modo de visualizações da Cena e Atalhos 

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/_CZDOSUL/_BLENDER/_MEDIA/_BLENDER_2_8/01_modosdevisualizacao_b28.png?raw=true "Modos de Visualização no Blender 2.8")

No menu View é exibido qual o modo de visualização (User Perpective, etc).

No menu View -> Viewpoint é possível escolher quais modos de visualização podem ser utilizados (Cameras, Left, Right, Back,
Front, Bottom, Camera). Também é possível alterar estes modos de visualização pelo teclado númérico ou com
as teclas dele sendo utilizadas em conjunto com a tecla Crtl).

Ainda no menu View existe um item em que permite visualizar a cena por Perpectiva ou Orthogonal.

### Teclas de atalho

O software detecta as teclas de atalho a partir de onde se encontra o cursor do mouse
e abaixo descreveremos algumas dessas combinações de tecla.

- (Blender 2.7) Edição de objetos: selecione o objeto e pressione a tecla TAB;

- (Blender 2.7) Para selecionar/remover múltiplos itens a tecla SHIFT deverá estar pressionada.

- (Blender 2.7) Para selecionar/remover todos os vértices, edges, etc de um objeto pressiona-se a tecla A.

- (Blender 2.7) Com o objeto selecionado e pressionando a tecla G (gravity) é possível movimentar o objeto sobre
a área de trabalho (cena 3D) e confirmar a nova posição com o botão esquerdo do mouse.
Também é possível determinar em que eixo deseja-se que seja feita essa movimentação e para isso
basta pressionar as teclas X, Y ou Z após ter pressionado a tecla G. E logo após ter feito essa
definição de andar pelos eixos também é possível digitar um valor númerico específico definindo
quanto o objeto deve ser deslocado.

- (Blender 2.7) Com o objeto selecionado e pressionando a tecla R (rotation) é possível rotacionar o objeto sobre
a área de trabalho (cena 3D) e confirmar a nova posição com o botão esquerdo do mouse.
Também é possível determinar em que eixo deseja-se que seja feita essa movimentação e para isso
basta pressionar as teclas X, Y ou Z após ter pressionado a tecla R. E logo após ter feito essa
definição de andar pelos eixos também é possível digitar um valor númerico específico definindo
quanto o objeto deve ser deslocado.

- (Blender 2.7) Com o objeto selecionado e pressionando a tecla S (scale) é possível alterar a escala do objeto sobre
a área de trabalho (cena 3D) e confirmar a nova posição com o botão esquerdo do mouse.
Também é possível determinar em que eixo deseja-se que seja feita essa movimentação e para isso
basta pressionar as teclas X, Y ou Z após ter pressionado a tecla S. E logo após ter feito essa
definição de andar pelos eixos também é possível digitar um valor númerico específico definindo
quanto o objeto deve ser deslocado.

- (Blender 2.7) Para adicionar/remover propriedades do objeto(properties) pressiona-se a tecla N.

- (Blender 2.7) Para adicionar mais polígonos (edge loops) a seu objeto 3D pressiona-se Crtl + R
(após criado o 1º loop utiliza-se o botão Scroll do mouse para aumentar o número de polígonos).

- (Blender 2.7) Para selecionar polígonos de todas as profundidades basta pressionar o botão B, clicar com
o botão esquerdo do mouse a arrastá-lo até a seleção desejada, em seguida pressionar o botão
G para poder com o mouse movimentar livremente a seleção, clicar com o botão esquerdo do mouse
para confirmar o ponto desejado que deverá ficar os vértices selecionados e para finalizar pressionar
o botão A para deselecionar todos os vértices do objeto.

- (Blender 2.7) Para deselecionar vértices devemos deixar pressionado o botão B e com o botão do meio do mouse
arrastar pressionando na área selecionada que deseja deselecionar e em seguida soltar para que a 
deseleção aconteça. Lembrando que para que essa deseleção aconteça com sucesso é importante que 
ao fazer a marcação da área selecionada o "arraste" do mouse deve ser feito dentro da área que 
os vértices estão contidos sem esbarrar com a área esterna (o que pode fazer com que a deseleção não
ocorra como esperado).

- (Blender 2.7) Para aplicar uma escala em determinado eixo (x, y, z) pressione o botão S, deixe-o apertado
e clicando, segurando e arrastando o mouse com o botão scroll também pressionado no
eixo desejado do objeto é possível aplicar uma escala.

- (Blender 2.7) Para selecionar vértices conectados em loop deve-se sergurar a tecla Alt e pressionar o botão direito
do mouse onde deseja que essa seleção seja feita. Para adicionar mais vértices conectados em loop 
deve-se manter pressionadas as teclas Alt + Shif e pressionar o botão direito do mouse onde 
deseja que essa seleção seja feita.

- (Blender 2.7) Para excluir um determinado intervalo de vértices, após selecionado dado intervalo de objetos, 
deve-se pressionar a tecla X para que um menu se abra com várias opções referente a ação Delete 
e já na 1ª opção "Vértices" sendo selecionada serão excluídos.

- (Blender 2.7) Para adicionar outro objeto preferencialmente devemes colocar a cena em Object Mode, em seguida
seguir no menu Add > Mesh e o objeto de preferência.

- (Blender 2.7) Para utilizar uma extrusão (extrude) deve-se selecionar um grupo de vértices e pressionar a tecla E e 
logo em seguida utilizar o mouse para a direção desejada.

- (Blender 2.7) Para realizar uma união entre dois ou mais objetos, com a tecla SHIFT pressionada deve-se em seguida
ir no menu Object > Join (ou utilizar o atalho CRTL + J).

- (Blender 2.7) Para selecionar o um objeto após ter utilizado o comando Join pressione a tecla L e passe o mouse por
cima de onde ele se encontra.

- (Blender 2.7) Para juntar vértices manualmente basta deixar a tecla B pressionada e ir arrastando o mouse com o botão 
esquerdo pressionado. A cada vértice selecionado deve-se soltar o botão esquerdo para selecionar outro vértice. 
Ao final após todos os vértices selecionados como desejado pressione a tecla F que serão criados novos vértices 
ligando os pontos selecionados. 

- (Blender 2.7) Para deselecionar vértices manualmente basta deixar a tecla B pressionada e ir arrastando o mouse com o botão 
do meio pressionado. A cada vértice selecionado deve-se soltar o botão do meio para deselecionar outro vértice. 

- (Blender 2.7) Para caso o resultado do Mirror esteja errado, é possível que o pivô (centro de rotação) do
objeto esteja fora do (0, 0, 0). Para arrumar, no modo Object e com o cursor do mouse em
cima da viewport: SHIFT + S | Cursor to Center (menu Object | Snap | Cursor to Center da
viewport). Em seguida, SHIFT + CTRL + ALT + C | Originto 3D Cursor (ou menu Object |
Transform | Originto 3D Cursor na viewport).

- (Blender 2.7) Para alinhar determinados vértices no eixo X = 0, alinhe os novos vértices em X=0 (
aplique escala X=0 com a sequência S, X, 0, Enter, e depois defina X=0 na Properties da viewport

- (Blender 2.7) Para criar faces preenchidas selecione os que estão a seu redor e pressione a tecla F.

- (Blender 2.7) Para adicionar cortes as faces pressione a tecla K e com botão esquerdo do mouse vá selecionando onde
eles serão fetos e para confirmar pressione a tecla Enter.

- (Blender 2.7) Para alterar o tipo de visão de cada objeto pressiona-se Z.