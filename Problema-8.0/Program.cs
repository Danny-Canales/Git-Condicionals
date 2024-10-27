using System;
class Program
{/// <summary>
/// Programa que demana una hora en format hh:mm:ss i diu si es valida o no
/// </summary>
/// <param name="args"></param>
    public static void Main(string[] args)
    {
        int hora = 150000;

        int residu;
        int minut, segon;
        residu = hora % 10000;
        hora /= 10000;
        minut = residu / 100;
        segon = residu % 100
        Console.WriteLine($"La hora es: {ValidarHora(hora, minut, segon)}");
    }
    public static bool ValidarHora(int hora, int minut, int segon)
    {

        if (hora >= 24 || hora < 0)
        {
            Console.WriteLine("La hora no es valida");
            return false;
        }
        else if (minut > 59 || minut < 0)
        {
            Console.WriteLine("Els minuts no són valids");
            return false;
        }
        else if (segon > 59 || segon < 0)
        {
            Console.WriteLine("Els segons no són valids");
            return false;
        }
        else
        {
            Console.WriteLine("la hora es correcte");
            return true;
        }
    }
}