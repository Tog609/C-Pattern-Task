public class Cargo : Transport 
{
    private int _tonnage;

    private int _tankvolume;

    private int _axlesAmount;

    public sealed override string ToString()
    {
        return $"{_tonnage} {_tankvolume} {_axlesAmount}";
    }
}
