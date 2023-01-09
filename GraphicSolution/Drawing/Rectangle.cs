namespace Drawing;

public class Rectangle: Shape, IPrintable{
    public Point StartPoint{get; set;}
    public Point EndPoint{get; set;}

    public Rectangle(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
    }

    public Rectangle(Point p1, Point p2){
        this.StartPoint=p1;     //shallow copy
        this.EndPoint=p2;
    }

    override public void Draw(){
        Console.WriteLine("Inside draw of rectangle");
        Console.WriteLine("Rectangle : p1({0}), p2({1})",this.StartPoint,this.EndPoint);
        this.Clr=Color.BLUE;
        this.Width=10;
        Console.WriteLine("Color="+this.Clr+" Width="+this.Width);
    }

    public void Print(){
        Console.WriteLine("Inside Print() of rectangle");
        Type t=this.GetType();
        Console.WriteLine(t);
        Console.WriteLine(t.Name);
    }
    
}