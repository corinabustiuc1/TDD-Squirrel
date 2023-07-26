using System.Collections;

namespace SnakesAndLadders;

public class DiceRoller : IDiceRoller
{
    private Random _random;

    public DiceRoller()
    {
        _random = new Random() ;
    }

    public int RollDie()
    {
        var result = _random.Next(1,7);
        return result;
    }
}

public interface IDiceRoller
{
    int RollDie();
}

public class PieceMover
{
    private IDiceRoller _diceRoller;

    public PieceMover(IDiceRoller diceRoller)
    {
        _diceRoller = diceRoller;
    }

    public int RollDieAndMove(int position)
    {
        var random = _diceRoller.RollDie();
        var newPosition = Move(position, random);

        return newPosition;
    }

    public static int Move(int position, int movement)
    {
        return position + movement;
    }
}