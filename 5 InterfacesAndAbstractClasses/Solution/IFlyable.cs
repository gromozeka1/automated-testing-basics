namespace Solution;

interface IFlyable
{
    /// <summary>
    /// Get a current position
    /// </summary>
    public Coordinate CurrentPosition { get; }

    /// <summary>
    /// Move to a new point
    /// </summary>
    /// <param name="newPoint">Coordinates of a new point</param>
    /// <returns></returns>
    void FlyTo(Coordinate newPoint);
    
    /// <summary>
    /// Calculate flight time to a new point 
    /// </summary>
    /// <param name="newPoint">Coordinates of a new point</param>
    /// <returns></returns>
    double GetFlyTime(Coordinate newPoint);
}
