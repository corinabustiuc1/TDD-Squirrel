namespace SnakesAndLadders;

public class PieceMover
{
    public static int RollDieAndMove(int position)
    { 
        var random = RollDie();
        var newPosition = Move(position, random);

        return newPosition;
    }

    public static int Move(int position, int movement)
    {
        return position + movement;
    }

    public static int RollDie()
    {
        var random  = new Random();
        var result = random.Next(1,7);
        return result;
    }
}