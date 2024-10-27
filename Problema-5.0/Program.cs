using System;
class Program
{
    /// <summary>
    /// Programa que diu si un numero entrat per teclat es parell o no i si es multiple de 7 o no
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        int numero;
        bool parell, multiple;
        Console.WriteLine("Introdueix un nombre");
        numero = int.Parse(Console.ReadLine());

        if (EsParell(numero))
            Console.WriteLine("Es parell");
        else
            Console.WriteLine("No es parell");

        if (EsMultiple(numero))
            Console.WriteLine("Es multiple de 7");
        else
            Console.WriteLine("No es multiple de 7");

    }

    /// <summary>
    /// Funcio que comprova si un numero es parell o no
    /// </summary>
    /// <param name="numero">Numero entrat per pantalla</param>
    /// <returns>si es parell o no</returns>
    public static bool EsParell(int numero)
    {
        return numero % 2 == 0; ;
    }
    /// <summary>
    /// Funcion que comproba si un numero es multiple de 7
    /// </summary>
    /// <param name="numero">Numero entrat</param>
    /// <returns>Si es multiple de 7 o no</returns>
    public static bool EsMultiple(int numero)
    {
        return numero % 7 == 0;
    }
}