using System.Runtime.CompilerServices;

public class BasicProgramming
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
        var name = "Uma";
        Console.WriteLine("Hello " + name);
        int num1 = 19;
        int num2 = 32;
        Console.WriteLine(num1 * num2);
        int result = addTowNumbers(45, 15);
        Console.WriteLine("Result is : " + result);
    }

    public static int addTowNumbers(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
        return num1 + num2;
    }
}
