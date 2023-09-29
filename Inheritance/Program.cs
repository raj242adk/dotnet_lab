public class A
{
    public void Method1()
    {
        Console.WriteLine("From Class A ");
        Console.WriteLine("Rabindra Adhikari");
    }
}

public class B : A
{ 
    public void Method2() 
    {
        Console.WriteLine("From Class B");
    }

}

public class Example
{
    public static void Main()
    {
        B b = new();
        b.Method1();
        b.Method2();
    }
}