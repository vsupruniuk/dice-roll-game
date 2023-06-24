namespace dice_roll_game.Utils;

public class Randomizer
{
    private readonly Random _random;

    public Randomizer(Random random)
    {
        _random = random;
    }
    
    public int RandomNumberInRange(int min, int max)
    {
        return _random.Next(min, max);
    }
}