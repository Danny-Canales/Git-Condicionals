using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix una hora");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("Introdueix uns minuts");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Introdueix uns segons");
        int s = int.Parse(Console.ReadLine());
        string newHour = Incrementa1Segon(h, m, s);
        Console.WriteLine(newHour);

    }
    public static string Incrementa1Segon(int h, int m, int s)
    {
        string newHour;
        if (h > 23 || m > 59 || s > 59)
        {
            newHour = "Format no valid";
        }
        else if (h == 23 && m == 59 && s == 59)
        {
            newHour = $"Hora entrada inicialment --> {h:00}:{m:00}:{s:00}\nHora nova --> 00:00:00";
            h = 0;
            m = 0;
            s = 0;
        }
        else if (m == 59 && s == 59)
        {
            newHour = $"Hora entrada inicialment --> {h:00}:{m:00}:{s:00}\nHora nova --> {h:00+1}:00:00";
        }
        else if (s == 59)
        {
            newHour = $"Hora entrada Inicialment --> {h:00}:{m:00}:{s:00}\nHora nova --> {h:00}:{m:00+1}:00";
        }
        else
        {
            newHour = $"Hora entrada Inicialment --> {h:00}:{m:00}:{s:00}\nHora nova --> {h:00}:{m:00}:{s:00+1}";
        }
        return newHour;

    }
}