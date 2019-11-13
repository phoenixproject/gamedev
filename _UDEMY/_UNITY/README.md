###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>

## Projeto Space Shoot - Projeto 2D

### Layout utilizado na Unity

Window > Layout > 2 by 3


### Aspecto pixelado

Para dar um aspecto pixelado ao bitmap importado como asset,
dentro de **Import Settings** (exibido no __Inspector__ ao selecionarmos
um objeto) podemos alterar o valor do atributo **Pixels Per Unit** para
**48**, em **Filter Mode** colocamos o valor **Point (no filter)** e dentro
da área **Defaut** alteramos o valor **Max Size** para **64** e em 
**Compression** deixamaremos o valor como **None**.

### Criando um objeto para receber um sprite

Para criarmos um objeto que nos permita utilizá-lo na cena ( __Scene__ ) como
sprite 2d devemos seguir no menu  __Game__ __Object__ > __2D__ __Object__ > __Sprite__ . 

### Rigidbody 2D

Todos os objetos na Unity são estáticos por si só. Eles não interagem uns com os outros.
E para que essa interação aconteça ao selecionar um objeto, na aba Inspector adicionamos
um componente de nome Rigibody. Esse componente é reponsável por dar vida ao objeto tornando-o
interativo. E a partir desse momento o objeto começa reagir a física, começa a se movimentar, etc.
Ele basicamente aplica os efeitos de físicas que temos na vida real para o objeto, fazendo inclusive
que outros objetos passem a colidir (ter efeitos de colisão) com estes objetos que possuam a
propriedade Rigibody. Em suma, Rigibody é um component que adiciona propriedades físicas ao objeto.
E exclusivamente quando utilizarmos objetos 2D devemos utilizar o componente __Rigidbody__ __2D__ 
e não apenas o __Rigidbody__ que é utilizado em objetos **3D**.

### Gravidade

Dentro do componente __Rigidbody__ __2D__ logo de início quando temos um __Game__ __Object__ do tipo
__Sprite__ adicionado é recomendável alterar o valor do atributo **Gravity** **Scale** para **0**
porque como o componente contém toda a física do objeto ao pressionar o botão Play da Unity o mesmo
já inicia caindo no cenário.
