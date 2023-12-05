namespace LUNAR_Engine.Engine.GameObjects;

public class ObjectLocation
{
    public int X { get; set; }
    public int Y { get; set; }

    public ObjectLocation(int x, int y)
    {
        X = x;
        Y = y;
    }

    public ObjectLocation()
    {
        X = 0;
        Y = 0;
    }
}