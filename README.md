# czdosul
CST em Jogos Digitais

# dankicode
Curso de Desenvolvimento de Games

# son
School of Net

# udemy
Curso(s) de Desenvolvimento de Games

##### Dicionário Conceitual de Termos Básicos ou Conceitos Técnicos para Desenvolvedores de Games:

### Game Loop

Ao contrário de aplicações comuns em todo o game existe um loop principal. E como um 
jogo possui códigos de programação e gráficos ao mesmo tempo é preciso trabalhar com
threads porque em diversos momentos ambos precisam funcionar ao mesmo tempo.

### Renderizar

É basicamente desenhar na tela o gráfico do jogo ou mostrar os gráficos na tela.

### FPS (Frames por segundo)

É o intervalo de frames exibidos na tela.

### Runnable

Interface padrão do Java que implementa o uso de threads.

### Synchronized

Método do Java para seja executado de forma sincronizado.

### Spritesheet

É uma imagem que tem todas as imagens (ou sprites) do game (lembra o Tile Map).

### Sprite

É uma parte de um Spritesheet e geralmente é definido em pixel. Exemplo: 16 x 16, 
12 x 12 pixels, etc.

### Game Desing

### Tile Map

### Tile Set

### GDD

## Estrutura básica de Unity

### Assets (Recursos)

É tudo que você pode importar para o seu jogo (sons, imagens, etc). Quando se está programando games em Java esse
diretório costuma ser chamado de res.

### Hierarchy 

É a área que exibe todos os objetos contidos na cena. 
Os objetos podem ser selecionados tanto clicando neles na cena quanto clicando em projects.

### Game Object

É o menu que dá a opção de criação de vários tipos de objetos. Desde luz até objetos 3d, inclusive
objetos vazios sem padrão.
Tudo contido numa cena da Unity é objeto e todos os objetos estão sujeitos a serem manipulados
nos sentidos X, Y, Z e terem suas posições e tamanhos(escala) alterados nesses eixos.

### Objeto Câmera

É responsável por mostrar a cena que está acontecendo. Ele é responsável por pegar tudo o 
que está de frente da tela e mostrar para a cara do jogador.
E as linhas que saem de frente dela é a área que delimita esse campo de visão. 

### Lights (Iluminação)

A Direction Light funciona como se fosse um sol apontado para a face do jogador.
A Direction Light é mais usada quando você quer criar um jogo de mundo aberto.
A Point Light funciona mais como a luz de sua casa, sua sala de estar, seu quarto.
A SpotLight (holofote) funciona para quando se quer criar um farol de carro, lanterna, etc.

### Para aproximar-se de um objeto

Selecione este objeto e pressione f. A partir daí o foco será sempre sobre ele.

### Material

Quando você cria um Material ele te dá opções de alterar sua cor e textura, dureza,
se ele é metálico e aplicá-lo sobre um objeto.
Basicamente as texturas entram dentro desses Materiais que serão aplicados a objetos.
Quando se obtém algum textura de algum lugar (Google por exemplo), basta importá-la
para dentro de sua zona de Assets e arrastá-la para dentro da propriedade Albedo 
de dentro do Material que você quer que obtenha esta textura.	

### Os 3 pilares das Unity são:

Cenas > Objetos > Componentes. E eles praticamente seguem essa hieraquia de um estar
dentro do outro. Componente estaria dentro de Objeto que por consequência está dentro
da Cena.

### Componentes (encontrados na aba Inspector quando um objeto é selecionado)

Todo o objeto é formados por componentes. Componentes esses que são responsáveis pelo comportamento
dos objetos. Quando selecionado o objeto estes componentes podem ser visualizados, alterados
seus comportamentos, inseridos novos componentes, inativados ou excluídos.
Os componentes são praticamente os atributos do objetos, mas que além de serem simples atributos
também possuem comportamentos distintos e isso quer dizer que teríamos a relação entre Objeto e 
Componentes é como um objeto que possui vários objetos atrelados a ele como atributos.

### Prefab

Quando você precisa criar vários objetos iguais e necessita de alterar em seguida algum comportamento
entre eles, que seja sua altura por exemplo, ao invés de alterar um a um manualmente, seleciona-se 
dentro da aba Hierarchy o objeto que deseja servir de modelo e o arrasta para dentro de um dos
diretórios que estão dentro da pasta Assets na aba Project. Ao fazer isso ele se torna um Prefab
e a partir disso ele poderá ser replicado em números infintos de objetos e qualquer alteração que 
for feita em um será replicada para todos os outros.

### Rigibody

Todos os objetos  na Unity são estáticos por si só. Eles não interagem uns com os outros.
E para que essa interação aconteça ao selecionar um objeto, na aba Inspector adicionamos
um componente de nome Rigibody. Esse componente é reponsável por dar vida ao objeto tornando-o
interativo. E a partir desse momento o objeto começa reagir a física, começa a se movimentar, etc.

### Colisor

Cada objeto tem uma propriedade (componente) que diz respeito a um colisor. E o nome colisor
diz respeito a uma propriedade que identifica e trata a colisão entre um objeto e outro.
Por exemplo: se entre dois objetos que irão se colidir (um chão e uma esfera) um deles tiver desmarcado
o seu componente de colisão na aba Inpector (desmarcado diga-se inativo), eles não irão colidir
um com o outro e irão passar por dentro um do outro. Lembrando que para que isso aconteça basta
que entre eles apenas um esteja com seu componente de colisão desmarcado.
Cada objeto tem seu tipo de componente que trata a colisão. Uma superfície plana por exemplo
tem um componente chamado Mesh Collider, já uma esfera tem um Sphere Collider, mas todos 
tratam a mesma coisa.
Outra coisa a respeito é quando você adiciona um objeto externo a Unity que não tem colisor
em seus componentes, basta ao adicionar um novo componente a ele (na aba Inspector) procurar
pelo termo collider.

### Texturas

 - Metal texture
 
##### Ferramentas (tools)

### Paint.net