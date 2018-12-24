var cvs = document.getElementById("snake");

var ctx = cvs.getContext("2d");

var box = 20;

var snake = [];

snake[0] = {
    x : 10 * box,
    y : 10 * box
};

var pontos = 0;

var food = {
    x : Math.floor(Math.random()*29+1) * box,
    y : Math.floor(Math.random()*29+1) * box
};

var d;

document.addEventListener("keydown",direcao);

function direcao(event){
    var key = event.keyCode;
    
    if(key === 37 && d !== "RIGHT"){
        d = "LEFT";
    } else if(key === 38 && d !== "DOWN"){
        d = "UP";
    } else if(key === 39 && d !== "LEFT"){
        d = "RIGHT";
    } else if(key === 40 && d !== "UP"){
        d = "DOWN";
    }
}

function collision(head,array){
    for(var i = 0; i < array.length; i++){
        if(head.x === array[i].x && head.y === array[i].y){
            return true;
        }
    }
    return false;
}

function draw(){
    ctx.fillStyle = "#dbdbdb";
    ctx.fillRect(0,20,cvs.width,cvs.height);
    
    for(i=0; i < snake.length; i++){
        ctx.fillStyle = ( i === 0)? "green" : "blue";
        ctx.fillRect(snake[i].x, snake[i].y,box, box);
        ctx.strokeStyle = "red";
        ctx.strokeRect(snake[i].x,snake[i].y,box,box);
    }
    
    ctx.fillStyle = "black";
    ctx.fillRect(food.x, food.y, box, box);
    
    var snakeX = snake[0].x;
    var snakeY = snake[0].y;
    
    if( d === "LEFT")  snakeX -= box;
    if( d === "UP")    snakeY -= box;
    if( d === "RIGHT") snakeX += box;
    if( d === "DOWN")  snakeY += box;
    
    if(snakeX === food.x && snakeY === food.y){
        food = {
            x : Math.floor(Math.random()*29*1) * box,
            y : Math.floor(Math.random()*29*1) * box
        };
        somaPonto();
    }
    else{
        snake.pop();
    }
    
    var newHead = {
        x : snakeX,
        y : snakeY
    };
    
    if(snakeX < 0 || snakeX > cvs.width-box || snakeY < 20 || snakeY > cvs.height-box || collision(newHead,snake)){
        clearInterval(game);
        gravaRecorde();
    }
    
    snake.unshift(newHead);
}

function somaPonto(){
    pontos = pontos + 1;
    mostrarPontos();
}

function gravaRecorde(){
    var record = 0;
    if (localStorage.getItem("pontuacaoSnake") !== null){
        record = parseInt(localStorage.getItem("pontuacaoSnake"));
        if(record < pontos){
            record = pontos;
        }
    }else{
        record = pontos;
    }
    localStorage.setItem("pontuacaoSnake",record);
    mostrarRecorde();    
}

function mostrarRecorde(){
    ctx.clearRect(cvs.width - 250,0,cvs.width,20);
    var record = 0;
    ctx.fillStyle = "0000ff";
    ctx.font = "20px Arial";
    if(localStorage.getItem("pontuacaoSnake") !== null){
        record = parseInt(localStorage.getItem("pontuacaoSnake"));
    }
    ctx.fillText("Recorde: " + record, cvs.width - 250,16,250);
}

function mostrarPontos(){
    ctx.clearRect(0,0,250,20);
    ctx.fillStyle = "#ff0000";
    ctx.fillText("Pontos: " + pontos, 1,16,250);
}

mostrarRecorde();
mostrarPontos();

var game = setInterval(draw,100);