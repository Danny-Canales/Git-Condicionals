using System;
class Program
{/// <summary>
/// Pograma que dona la nota qualitativa d'un alumne nota examen 80% i nota practica 20%
/// </summary>
/// <param name="args"></param>
    static void Main(string[] args)
    {
        double notaExamen = 5;
        double notaPractiques = 10;

        Console.WriteLine($"{NotaQualitativa(notaExamen, notaPractiques)}");
    }

    public static string NotaQualitativa(double notaExamen, double notaPractiques)
    {
        //Compara que la nota no sigui major que 10 
        if (notaExamen > 10 || notaPractiques > 10)
            return "Nota no valida es major que 10";
        // Compara que la nota no sigui menor que 3
        if (notaExamen < 3 || notaPractiques < 3)
            return $@"La nota qualitativa es supes, les seves notes:
                            Examen Practiques 
                            {notaExamen}      {notaPractiques}";

        double notaFinal = (notaExamen * 0.8) + (notaPractiques * 0.2);

        if (notaFinal >= 9 && notaFinal <= 10)
            return $"Exel·lent\tLa seva nota: {notaFinal:F2}";

        else if (notaFinal >= 7 && notaFinal < 9)
            return $"Notable\t\tLa seva nota: {notaFinal:F2}";

        else if (notaFinal >= 5 && notaFinal < 7)
            return $"Aprovat\t\tLa seva nota: {notaFinal:F2}";

        else
            return $"Suspes\t\tLa seva nota: {notaFinal:F2}";
    }
}