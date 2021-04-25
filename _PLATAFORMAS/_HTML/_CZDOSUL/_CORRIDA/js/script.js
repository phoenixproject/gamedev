var carroCorrida = [];
var game;

window.onload = function(){
    setCarro();
    var buttonIniciar = document.getElementById("iniciarBotao");
    buttonIniciar.addEventListener("click", function() {
        this.className = "ativado";
        mudarImagem();
        game = setInterval(moveImagem,100);
    });
};

function mudarImagem(){
    for(i = 0; i < 4; i++){
        document.getElementById("carro" + (i + 1)).style = 'images/' + carroCorrida[i].imagem + '.gif';
        document.getElementById("carro" + (i + 1)).style.left = "0px";
    }
}

function carro(nome, imagem, velocidade){
    this.nome = nome;
    this.imagem = imagem;
    this.velocidade = velocidade;
}

function setCarro(){
    for(i = 0; i < 4; i++){
        carroCorrida[i] = new carro("carro" + (i + 1), "carro" + (i + 1), randomize(10, 20));
    }
}

function randomize(min, max){    
    return min + Math.round(Math.random() * (max - min));
}

function moveImagem(){
    for(i = 0; i < 4; i++){
        var carro = document.getElementById("carro" + (i + 1));
        carro.style.left = parseInt(carro.style.left.substr(0, carro.style.left.indexOf("px")))
                            + carroCorrida[i].velocidade + "px";
        if(parseInt(carro.style.left.substr(0, carro.style.left.indexOf("px"))) >= 660){
            fim(i);
        }
    }
}

function fim(vencedor){
    clearInterval(game);
    for(i = 0; i < 4; i++){
        document.getElementById("carro" + (i + 1)).src = 'images/i_' + carroCorrida[i].imagem + '.png';
        if(i === vencedor){
            document.getElementById("vencedor" + (i + 1)).innerHTML = '<div class="vencedor">' +
                '<img src="images/trofeu.png"><p>Vencedor!</p>';
        }
    }
}   