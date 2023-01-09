namespace Drawing;

public enum Color{RED, GREEN, BLUE};

public abstract class Shape
{
    protected Color Clr{get; set;}
    protected int Width{get; set;}
    public abstract void Draw();
}
