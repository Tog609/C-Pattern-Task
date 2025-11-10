public abstract class Transport
{
    public int Weight { get; protected set; }
    public float Length { get; protected set; }
    public int MaxSpeed { get; protected set; }

    protected Transport(int weight, float length, int maxSpeed)
    {
        Weight = weight;
        Length = length;
        MaxSpeed = maxSpeed;
    }

    public abstract override string ToString();
}
