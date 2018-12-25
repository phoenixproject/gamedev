var Nivel1 = new Phaser.Class({
    Extends: Phaser.Scene,
    initialize: function Nivel1() {
        Phaser.Scene.call(this, {
            key: 'Nivel1'
        });
    },

    preload: function () {
        this.load.image("tiles", "../imagens/deserto.png");
        this.load.image("chave", "../imagens/chave.png");
        this.load.tilemapTiledJSON("n1", "../imagens/Nivel1.json");
        this.load.spritesheet('ninja', '../imagens/ninja.png', {
            frameWidth: 45,
            frameHeight: 54
        });
    },

    create: function () {
        const nivel1 = this.make.tilemap({
        key: "n1"
    });
    const tileset = nivel1.addTilesetImage("Sprites", "tiles");

    const plataformas = nivel1.createStaticLayer("plataformas", tileset, 0, 0);
   
    plataformas.setCollisionByProperty({
        collider: true
    });

   const spawnPoint = nivel1.findObject("objetos", obj => obj.name === "personagem");
    
   player = this.physics.add.sprite(spawnPoint.x, spawnPoint.y, "ninja");
        
   const checkpoint = nivel1.findObject("objetos", obj => obj.name === "checkpoint");
   chave = this.physics.add.sprite(checkpoint.x, checkpoint.y, "chave");
        
   this.anims.create({
        key: 'left',
        frames: this.anims.generateFrameNumbers('ninja', {
            start: 21,
            end: 31
        }),
        frameRate: 25,
        repeat: -1
    });

    this.anims.create({
        key: 'turn',
        frames: this.anims.generateFrameNumbers('ninja', {
            start: 11,
            end: 20
        }),
        frameRate: 10,
        repeat: -1
    });

    this.anims.create({
        key: 'right',
        frames: this.anims.generateFrameNumbers('ninja', {
            start: 0,
            end: 10
        }),
        frameRate: 25,
        repeat: -1
    });

    this.physics.add.collider(player, plataformas);
    this.physics.add.collider(chave, plataformas);
    this.physics.add.overlap(player, chave, function(){
        
        this.scene.start("Nivel2");

    }, null, this);

    const camera = this.cameras.main;
    camera.startFollow(player);
    camera.setBounds(0, 0, nivel1.widthInPixels, nivel1.heightInPixels);
    cursors = this.input.keyboard.createCursorKeys();
    },

    update: function (time, delta) {
         const speed = 175;

    if (cursors.up.isDown && player.body.velocity.y == 0) {
        player.body.setVelocityY(-400);
    }

    if (cursors.left.isDown) {
        player.body.setVelocityX(-speed);
        player.anims.play('left', true);
    } else if (cursors.right.isDown) {
        player.setVelocityX(speed);
        player.anims.play('right', true);
    } else {
        player.setVelocityX(0);
        player.anims.play('turn', true);
    }
    }
});

var Nivel2 = new Phaser.Class({
    Extends: Phaser.Scene,
    initialize: function Nivel2() {
        Phaser.Scene.call(this, {
            key: 'Nivel2'
        });
    },

    preload: function () {
       this.load.tilemapTiledJSON("n2", "../imagens/Nivel2.json");
    },

    create: function () {
        const nivel2 = this.make.tilemap({
        key: "n2"
    });
    const tileset = nivel2.addTilesetImage("Sprites", "tiles");

    const plataformas = nivel2.createStaticLayer("plataformas", tileset, 0, 0);
    

    plataformas.setCollisionByProperty({
        collider: true
    });

        
    const spawnPoint = nivel2.findObject("objetos", obj => obj.name === "personagem");
    player = this.physics.add.sprite(spawnPoint.x, spawnPoint.y, "ninja");

    

    this.physics.add.collider(player, plataformas);

    const camera = this.cameras.main;
    camera.startFollow(player);
    camera.setBounds(0, 0, nivel2.widthInPixels, nivel2.heightInPixels);
    cursors = this.input.keyboard.createCursorKeys();

        
    },

    update: function (time, delta) {
        const speed = 175;

    if (cursors.up.isDown && player.body.velocity.y == 0) {

        player.body.setVelocityY(-400);

    }

    if (cursors.left.isDown) {
        player.body.setVelocityX(-speed);
        player.anims.play('left', true);
    } else if (cursors.right.isDown) {
        player.setVelocityX(speed);
        player.anims.play('right', true);
    } else {
        player.setVelocityX(0);
        player.anims.play('turn', true);
    }

    
    }

});


var config = {
    type: Phaser.AUTO,
    width: 800,
    height: 600,
    backgroundColor: '#3681f8',
    physics: {
        default: "arcade",
        arcade: {
            gravity: {
                y: 500
            }
        }
    },
    scene: [Nivel1, Nivel2]
};

var game = new Phaser.Game(config);

let cursors;
let player;
