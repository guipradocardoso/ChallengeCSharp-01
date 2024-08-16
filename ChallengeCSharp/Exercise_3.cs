namespace ChallengeCSharp;

public class Exercise_3
{
    public void Sum(double a, double b)
    {
        double result = a + b;

        Console.WriteLine($"A soma dos dois números é: {result}");
    }

    public void Subtraction(double a, double b)
    {
        double result = a - b;

        Console.WriteLine($"A subtração dos dois números é: {result}");
    }

    public void Multiplication(double a, double b)
    {
        double result = a * b;

        Console.WriteLine($"A multiplicação dos dois números é: {result}");
    }

    public void Division(double a, double b)
    {
        double result = a / b;
        Console.WriteLine($"A divisão dos dois números é: {result}");

    }

    public void Average(double a, double b)
    {
        double result = (a + b) / 2;
        Console.WriteLine($"A média dos dois números é: {result}");

    }


}
