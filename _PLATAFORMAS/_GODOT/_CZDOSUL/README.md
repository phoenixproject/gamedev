###### [Sintaxe básica de escrita e formatação no GitHub](https://help.github.com/pt/github/writing-on-github/basic-writing-and-formatting-syntax)<br/>
###### [Canal com conteúdos da Godot](https://www.youtube.com/channel/UCxboW7x0jZqFdvMdCFKTMsQ)<br/>

# PROJETO de Game 2D (Sugerido) - Proposta e arquivos para o projeto (sugestão do professor conteudista)

#### O gênero, a princípio da atividade, é um jogo de plataforma 2D:

Vocês podem optar por seguir a sugestão do professor conteudista seguindo cada etapa lá mostrada ou vocês poderão desenvolver um jogo de qualquer gênero 2D;
Caso optem por escolher outro gênero eu estarei adaptando os critérios de avaliação do projeto para o gênero do seu jogo;

## Atividade tem início no dia 01/10/2021 à 00:00 A.M (BRT).
## O prazo final para o envio é até o dia 12/11/2021 até às 23:59 P.M. (BRT).


# Conteúdos das Unidades

-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**

### ETAPA 1

### Unidade 2 – Artefatos e manipulação de elementos em jogos 2d

Prof. Me. Rafael Martins

### Projeto – 1ª Parte

Como atividade desta Unidade, o aluno deverá entregar a primeira parte do projeto da disciplina, contendo os elementos descritos nos passos abaixo e seus respectivos guias. O resultado final deve apresentar a cena de jogo relacionadas com os artefatos vistos na Unidade 2.

O projeto é um 2D Platformer, estilo encontrado em todas as plataformas de desenvolvimento. Nosso personagem principal é um robô, assim como seus inimigos e chefe final. Aplicaremos técnicas como parallax, física, animações, transições e HUD como projeto final da Unidade.

#### Requerimentos

- Unity3d - https://unity3d.com/pt/get-unity/download

- Visual Studio Code - https://code.visualstudio.com/

- Arquivo ZIP – Materiais da Unidade (Clique para fazer Download)

#### Arquivos de arte (Sprites) e arquivos de áudio

*O uso do material de arte está autorizado apenas para a disciplina. É expressamente proibida a utilização comercial deste material.

#### 1 - Criação do projeto

- Criar projeto 2d (qualquer nome ou terminologia)

- Copie a pasta Resources (Materiais da Unidade), Prefabs, Scripts, Animations e Materials para dentro da pasta Assets

#### 2 - Configuração inicial

No menu Player Settings, definir os seguinte atributos:

- Definir Company Name como nome  (ex.: Rafael Martins);

- Definir Product Name: Qualquer nome de preferência;

- Definir Bundle Identifier como com.jogo2d.nome (ex: com.jogo2d.rafaelmartins).

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/01.png?raw=true)

#### 3 - Scenes

- Criar duas cenas: Menu e Main

    Menu: Cena será para controle do fluxo de jogo.
    Main: Cena para o jogo (Gameplay).
	
![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/02.png?raw=true)

(De preferência, criar os arquivos dentro de uma pasta Scenes (manter coerência para Scripts, Materiais, Resources etc.)

#### 4 - Cenário e Parallax

Na cena MAIN, criaremos uma tela de fundo com efeito de parallax, para simular uma aeronave em constante movimento.

Passos:

- 4.1 - Crie um GameObject do tipo QUAD e nomeie para Background;
- 4.2-  Arraste a imagem background para dentro do QUAD (caso a imagem esteja definida como Sprite, altera para Default na aba Inspector;
- 4.3 - Adicione o script BackgroundController no objeto Background;
- 4.4 - Defina a velocidade como 0.01;
- 4.5  - Crie um objeto Light -> Direction Light para adicionar iluminação;
- 4.6 – Utilize o Control + D para replicar os objetos Background e posicione um ao lado do outro para expandir o cenário (crie um GameObject vazio Backgrounds e adicione os objetos de cenário para organizar em um grupo);
- 4.7 – Clique em PLAY para rodar o jogo e ver o efeito.

Os blocos formam a plataforma para que o Player se desloque pelo cenário. Cada grupo de blocos contém um componente BoxCollider2D para colisão com o Player.

Passos:
- 4.8 – Arraste os prefabs Platform (1 ao 7) para a cena;
- 4.9 – Posicione de acordo com sua preferência para montar o cenário da fase 1;
- 4.10 – Certifique-se que todo Tile dentro do prefab possui um componente BoxCollider2d;

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/03.png?raw=true)

#### 5 - Personagem (Sprite / animações)

O MECA é o personagem do jogo do projeto e está dentro de um prefab pronto. Para compreender o prefab, criar um novo ou fazer suas próprias alterações, deve-se realizar o checklist.

Passos:

- 5.1 – Arraste o prefab Player para a cena;
- 5.2 – Posicione o objeto Player em cima da plataforma;
- 5.3 – O Player deve possuir:
  - 5.3.1 - BoxCollider2D para colisão com a plataforma;
  - 5.3.2 – CircleCollider2D para colisão com o pé na plataforma;
  - 5.3.3 – Rigibody2D para operações com física;
  - 5.3.4 – SpriteRenderer: imagem inicial;
  - 5.3.5 – Animator para controle das animações;
  - 5.3.6 – Meca.cs : Script para controle do Player.

Para adicionar novas animações ao Player, basta arrastar as imagens (Frames) ao objeto Player na cena. O menu de contexto de animações da Unity (Window -> Animator) abrirá para inserção da nova animação na pasta de recursos. O objeto de animações (Animator) deve conter o seguinte fluxo:

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/04.png?raw=true)

- As animações presentes no Player são:

  - IDLE = animação de repouso;
  - WALK = animação de andar;
  - ATTACK = animação de ataque;
  - JUMP = animação de pulo;
  - SHOOT = animação de tiro.

- Os frames de animação estão localizados na pasta Assets/Resources/Player.

- As animações no projeto da Unidade não utilizam Keys ou Layers para chamada de animação (apenas as chamadas programáticas via código-fonte).

Resultado Final 

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/05.png?raw=true)

-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**

## ETAPA 2

### Unidade 3 – Programação, HUD, Controles e Compilação

Prof. Me. Rafael Martins

### Projeto – 2ª Parte

Como atividade desta Unidade, o aluno deverá entregar a segunda parte do projeto da disciplina, contendo os elementos descritos nos passos abaixo e seus respectivos guias. O resultado final deve apresentar a cena de jogo relacionadas com os artefatos vistos na Unidade 3.

*O uso do material de arte está autorizado apenas para a disciplina. É expressamente proibida a utilização comercial deste material.

#### 1 - Integração e entendimento de scripts

Os scripts possuem a implementação para as entidades básicas do projeto. Cabe ao aluno fazer modificações ou reescrever os scripts conforme sua necessidade.

#### Script	

Funcionalidade

BackgroundScroller.cs
	
#### Efeito de parallax no cenário

Boss.cs	

#### Controle do inimigo Boss

BossShot.cs	

#### Controle do efeito de tiro do Boss

Bullet.cs	

#### Controle da bala (colisão)

CameraController.cs
	

#### Atualiza a câmera baseado na posição do Player

Exit.cs
	

#### Controla a colisão do Player com o ponto de saída para atualizar o fluxo do jogo

GameManager.cs	

#### Gerencia eventos do jogo

HealthBar.cs	

#### Controla a barra de vida do Player

Item.cs	

#### Controla o ciclo de vida dos itens

Meca.cs	

#### Script do Player

ScoreManager.cs	

#### Gerenciamento de pontuação

Na unidade anterior, os GameObjects relacionados aos backgrounds já tiveram os scripts associados, assim como as plataformas.

Adicionar o script Meca no GameObject Player. Entendendo e modificando os métodos/atributos do objeto Player:

- speed = velocidade do player
- jumpForce = controla a força do pulo
- direction = -1 = esquerda, 1 = direita
- isGrounded = verifica se o Player está em cima de uma plataforma
- bullet = prefab de instância da bala
- exit = saída da fase
- exitScript = classe de controle do fim do level
- rb = referência para Rigibody2d (controle de física)
- animator = referência para componente Animator do Player

- método Flip() = muda o Player de direção (depois do toque nos direcionais)
- método Shoot() = Instância um prefab Bullet
- FadeAndExit() = executa uma coroutine para o Player sumir após colidir com a porta de saída

#### 2 - Heads-Up Display

O HUD está contido dentro do prefab Canvas segmentado em GameObjects para controle do jogo. Adicione o prefab Canvas na cena.

- Score: campo de texto para placar
- PauseButton: botão para pausar/resumir o jogo
- SoundButton: botão para ativar/desligar o som
- WinPanel: painel com informação de vitória
- GameOverPanel: painel com informação de derrota
- Lifebar: componente de vida
- 2 Ways DPad Horizontal: Componente para controle na tela (mobile)
- Shoot: botão para atirar (A, mobile)
- Jump: botão para pular (B, mobile)

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/06.png?raw=true)

#### 3 - Controles

Para os controles do Player, implementa-se uma rotina no método Update() (Meca.cs)
Mapeamento das teclas:
- Espaço = Pula
- E = atira
- V = ataca
- X = atira

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/07.png?raw=true)

Como exercício, implemente a mesma funcionalidade, mas utilize funções de toque para dispositivos móveis.

#### 4 - Compilação

Para Desktop (PC/Mac):

    Acessar o menu File, Build Settings e depois clicar em Build and Run

#### Para Android:

    Clicar na plataforma Android e depois em Switch Platform
    Instalação do Android SDK
    Instalação do Android NDK
    Ter um aparelho em mãos plugado com o ADB ativado (Developer Mode)
    Alterar configurações (se necessário)
    Build and Run

#### Para iOS:

    Clicar na plataforma iOS e depois em Switch Platform
    Build
    Abrir a pasta onde o projeto foi compilado e executar o arquivo do projeto (.xcworkspace) para abrir o ambiente XCode
    Clicar em Run no Xcode (com um aparelho ligado no Mac)
	
	![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/08.png?raw=true)

-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**-****---**

## ETAPA 3

### Unidade 4 – Projeto de Jogo 2d

Prof. Me. Rafael Martins

### Projeto – 3ª Parte

Como atividade desta Unidade 4, o aluno deverá entregar a terceira e última parte do projeto da disciplina, contendo os elementos descritos nos passos abaixo e seus respectivos guias. O resultado final deve apresentar o jogo completo e as atividades extras com proposta neste documento.

- Inimigos
- Áudio
- Cenas Extras
- Inteligência Artificial

#### Inimigos

Adicionar um GameObject vazio na cena Main e depois adicionar Prefabs Enemy em posições estratégicas do nível como em cima das plataformas. Se necessário, adicione mais plataformas (Unidade 2) para projetar o campo de visão dos inimigos.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/09.png?raw=true)

Confira o prefab Enemy, ele deve conter:

- BoxCollider2D e Rigibody2D
- Enemy (Script)
- Sprite Renderer (sprite inicial do inimigo)
- Objeto Animator (para controle das animações do inimigo)

#### Áudio

O controle de áudio é realizado pelo GameObject AudioSource, localizado na pasta Prefabs. Adicione o controle na cena. A música de fundo associada ao objeto é a synthpop. Você pode customizar o som de entrada a seu gosto.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/10.png?raw=true)

Obs: Acesse http://www.freesound.org para obter arquivos de música e efeitos sonoros para utilização gratuita.

A implementação do som está realizada na classe GameManager (altere se preferir criar uma classe que gerencia os sons de seu jogo). Para isso, crie uma variável pública contendo uma referência para o prefab AudioSource e uma variável bool para checagem de atividade do componente. Opcionalmente, você pode criar um botão que ligue e desligue o som do jogo.

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/11.png?raw=true)

Com uma função de checagem, é possível ligar e desligar o som do nível:

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/12.png?raw=true)

Para associar essa função ao evento de botão,  crie um botão SoundButton no Canvas da cena (criado mas pode ser alterado). No Inspector, vá na On Click (), arraste o componente Canvas para o objeto e selecione a função GameManager.SounToggle na lista. Dessa forma, o jogo ligará e desligará a música. O processo pode ser repetido para efeitos sonoros.

#### Cenas Extras

Crie cenas extras como SplashScene, MenuScene e BossScene (cena Boss já criada pare referência). Na cena Splash, adicione uma imagem de apresentação. Na cena Menu, adicione botões como Jogar (“Play”), Opções (“Settings”) e outras opções que ache pertinentes. Utilize o mecanismo visto no material da Unidade para transição entre as cenas.

Por fim, na cena Boss, adicione o prefab Backgrounds e também as plataformas para manter o Meca e o prefab Boss posicionados corretamente:

![Alt text](https://github.com/phoenixproject/gamedev/blob/master/__RESOURCES/_CZDOSUL/__POS/_PROJETO2D/13.png?raw=true)

#### Inteligência Artificial

Como exercício de avaliação, adicione características e comportamentos aos objetos Enemy e Boss para configurar uso de Inteligência Artificial.

O que se espera:

A) Enemy:

- Movimentos para esquerda e direita nas plataformas
- Movimento de ataque ou tiro ao “ver” personagem
- Condição de morte

Dica: para isso, utilize objetos nas extremidades da plataforma e faça uma rotina para os inimigos irem do ponto A ao B (e vice-versa). Utilize a função de Raycast para deixar os inimigos com campo de visão para encontrarem o Player.

B) Boss:

- Movimentos para esquerda e direita nas plataformas;
- Movimento de ataque após condição especial (barra de vida reduzida, movimentos do jogador etc.). O aluno pode definir a heurística utilizada;
- Condição de morte

Dica: procure pelos termos Boss Fight 2d, Megaman Bosses AI e termos referentes para entender comportamentos comuns em chefes de níveis de jogos de plataforma2d.

Procure também pelos termos Chase, Seek and Evade para encontrar algoritmos e formas de fazer perseguição e fuga em entidades nos jogos.

-****---**-****---**-****---**-****--

# Explicação da atividade para os que optarem fazer jogos de outros gêneros

Em aspectos gerais os alunos deverão entregar um jogo 2D, de qualquer gênero.

Para os alunos que optem por fazer um jogo 2D de diferente gênero, seguem aqui alguns passos e ao final os critérios que serão analisados.

Utilizarei as etapas sugeridas pelo professor conteudista como base, para que assim fique fácil de entender a explicação do que é pedido na disciplina.

*---***-----****----*****-----*****-----*****------*****----**-*-**********-*******------**********---------**********

## Etapa 1

Desenvolver, pesquisar ou montar um cenário 2D, nos quais, contenham o cenário do jogo + o personagem + o terreno ou plataformas, no qual, o personagem se movimentará.

*---***-----****----*****-----*****-----*****------*****----**-*-**********-*******------**********---------**********

## Etapa 2

Começaremos a desenvolver, programar e implementar as mecânicas básicas do jogo.
Como por exemplo:

    Movimentação (mover para os lados com o teclado + pulo, ou seja, a troca de sprites e animações);
    Perda de vidas ou de porcentagem da barra de vida;
    Ataques, caso houver;
    Movimentação do cenário conforme o jogador avança;
    Trocas de cenário.
    Implementação de música de background e efeitos sonoros;
    Implementação e montagem da HUD para nosso jogador;

*---***-----****----*****-----*****-----*****------*****----**-*-**********-*******------**********---------**********

## Etapa 3

Com todas as mecânicas implementadas vamos inserir os efeitos sonoros e inimigos (caso haja).

Além é claro de implementar o "Game over" ou critérios de derrota do jogador, como por exemplo, o jogador perdeu todas as vidas ou a condição de derrota seja satisfeita.

Implementar o "You win" ao terminar o jogo ou a condição de vitória seja satisfeita.

Caso haja inimigos, a implementação das mecânicas deverão ser apresentadas, como por exemplo:

    Movimentação pelo cenário;
    Implementação de uma "inteligência artificial"/ detecção do jogador, no qual, caso o inimigo encontre o jogador o inimigo irá atacar ou avançar até o jogador para derrotá-lo;
        Caso haja um boss deverá ser aplicada a mesma mecânica dos inimigos;
            Porém deverá conter:
                Quantidade de vida maior comparado aos inimigos comuns para que assim ele seja derrotado com maior dificuldade;

*---***-----****----*****-----*****-----*****------*****----**-*-**********-*******------**********---------***********---***-----****----*****-----*****-----*****------*****----**-*-**********-*******------**********---------**********

### Critérios a serem analisados

#### Jogos do gênero de aventura, ação, plataforma e outros do gênero:

    Uma fase ou duas fases contendo os inimigos e o boss ao final (caso hajam);
        Como sugestão, poderá ser uma fase com os inimigos e a outra somente com o boss do jogo.

#### Jogos do gênero de RPG e derivados:

    Uma missão deverá ser aplicada no jogo;

Ou

    Batalha deverá ser aplicada no jogo;

#### Para jogos no estilo "Flappy bird" ou "Angry birds", onde há apenas "uma fase" deverá conter:

    A pontuação do jogador;
    Quantidade de vidas do jogador; 

*---***-----****----*****-----*****-----*****------*****----**-*-**********-*******------**********---------********** 

# Mas AONDE eu envio ou publico??

Para publicação, seguem aqui alguns exemplos de sites gratuitos:

- https://roastmygame.com/ (Links para um site externo.)

- http://www.desura.com/ (Links para um site externo.)

- https://www.kongregate.com/ (Links para um site externo.)

- https://itch.io/ (Links para um site externo.)

- https://gamejolt.com/ (Links para um site externo.)

- https://www.newgrounds.com/ (Links para um site externo.)

E dentre outros

- Fonte: https://www.gamedeveloper.com/business/the-5-best-free-places-to-publish-your-game (Links para um site externo.)

- https://codeswholesale.com/blog/5-best-platforms-to-publish-your-indie-game/