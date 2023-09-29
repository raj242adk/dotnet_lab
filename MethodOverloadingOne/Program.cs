public class MethodOverloadingOne { 

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Hi I am form the Base Class Performing Task");
    }
}
public class Triange : Shape
{
    public override void Draw()
    {
        Console.WriteLine("I am Drawing Triangle");
        base.Draw();
    }
}
public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("I am Drawing Rectangel");
        base.Draw();
    }
}

public static void Main(string[] args)
{
    Shape s = new Shape();
    s.Draw();
    Triange triange = new Triange();
    triange.Draw();
    Rectangle rect = new Rectangle();
    rect.Draw();


}

}