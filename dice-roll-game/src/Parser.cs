namespace dice_roll_game;

public static class Parser
{
    public static bool TryParseNumber(out int number)
    {
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out number))
        {
            return true;
        }
        
        number = 0;
        Console.WriteLine("Incorrect input");

        return false;
    }
}