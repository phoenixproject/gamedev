###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>

# SON / HGDEV / CZDOSUL
School of Net / Heartbeast / Projeto 2D

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

### Filesystem

- Quando são importados assets ou demais arquivos eles podem ser inseridos no diretório que automaticamente são exibidos na árvore à esquerda.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/04_godot_filesystem_location_explorer.png?raw=true "Filesystem Explorer")

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

### Para selecionar objeto junto com os filhos

- Para selecionar e arrastar um objeto junto de seus filhos basta marcar a opção abaixo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__MEDIA/__GODOT/09_godot_select_objeto_junto_com_filhos.png?raw=true "Select the object")

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


