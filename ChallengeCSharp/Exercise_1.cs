namespace ChallengeCSharp;

public class Exercise_1
{
    public void Welcome()
    {
        Console.WriteLine("Digite seu Nome:");

        string? name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}
