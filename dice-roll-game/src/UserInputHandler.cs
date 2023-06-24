namespace dice_roll_game;

public class UserInputHandler
{
    private readonly Parser _parser;

    public UserInputHandler()
    {
        _parser = new Parser();
    }
    
    public bool IsUserGuess(int targetNumber)
    {
        int userNumber;
        
        do
        {
            Console.WriteLine("Enter number:");
        } while (!_parser.TryParseNumber(out userNumber));
        
        return userNumber == targetNumber;
    }
}