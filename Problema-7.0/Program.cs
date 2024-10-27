using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        int velocitat = 80;
        Console.WriteLine($"{ImportMulta(velocitat)}");
    }

    public static string ImportMulta(int velocitat)
    {
        //80Km/h - 99Km/h = 100€
        //100 Km/h a 129 Km/h (300€ de multa)
        //130 Km/h en endavant. (600€ de multa) i retirada de carnet
        int multa = 0;

        if (velocitat >= 80 && velocitat <= 99)
        {
            multa += 100;
            return $"La seva velocitat es de:\t{velocitat}Km/h\nLa seva multa es de:\t\t{multa}€";
        }
        else if (velocitat >= 100 && velocitat <= 129)
        {
            multa += 300;
            return $"La seva velocitat es de:\t{velocitat}Km/h\nLa seva multa es de:\t\t{multa}€";
        }
        else if (velocitat >= 130)
        {
            multa += 600;
            return $"La seva velocitat es de:\t{velocitat}Km/h\nLa seva multa es de:\t\t{multa}€\nEl seu carnet sera retirat";
        }
        else
        {
            return $"La seva velocitat no esta en el rang per ser multat :3";
        }
    }
}