using System;
class Program
{
    static void Main(string[] args)
    {
        string equipLocal, equipVisitant;
        int golsLocal, golsVisitant;

        equipLocal = "Girona FC";
        golsLocal = 3;

        equipVisitant = "FCB";
        golsVisitant = 3;


        Console.WriteLine(InformeResultat(equipLocal, golsLocal, equipVisitant, golsVisitant));
    }
    /// <summary>
    /// Funciona que segons el resultat de gols diu si empata, perd o guanya
    /// </summary>
    /// <param name="equipLocal">nom equip local</param>
    /// <param name="golsLocal">gols del equip local</param>
    /// <param name="equipVisitant">nom equip visitant</param>
    /// <param name="golsVisitant">gols equip visitant</param>
    /// <returns>resultat del partit</returns>
    public static string InformeResultat(string equipLocal, int golsLocal, string equipVisitant, int golsVisitant)
    {
        if (golsLocal == golsVisitant)
            return $"{equipLocal} ha empatat amb {equipVisitant}";

        else if (golsLocal > golsVisitant)
            return $"{equipLocal} ha guanyat a {equipVisitant}";

        else
            return $"{equipLocal} perd contra {equipVisitant}";
    }
}


//Programa que demani per teclat un any i retorni a quin segle pertany