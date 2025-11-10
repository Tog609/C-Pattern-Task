public class Cargo : Transport
{
    public int Tonnage { get; }
    public int TankVolume { get; }
    public int AxlesAmount { get; }

    public Cargo(int weight, float length, int maxSpeed, int tonnage, int tankVolume, int axlesAmount)
        : base(weight, length, maxSpeed)
    {
        Tonnage = tonnage;
        TankVolume = tankVolume;
        AxlesAmount = axlesAmount;
    }

    public override string ToString()
    {
        return $"Cargo: Weight={Weight}, Length={Length}, MaxSpeed={MaxSpeed}, Tonnage={Tonnage}, TankVolume={TankVolume}, AxlesAmount={AxlesAmount}";
    }
}
