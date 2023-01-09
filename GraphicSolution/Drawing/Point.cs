namespace Drawing;

public struct Point{
    public int X{get; set;}
    public int Y{get; set;}

    public Point(){
        this.X=0;
        this.Y=0;
    }

    public Point(int x, int y){
        this.X=x;
        this.Y=y;
    }

    override public string ToString(){
        return this.X+", "+this.Y;
    }
}