using Drawing;
using System.Collections.Generic;

Point p1=new Point(10,10);
Point p2=new Point(20,20);
Shape s1=new Line(p1,p2);
Shape s2=new Rectangle(p1,p2);
Shape s3=new Circle(new Point(0,0),25);
//s1.Draw();
// IPrintable i1=new Line(p1,p2);
// i1.Print();

// IPrintable i1=(IPrintable)s1;
// i1.Print();

//((IPrintable)s1).Print();

List<Shape> shapes=new List<Shape>();
shapes.Add(s1);
shapes.Add(s2);
shapes.Add(s3);
foreach(var s in shapes){
    s.Draw();
    ((IPrintable)s).Print();
}