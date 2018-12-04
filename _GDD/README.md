# GDD: Guardiões dos Mares

Trabalho desenvolvido durante as disciplinas de:
- Projeto de Jogos, 
- Programação Web para Jogos, 
- Jogos para Internet,
- Projeto de Sistemas


**INTEGRANTES DO GRUPO:** 
- Nome integrante 1
- Nome integrante 2<br>

        
# Sumário


#Gerência de Requisitos

## 1	Motivação e Propósito do Sistema 
escrever os motivos, necessidades e benefícios do projeto.

## 2	Personas
descrever os personas de tal forma que descreva as necessidades do usuário pelo sistema.

## 3	Minimundo 
descrição breve sobre o sistema 

## 4	Requisitos de Usuários
### 4.1	Requisitos Funcionais (Histórias de Usuário)

| ID | Categoria| História de Usuário| Importância | MosCoW| Estimativa | Real| Pronto?| Sprint|
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| RF01 | Categoria X |EU, COMO  **QUEM**, QUERO/GOSTARIA/DEVO/POSSO **O QUE**, PARA QUE/DE/PARA **PORQUE/RESULTADO**. |10| Must| 2 | ? | Não | -|
| RF02 | Acesso os dados |EU, COMO cliente, POSSO acessar o acerto da locadora PARA QUE consiga ver os filmes disponíveis antes de sair de casa.| 80| Should | 3 |5| Sim| 1|

### 4.2	Requisitos Não Funcionais
| ID | Categoria| Descrição |MosCoW | Estimativa Planejada | Estimativa Real|Pronto?| Sprint|Histórias relacionadas |
| --- | --- | --- | --- | --- |--- |--- |--- |--- |
| RNF01 |Facilidade de Operação |  A entrada de dados de efetuar locação pelo atendente deverá ser realizada em no máximo 30 segundos | Must | 2 | 5| Sim| 10|RF01|
| RNF02 | Eficiência de Tempo | O tempo de resposta de efetuar locação dever ser de no máximo 2 segundos a partir da entrada correta de dados | Should | 3 | ?| Não| -|RF01 e RF02|

### 4.3	Regras de Negócio
| ID | Descrição | MosCoW | Estimativa Planejada| Estimativa Real| Pronto?| Sprint|Histórias relacionadas |
| --- | --- | --- | --- | --- | --- | --- | --- |
| RN01 | Uma reserva expira quando passadas mais do que 24h de sua comunicação para o cliente. | Must |1|5|Sim|2|RF01|
| RN02 | Clientes em atraso não podem efetuar nem locações nem reservas. | Should |10|5|Sim|2|RF02|


# Desenvolvimento do Sistema
## 1.    Análise de Sistemas:
### 1.1  Subsistemas
inserir diagrama dos subsistemas UML
### 1.2  Modelagem de Casos de uso 
inserir diagramas dos Casos de Uso (UML) e descrever brevemente.

### 1.3  Modelagem Estrutural (Modelo Conceitual)
** ATENÇO: USAR Notação Entidade-Relacionamentos se estiver fazendo BD2 e o diagrama de classes se estiver fazendo Projeto de Sistemas**
![Alt text](https://github.com/discipbd2/topicos-trabalho/blob/master/sample_MC.png?raw=true "Modelo Conceitual")
### 1.4  Modelagem Comportamental
inserir principais diagramas comportamentais da análise (principalmente, estados)
### 1.5  Dicionário de Dados
[classe/entidade]: [descrição da classe]
    
    EXEMPLO:
    CLIENTE: classe/entidade que representa as informações relativas ao cliente<br>
    CPF: atributo que representa o número de Cadastro de Pessoa Física para cada cliente da empresa.<br>
    
## 2.    Projeto de Sistemas:
### 2.1  Projeto Arquitetural 
#### 2.1.1   Plataforma de Implementação e Tecnologias
descrever tecnologias usadas no sistema, justificando cada uma delas com base no contexto

#### 2.1.2   Atributos de Qualidade e Táticas
 CATEGORIAS | RNF'S | TÁTICAS | 
| --- | --- | --- |
| Facilidade de Operação | RNF03, RNF08| Prover ao usuário a capacidade de entrar com comandos que permitam operar o sistema de modo mais eficiente. Para tal, as interfaces do sistema devem permitir, sempre que possível, a entrada por meio de seleção ou leitura de código de barras ao invés da digitação de campos. | 


#### 2.1.3   Arquitetura de Software
apresentar diagrama UML da arquitetura do sistema. justificar as decisões tomadas.

### 2.2. Projeto Detalhado
OBS: repetir as seções abaixo para cada subsistema
#### 2.2.1.   Projeto da Lógica de Negócio
##### Projeto do Domínio
apresentar diagrama de classes do domínio
##### Projeto da