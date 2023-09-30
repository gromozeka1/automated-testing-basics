namespace Solution;

/// <summary>
/// Bird
/// </summary>
/// <remarks>Restrictions
/// Bird flies with constant random speed <see cref="speed"/>
/// </remarks>
public class Bird : IFlyable
{
    private readonly double speed = Helper.GetRandomValue(0, 20);

    public Coordinate CurrentPosition { get; private set; }

    public Bird(Coordinate initialPosition)
    {
        this.CurrentPosition = initialPosition;
    }

    public void FlyTo(Coordinate newPoint)
    {
        this.CurrentPosition = newPoint;
    }

    public double GetFlyTime(Coordinate newPoint)
    {
        double distance = Helper.CalculateDistance(this.CurrentPosition, newPoint);
        double flyTime = distance / this.speed;
        return Math.Round(flyTime, 2);
    }
}
