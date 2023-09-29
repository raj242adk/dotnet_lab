
    public interface IAdd
    {
        void Add(int a, int b);
    }

    public interface Isub
    {
        void Sub(int a, int b);
    }

    public interface Imul
    {
        void Mul(int a, int b);
    }

    public interface Idiv
    {
        void Div(int a, int b);
    }
public class Calculator : IAdd, Isub, Imul, Idiv
{
    public int resultAdd;
    public int resultSub;
    public int resultMul;
    public int resultDiv;

    public void Add(int a, int b)
    {
        resultAdd = a + b;
    }

    public void Sub(int a, int b)
    {
        resultSub = a - b;
    }
    public void Mul(int a, int b)
    {
        resultMul = a * b;
    }

    public void Div(int a, int b)
    {
        resultDiv = a / b;
    }


    public class MainClass
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.Add(5, 6);
            calculator.Sub(7, 6);
            calculator.Mul(8, 6);
            calculator.Div(9, 6);

            Console.WriteLine("The addition of the two number is " + calculator.resultAdd);
            Console.WriteLine("The subtraction of the two number is " + calculator.resultSub);
            Console.WriteLine("The multiplaction of the two number is " + calculator.resultMul);
            Console.WriteLine("The division of the two number is " + calculator.resultDiv);
            Console.WriteLine("By Rabindra Adhikari");



        }
    }
}
