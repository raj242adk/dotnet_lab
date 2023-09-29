abstract class Vehical
{
    public abstract void Speed();
    public void Start()
    {
        Console.WriteLine("Please Enter the Key To Start");
    }

  
}
class Mustang : Vehical
{
    public override void Speed()
    {
        Console.WriteLine("The Speed of the Mustang is 210 Km/Hr");
    }
}
class Tesla : Vehical
{
    public override void Speed()
    {
        Console.WriteLine("The speed of the Tesla is 320 Km/Hr");
    }
}
class App {
    public static void Main(string[] args)
    {
        Mustang m = new Mustang();
        m.Start();
        m.Speed();
        

        Tesla tesla = new Tesla();
        tesla.Start();
        tesla.Speed();
        
    }
}