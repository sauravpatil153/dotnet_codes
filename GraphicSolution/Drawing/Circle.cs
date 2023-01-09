namespace Drawing;

public class Circle: Shape, IPrintable{
    public Point Center{get; set;}
    public int Radius{get; set;}

    public Circle(){
        this.Center=new Point(0,0);
        this.Radius=0;
    }

    public Circle(Point p1, int r){
        this.Center=p1;     //shallow copy
        this.Radius=r;
    }

    override public void Draw(){
        Console.WriteLine("Inside draw of circle");
        Console.WriteLine("Circle : center({0}), radius={1}",this.Center,this.Radius);
        this.Clr=Color.GREEN;
        this.Width=20;
        Console.WriteLine("Color="+this.Clr+" Width="+this.Width);
    }

    public void Print(){
        Console.WriteLine("Inside Print() of circle");
        Type t=this.GetType();
        Console.WriteLine(t);
        Console.WriteLine(t.Name);
    }
    
}