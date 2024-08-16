namespace ChallengeCSharp;

public class Exercise_4
{
    public void NumberCharacters()
    {
        Console.WriteLine("Digite uma ou mais palavra para exibir o número de caracteres!");
        string? word = Console.ReadLine();

        if (word != null && word.Length > 0)
        {
            string noSpaces = word.Replace(" ", "");

            Console.WriteLine($"O número de caracteres inseridos sem espaços é: {noSpaces.Length}");
            Console.WriteLine($"O número de caracteres inseridos contando os espaços juntos é: {word.Length}");
        }
        else
        {
            Console.WriteLine("Nenhuma entrada foi inserida.");
        }
        //string numberCharacter = (word != null && word.Length > 0) 
        //    ? $"O número de caracteres inseridos é: {word.Replace(" ", "").Length}" 
        //    : "Nenhuma entrada foi inserida." ;

        //Console.WriteLine(numberCharacter);

    }

}
