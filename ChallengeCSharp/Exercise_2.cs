namespace ChallengeCSharp;

public class Exercise_2
{
    public void FullName()
    {
        Console.WriteLine("Digite seu Nome: ");
        string? name = Console.ReadLine();

        Console.WriteLine("Digite seu Sobrenome: ");
        string? surname = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é: {name} {surname}!");
    }

}
