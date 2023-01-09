namespace Drawing;

public class Line: Shape, IPrintable{
    public Point StartPoint{get; set;}
    public Point EndPoint{get; set;}

    public Line(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
    }

    public Line(Point p1, Point p2){
        this.StartPoint=p1;     //shallow copy
        this.EndPoint=p2;
    }

    override public void Draw(){
        Console.WriteLine("Inside draw of line");
        Console.WriteLine("Line : p1({0}), p2({1})",this.StartPoint,this.EndPoint);
        Console.WriteLine("Color="+this.Clr+" Width="+this.Width);
    }

    public void Print(){
        Console.WriteLine("Inside Print() of line");
        Type t=this.GetType();
        Console.WriteLine(t);
        Console.WriteLine(t.Name);
    }
    
}