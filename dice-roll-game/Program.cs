using dice_roll_game;
using dice_roll_game.Utils;

Random random = new Random();
Randomizer randomizer = new Randomizer(random);

Game game = new Game(randomizer);

game.Start();
game.PrintResultMessage();

Console.ReadKey();