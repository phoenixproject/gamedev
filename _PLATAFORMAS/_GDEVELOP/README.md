# czdosul
CST em Jogos Digitais

# GDevelop Demo


01 - Todo o jogo composto pela GDevelop é composto por cenas. Então a tela inicial, o menu,
os níveis são cenas.

02 - Para Inserir um background.

Cada instância na cena tem uma propriedade que é chamada ordem z. É um número e objetos com uma ordem Z maior serão exibidos na frente de objetos com uma ordem Z menor. A ordem Z pode ser qualquer número e também pode ser negativa.

Aqui, você pode alterar a ordem Z de arbustos e nuvens para configurá-los como negativos, para que o caractere do jogador (com uma ordem Z que deve ser 1) seja exibido na frente deles. Para fazer isso, selecione as instâncias na cena. Você pode continuar pressionando SHIFT no teclado para selecionar mais de um objeto:

03 - Quando for guardar os tiles para não se perder pode ser utilizado um arquivo chamado tileset que contém todos os tiles separados por por exemplo o tamanho de cada quadrado com cada imagem. Pode ser que cada tile, cada bloco tenha 128 x 128 pixels ou 64 x 64 pixels e assim por diante.

04 - Tilemap é o meu cenário completo com tiles.

05 - A HUD (do inglês: heads-up display - tela de alerta) é a sigla para representação dos objetos do jogo, tais como: vida (às vezes representado por life - do inglês vida, force - do inglês força), magia (às vezes representados por: mana - ou MP, Mana Points -).