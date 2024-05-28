###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>

# SON / HGDEV / CZDOSUL / UDEMY
School of Net / Heartbeast / Projeto 2D

# Série Godot - Estudo

##### [01 - Overview of Godot's key concepts](https://docs.godotengine.org/en/stable/getting_started/introduction/key_concepts_overview.html)<br/>

### Algumas conclusões/entendimentos importantes sobre a Godot

- **Objetos (Nodes, Cenas, etc):** na Godot os Nodes podem ser entendidos como objetos que possuem atributos com valores pré definidos capazes de serem alterados junto a seus comportamentos (métodos) que ao todo (atributos e métodos) definem a caracterítica de determinado Nó (Node, Cena, etc). O nome objeto é de meu entendimento (pessoal) conceitual porque um Nó (Node, Cena, etc) consegue ser criado isoladamente e reaproveitado em outro Nó como atributo, assumindo a regra de orientação a objetos. Alguns entendem que tudo na Godot é uma Cena, mas o conceito do que é uma cena também pode ser entedido como um nó, pois dentro de uma Cena há vários nós que possuem características e comportamentos similares.
- O node é a peça fundamental para a construção de qualquer jogo na Godot e cada Node tem as suas própias características e funcionalidades únicas. 
- Um conjunto de Node pode formar uma Scene/Cena.
- As Scenes/Cenas são salvas com extensão .tscn.
- Observar o Editor Settings porque nele são guardadas configurações importantes como cena de arranque da aplicação, escala de visualização do editor (para diferentes telas, uso de editor de script ao clicar, entre outras configurações importantes iniciais.

### Viewport

É a área de trabalho da Godot, é onde será visualizado seu jogo (fases, menus, cenas, etc).

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/01_godot_viewport.png?raw=true "Viewport")

### 2D ou 3D

- Na Godot, diferente da Unity nós não escolhemos um estilo de jogo 2D ou 3D. Você
pode mudar essas perspectiva a todo momento.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/02_godot_mudanca_ambiente.png?raw=true "Perspectiva")

### Espaço de Trabalho 2D

- O espaço de trabalho 2D está dentro do quadrado azul circulado e é nele que o jogo será produzido.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/03_godot_espaco_trabalho_2d.png?raw=true "Espaço de trabalho 2D")

E tudo o que está contido dentro dele será exibido ao lado direito na área Node.

### Características do plano cartesiano

- O plano cartesiano da Godot define que o objeto posto em cima dele obtém valores positivos se for para baixo do eixo X e negativos para acima do eixo X.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/INTRODUCAOGODOT/01_plano_cartesiano.PNG?raw=true "Características do Plano Cartesiano da Godot")

Esse comportamento é também indicado para as laterais do eixo Y como indicado na foto.

### Filesystem

- Quando são importados assets ou demais arquivos eles podem ser inseridos no diretório que automaticamente são exibidos na árvore à esquerda.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/04_godot_filesystem_location_explorer.png?raw=true "Filesystem Explorer")

### Caminho dos arquivos estáticos

- Na Godot, o termo "res://" pode ser entendido a como se fosse a raiz do projeto, ou seja, poderia ser entendido (a grosso modo) como o "C:" do Windows ou o "\" no Linux. E na foto podemos visualizar que **res://Scripts/** faz referência a pasta chamada **Scripts** que está na raiz do projeto.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/INTRODUCAOGODOT/02_caminho_dos_arquivos_estaticos.PNG?raw=true "Caminho dos arquivos estáticos")

### Auto Play on Load

- Quando deseja-se que uma animação inicie-se junto a instância da Godot basta deixar marcado a opção Autoplay on Load.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/05_godot_autoplay_on_load.png?raw=true "Auto Play")

### Layout (background 2D)

- Caso precise escolher um layout adequado para que uma elemento se adapte a ele, defina-o como na figura abaixo. O objeto do tipo
ColorRect pode ser utilizado para dar cor a algo que podemos usar como background.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/06_godot_layout_escolha.png?raw=true "Layout")

### Lock Node

- Para um Node não possa mais ser movimentado basta selecioná-lo e pressionar o cadeado na ferramenta.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/07_godot_lock_node.png?raw=true "Lock Node")

### Bitmap to 2D pixel (aspecto pixelado)

- É possível definir um bitmap como um 2D pixel, ou seja, com aspecto pixelado. Apenas selecionando o bitmap que deseja aplicar o efeito e clicando na aba **Import** > **Preset** efeito em seguida na opção **2D Pixel**. Também é possível colocar este efeito como padrão marcando a opção **Set as Default for Texture**.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/07_godot_lock_node.png?raw=true "Lock Node")

### Para deixar a imagem com aspecto pixelado

- 1º - Devemos selecionar a imagem que desejamos;
- 2º - Em __Preset__ escolhemos o valor *2D_ _Pixel* e em seguida no botão _Reimport_ para reimportar o bitmap já com suas novas cofigurações;
- 3º - E por fim ainda em __Preset__ marcamos *Set as Default for 'Texture'* para o próximo bitmap já venha com esta configuração.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/10_godot_bitmap_com_aspecto_pixelado.PNG?raw=true "Imagem com aspecto Pixelado")

### Para selecionar objeto junto com os filhos

- Para selecionar e arrastar um objeto junto de seus filhos basta marcar a opção abaixo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/09_godot_select_objeto_junto_com_filhos.png?raw=true "Select the object")

### Para movimentar o objeto filho a partir do pai estar selecionado

- Para movimentar um objeto filho contido no pai, sem que este pai tenha alteração de características, clique no botão __Move Node__ e movimento o filho de uma forma que só altere as características dele.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/INTRODUCAOGODOT/03_movendo_objeto_filho_a_partir_do_pai.PNG?raw=true "Movimentando um objeto filho a partir do pai")

### Para alterar o tamanho da Window onde acontecerá o jogo

- Siga em *Project > Project Settins > General > Property > Display >  Window* e altere os valores desejados.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/11_godot_window_resize.PNG?raw=true "Select the object")

- Para *mobile games* nesta mesma área é possível alterar outras informações que são adequadas para telas de smartphones e tables como por exemplo:
  - Na coluna à esquerda em __Display__ > _Window_, em __Size__, alterar _Width_ para 480 e _Height_ para 854;
  - Ainda na mesa área _Property_, um pouco mais abaixo, em __Handeld__ > _Orientation_ marcar _portrait_ (importante para aqueles que querem desenvolver o jogo para um aparelho de smartphone que rode em formato paisagem;
  - Um pouco adiante em __Stretch__ > _Aspect_ marcar _keep_;
  - Na coluna à esquerda, em __Rendering__ > __2d__ > *Use Pixel Snap* e marcar _On_ (é bom marcar para jogos que exibem arte em Pixel);
  - E por fim ainda na coluna à esquerda, em **Input Devices** > _Pointing_ > *Emulate Touch From Mouse* marcar _On_.
  
### Para adicionar um background em um componente Sprite

Para adicionar um image/background num componente do tipo __Sprite__ é preciso:

1º - Criar o componente do tipo __Sprite__:

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/12_godot_criando_sprite_para_background.png?raw=true "Componente Sprite")

2º - Arraste seu bitmap para a área vazia do __Sprite__;

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/13_godot_adicionando_bitmap_ao_componente_sprite.png?raw=true "Adicionando componente ao Sprite")

3º - Desligue o modo Centralizado do componente __Sprite__ para que o background permaneça posicionado dentro da área limitada na propriedade __Display__ em *Project Settings*.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/14_godot_desligando_centerede_para_background_ficar_centralizado.png?raw=true "Centralizando o background no Display")

### Para manter a proporção do sprite quando a resolução mudar

Para manter a proporação de um sprite quando a resolução da tela que possui o jogo for alterada basta seguir em Projeto > Configurações do Projeto >  Display > Window em __Strech__ maraca em *Mode* o valor *2D* e em *Aspect* marcar *keep* que é responsável por fazer os ajustes da resolução se o tamanho da tela for aumentado (por exemplo).

Atributo __Aspect__:

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/15_godot_mantendo_proporcao_quando_resolucao_muda.png?raw=true "Aspect: keep")

### Para movimentar os eixos no plano cartesiano

- Para movimentar o eixo das abscissas (X) para cima ou para baixo, mantenha pressionada a tecla (do teclado) __Ctrl__ e gire com o botão __Scroll__ (do mouse) para cima ou para baixo.

- Para movimentar o eixo das coordenadas (Y) para a esquerda ou para a direita, mantenha pressionadas as teclas (do teclado) __Ctrl__ e __Shift__ e gire com o botão __Scroll__ (do mouse) para cima ou para baixo.

- Para movimentar o centro do eixo das coordenadas (Y) e abscissas para qualquer, mantenha pressionado o botão __Scroll__ (do mouse) e arraste o mouse para qualquer lado.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/_UDEMY/INTRODUCAOGODOT/01_plano_cartesiano.PNG?raw=true "Características do Plano Cartesiano da Godot")

Esse comportamento também se aplica para o ambiente 2D ou para o 3D.

### Boas práticas

Quando for criar personagens, cenas e etc, crie diretórios com seus respectivos nomes.

### Script

A aba de Script é onde escrevemos nossos códigos na Godot.

### GDScript - onready

```python
	var variable_name : type = value
	// ou seja:
	var nome_da_variavel : tipo_da_variavel = valor
```


```python
	// onready funciona na Godot como uma espécie de await,
	// ou seja, que aguarda a instância de fato acontecer 
	// para armazená-la na variável
	onready var animationPlayer = get_node("AnimationPlayer")
```


