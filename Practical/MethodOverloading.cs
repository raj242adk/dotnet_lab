using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    internal class MethodOverloading
    {
        //Method display with no parameter
        public void display()
        {
            System.Console.WriteLine("Hello By Rabindra Adhikari");
        }
        public void display(string message)
        {
            System.Console.WriteLine(message);
        }
        public void display(int a)
        {

            System.Console.WriteLine("The value of a is" + a);
        }
        public static void main(string[] args)
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.display();
            methodOverloading.display(1);
            methodOverloading.display("Hello once Again");
        }
    }
}
