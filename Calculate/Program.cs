using Calculates;
class Program
{
    static void Main(string[] args)
    {
        Calculate _calculate = new();
        Console.WriteLine("Введите числа, а потом символ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        switch (char.Parse(Console.ReadLine()))
        {
            case '+':
                Console.WriteLine(_calculate.Sum(num1, num2));
                break;
            case '*':
                Console.WriteLine(_calculate.Mul(num1, num2));
                break;
            case '/':
                Console.WriteLine(_calculate.Div(num1, num2));
                break;
            case '-':
                Console.WriteLine(_calculate.Sub(num1, num2));
                break;

        }
    }
}
