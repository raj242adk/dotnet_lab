using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Rabindra Adhikari");
        Console.WriteLine("Enter Dividend");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Divisor");
        int num1 = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (num1 == 0)
            {
                throw new IOException("Please Enter a Number Except Zero");
            }
            else
            {
                var result = num / num1;
                Console.WriteLine("The Division is Successful: {0}/{1} = {2}", num, num1, result);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Exiting");
        }
    }
}
