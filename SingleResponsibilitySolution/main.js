function create(game) {
    var panda = createPanda(game, game);
    setupBoxes(game);
    setUpScore(game);
}

function createPanda(game) {
    panda = game.add.sprite(100, 245, 'panda');
    scalePanda(pands, 125, 125);
    initialisePandaAnimations(panda);
    initialisePandaBody(panda);
    initialisePandaInputs(panda);
    return panda;
}

function initialisePandaInputs(panda, game) {
    game.input.onDown.add(panda.jump);
}

function scalePanda(pands, x, y) {
    panda.scale.x = x; 
    panda.scale.y = y;
}

function initialisePandaAnimations(panda) {
    panda.animations.add('run',[17,18,19,20,21,22],6,true);
    panda.animations.play('run', 15, true);
}

function initialisePandaBody(panda) {
    panda.body.collideWorldBounds=true;
    panda.body.gravity.y = 1000;
    panda.body.bounce.y = 0.1;
}

function setupBoxes(game) {
    game.boxes = game.add.group();  
    game.boxes.createMultiple(20, 'box');
    game.boxTimer = game.time.events.loop(1500, game.add_row_of_boxes); 
}

function setUpScore(game) {
    game.score = 0;  
    var style = { font: "30px Arial", fill: "#ffffff" };  
    game.label_score = game.add.text(20, 20, "0", style); 
    game.highScore = "High Score: " + this.get_score();
    game.label_high_score = game.add.text(20, 450, game.highScore, style);
}