
/**
 * Single responsibility is mainly talking about classes but it can also apply to functions.
 * Scenario:
 *  -This is some code taken from a game a programmed in my first year of uni. It creates/sets up literally everything the game needs.
 *  -Refactor this code so that the single responsibility principle is obeyed.
 * 
 * Side note: Notice how this code has loads of comments - this is bad practice! A lot of these comments are unessesary and can be worked out from code and also 
 * If you have to explain your code in a comment then you've failed at making it clear what your code does,
 * the next person to read your code after you shouldn't have to read an essay to get to the code. 
 * Bonus points if you refactor your code so the comments are no longer needed by introducing nice variable names!
 * 
 */

function create(game) {
    // Declares the panda character sprite and adds it to the game at 100,245
    panda = game.add.sprite(100, 245, 'panda');
    
    //	Scales the panda sprite by 1.25
    panda.scale.x = 1.25; 
    panda.scale.y = 1.25;
    
    // Adds an animation called 'run' to the panda sprite and specifies the frames in the sprite sheet to use.
    panda.animations.add('run',[17,18,19,20,21,22],6,true);
    
    // Calls the jump function when it detects mouse or finger input
    game.input.onDown.add(panda.jump);
    
    //  This starts the run animation at 15 frames per second.
    // 	true because we want the animation to loop
    panda.animations.play('run', 15, true);
    
    panda.body.collideWorldBounds=true;
    panda.body.gravity.y = 1000;
    panda.body.bounce.y = 0.1;
    
    //creates a group of 20 boxes
    game.boxes = game.add.group();  
    game.boxes.createMultiple(20, 'box');
    
    //adds a timer to call the add_row_of_boxes function every 1500
    game.boxTimer = game.time.events.loop(1500, game.add_row_of_boxes); 

    // Initialises the score for the current game and the score labels
    game.score = 0;  
    var style = { font: "30px Arial", fill: "#ffffff" };  
    game.label_score = game.add.text(20, 20, "0", style); 
    game.highScore = "High Score: " + this.get_score();
    game.label_high_score = game.add.text(20, 450, game.highScore, style);
}
