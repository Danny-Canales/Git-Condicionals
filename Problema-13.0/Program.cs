using System;
class Program
{
    static void Main(string[] args)
    {
        int number = 111;
        int residu;
        int firstDigit, secondDigit, thirdDigit;
        residu = number % 100;
        firstDigit = number / 100;
        secondDigit = residu / 10;
        thirdDigit = residu % 10;
        Console.WriteLine($"El numero {number}: {CapCua(firstDigit, secondDigit, thirdDigit)}");
    }
    public static string CapCua(int firstDigit, int secondDigit, int thirdDigit)
    {
        string esCapCua;
        if (firstDigit == thirdDigit)
            esCapCua = "Es Cap i Cua";
        else
            esCapCua = "No es cap i cua";
        return esCapCua;
    }
}