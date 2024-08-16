namespace ChallengeCSharp;

class Program
{
    static void Main()
    {
        Exercise_1 exercise = new Exercise_1();

        exercise.Welcome();

        Console.WriteLine();

        Exercise_2 exercise2 = new Exercise_2();

        exercise2.FullName();

        Console.WriteLine();


        Exercise_3 exercise3 = new Exercise_3();

        try
        {
            Console.WriteLine("Digite o primeiro número:");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double value2 = Convert.ToDouble(Console.ReadLine());

            exercise3.Sum(value1, value2);

            exercise3.Subtraction(value1, value2);

            exercise3.Multiplication(value1, value2);

            if (value2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida");
            }
            else
            {
                exercise3.Division(value1, value2);
            }

            exercise3.Average(value1, value2);

        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, insira números válidos.");
        }

        Console.WriteLine();


        Exercise_4 exercise4 = new Exercise_4();

        exercise4.NumberCharacters();

        Console.WriteLine();


        Exercise_5 exercise5 = new Exercise_5();

        exercise5.VehiclePlate();

        Console.WriteLine();


        Exercise_6 exercise6 = new Exercise_6();

        exercise6.CurrentDate();
    }


}