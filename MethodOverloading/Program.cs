using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        public void display()
        {
            System.Console.WriteLine("Hello From Rabindra");
        }
        public void display(string message)
        {
            System.Console.WriteLine(message);
        }
        public void display(int a)
        {
            System.Console.WriteLine("The value is");
        }

        public static void main(string[] args)
        {
            Program p = new Program();
            p.display();
            p.display("Hi");
            p.display(19121);
        }


    }
}
