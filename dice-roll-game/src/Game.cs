using dice_roll_game.Utils;

namespace dice_roll_game;

public class Game
{
    private int _targetNumber;
    private int _chances;

    private readonly Randomizer _randomizer;
    private readonly UserInputHandler _userInputHandler;

    public Game()
    {
        _randomizer = new Randomizer();
        _userInputHandler = new UserInputHandler();
    }

    public void Start()
    {
        _targetNumber = _randomizer.RandomNumberInRange(1, 7);
        _chances = 3;

        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

        bool isUserGuess = false;

        while (_chances > 0 || !isUserGuess)
        {
            isUserGuess = _userInputHandler.IsUserGuess(_targetNumber);

            if (isUserGuess)
            {
                Console.WriteLine("You win");
                Console.WriteLine("Press any key to exit");

                break;
            }

            Console.WriteLine("Wrong number");
            _chances -= 1;
        }

        if (_chances == 0)
        {
            Console.WriteLine("You lose");
            Console.WriteLine("Press any key to exit");
        }
    }
}