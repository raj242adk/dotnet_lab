using System;

namespace MethodOverload
{

    class Program
    {

        void display()
        {
            System.Console.WriteLine("Hello from Rabindra Adhikari");
        }

        // method with one parameter
        void display(int a)
        {
            Console.WriteLine("Arguments: " + a);
        }

        // method with two parameters
        void display(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
        static void Main(string[] args)
        {

            Program p1 = new Program();
            p1.display();
            p1.display(19121);
            p1.display(100, 200);
            
            Console.ReadLine();
        }
    }
}