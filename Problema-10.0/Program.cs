using System;
class Program
{
    static void Main(string[] args)
    {
        // Segle     Anys
        // XVIII     [1701-1800]
        // XIX       [1801-1900]
        // XX        [1901-2000]
        // XXI       [2001-2100]
        int any;
        Console.WriteLine("Introdueix un any 1701 - 2100 --> ");
        any = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Segle(any)}");
    }
    public static string Segle(int any)
    {
        if (any >= 2001 && any <= 2100)
            return "Pertany al segle XXI";
        else if (any >= 1901 && any <= 2000)
            return "Pertany al segle XX";
        else if (any >= 1801 && any <= 1900)
            return "Pertany al segle XIX";
        else if (any >= 1701 && any <= 1800)
            return "Pertany al segle XVIII";
        else
            return "Aquest anys no esta a la meva base de dades";
    }
}