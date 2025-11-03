public class Cargo : Transport 
{
    private int _tonnage = 13;

    private int _tankvolume= 153;

    private int _axlesAmount = -242;

    public override string ToString()
    {
        return $"{_tonnage} {_tankvolume} {_axlesAmount}";
    }
}
