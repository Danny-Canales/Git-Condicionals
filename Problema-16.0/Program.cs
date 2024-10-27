using System;
class Program
{
    static void Main(string[] args)
    {
        int any = 12;
        bool anyTraspas = AnyDeTraspas(any);
        bool festivalBulukulu = EsAnyFestivalBulukulu(any);
        for (int i = 0; i < 10000; i++)
        {
            if (AnyDeTraspas(i) && EsAnyFestivalHulukulu(i) && EsAnyFestivalBulukulu(i))
            {
                Console.WriteLine($"{i} es any traspas bulukulu y hulukulu");
            }
        }

        // if (!anyTraspas && !festivalHulukulu)
        //Console.WriteLine("Es un any normal");
        //else if (!anyTraspas &&festivalHulukulu)
        //Console.WriteLine("Es any festival hulukulu");
        //else    
        //  if(anyTraspas)
        // Console.WriteLine("Es un any de trapas");
        // if(festivalBulukulu)
        //   Console.WriteLine("Es un any bulukulu");
    }
    /// <summary>
    /// Funcio que retorna true si es un any de trapas
    /// </summary>
    /// <param name="any"></param>
    /// <returns></returns>
    public static bool AnyDeTraspas(int any)
    {
        return any % 4 == 0 && any % 100 != 0 || any % 400 == 0;
    }

    /// <summary>
    /// Funcio que retorna true si es festival hulukulu
    /// </summary>
    /// <param name="any"></param>
    /// <returns></returns>
    public static bool EsAnyFestivalHulukulu(int any)
    {
        return any % 15 == 0;
    }
    /// <summary>
    /// Calcula si es bulukulu
    /// </summary>
    /// <param name="any"></param>
    /// <returns></returns>
    public static bool EsAnyFestivalBulukulu(int any)
    {
        bool esAnyTraspas = AnyDeTraspas(any);
        return any % 55 == 0 && esAnyTraspas;
    }
}