int a = 2, b = 3;
int add_result = Calculator.add(a,b);
System.Console.WriteLine($"{a} + {b} = {add_result}");

static class Calculator
{
    public  static int add(int a, int b)
    {
        return a + b;
    }
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}