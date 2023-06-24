namespace dice_roll_game;

public static class UserInputHandler
{
    public static bool IsUserGuess(int targetNumber)
    {
        int userNumber;
        
        do
        {
            Console.WriteLine("Enter number:");
        } while (!Parser.TryParseNumber(out userNumber));
        
        return userNumber == targetNumber;
    }
}