using dice_roll_game.Enums;
using dice_roll_game.Utils;

namespace dice_roll_game;

public class Game
{
    private int _targetNumber;
    private int _chances;
    private GameStatus _gameStatus;

    private const int SidesCount = 6;
    private const int Chances = 3;

    private readonly Randomizer _randomizer;

    public Game(Randomizer randomizer)
    {
        _randomizer = randomizer;
    }

    public void Start()
    {
        _targetNumber = _randomizer.RandomNumberInRange(1, SidesCount + 1);
        _chances = Chances;

        Console.WriteLine($"Dice rolled. Guess what number it shows in {Chances} tries.");

        bool isUserGuess = false;

        while (_chances > 0 && !isUserGuess)
        {
            isUserGuess = UserInputHandler.IsUserGuess(_targetNumber);

            if (isUserGuess)
            {
                _gameStatus = GameStatus.Won;

                return;
            }

            Console.WriteLine("Wrong number");
            _chances -= 1;
        }

        _gameStatus = GameStatus.Lost;
    }

    public void PrintResultMessage()
    {
        string message = _gameStatus == GameStatus.Won ? "You win" : "You lose";

        Console.WriteLine(message);
        Console.WriteLine("Press any key to exit");
    }
}