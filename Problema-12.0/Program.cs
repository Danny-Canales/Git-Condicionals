using System;
class Program
{
    static void Main(string[] args)
    {
        int any = 2024;
        Console.WriteLine($"{AnyDeTraspas(any)}");
    }
    public static string AnyDeTraspas(int any)
    {
        string anyTraspas;
        if (any % 4 == 0 && any % 100 != 0 || any % 400 == 0)
        {
            anyTraspas = "Es any de traspas";
        }
        else
        {
            anyTraspas = "No es any de traspas";
        }
        return anyTraspas;
    }
}