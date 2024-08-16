using System.Text.RegularExpressions;

namespace ChallengeCSharp;

public class Exercise_5
{
    public void VehiclePlate()
    {
        Console.WriteLine("Digite a placa de um veículo (Exatamente 7 caracteres):");

        string? plate = Console.ReadLine();

        if (plate != null && plate.Length == 7)
        {
            bool isValid = IsPlateValid(plate);
            
            Console.WriteLine(isValid ? "Verdadeiro" : "Falso");
        }
        else
        {
            Console.WriteLine("A placa deve ter no máximo 7 caracteres");
        }
    }

    public static bool IsPlateValid(string plate)
    {
        
        string pattern = @"^[A-Z]{3}\d{4}$";
        
        return Regex.IsMatch(plate, pattern, RegexOptions.IgnoreCase);


    }

}
