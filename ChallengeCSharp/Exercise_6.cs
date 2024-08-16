namespace ChallengeCSharp;

public class Exercise_6
{
    public void CurrentDate()
    {
        DateTime now = DateTime.Now;

        string fullFormat = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine("Formato Completo");
        Console.WriteLine(fullFormat);
        Console.WriteLine();

        string dateOnly = now.ToString("dd/MM/yyyy");
        Console.WriteLine("Apenas a data no formato (00/00/0000)");
        Console.WriteLine(dateOnly);
        Console.WriteLine();

        string justTime = now.ToString("HH:mm");
        Console.WriteLine("Apenas a hora (00:00)");
        Console.WriteLine(justTime);
        Console.WriteLine();

        string dateWithMonthFull = now.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine("Data com o mês por extenso");
        Console.WriteLine(dateWithMonthFull);
        Console.WriteLine();

    }

}
