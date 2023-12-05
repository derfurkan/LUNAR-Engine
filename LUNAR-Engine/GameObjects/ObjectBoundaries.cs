namespace LUNAR_Engine.Engine.GameObjects;

public class ObjectBoundaries
{
    public int Width { get; set; }
    public int Height { get; set; }

    public ObjectBoundaries(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public ObjectBoundaries()
    {
        Width = 0;
        Height = 0;
    }
}