public class Tank : Transport
{
    public float ProjectileCaliber { get; }
    public int ShotsPerMinute { get; }
    public float CrewSize { get; }

    public Tank(int weight, float length, int maxSpeed, float projectileCaliber, int shotsPerMinute, float crewSize)
        : base(weight, length, maxSpeed)
    {
        ProjectileCaliber = projectileCaliber;
        ShotsPerMinute = shotsPerMinute;
        CrewSize = crewSize;
    }

    public override string ToString()
    {
        return $"Tank: Weight={Weight}, Length={Length}, MaxSpeed={MaxSpeed}, ProjectileCaliber={ProjectileCaliber}, ShotsPerMinute={ShotsPerMinute}, CrewSize={CrewSize}";
    }
}
