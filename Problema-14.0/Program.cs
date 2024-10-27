using System;
class Program
{
    static void Main(string[] args)
    {
        int number = 3737;
        int residu;
        int firstDigit, secondDigit, thirdDigit, fourthDigit;
        residu = number % 1000;
        firstDigit = number / 1000;
        secondDigit = residu / 100;
        residu %= 100;
        thirdDigit = residu / 10;
        fourthDigit = residu % 10;

        Console.WriteLine(CapCua(firstDigit, secondDigit, thirdDigit, fourthDigit));
    }
    public static string CapCua(int firstDigit, int secondDigit, int thirdDigit, int fourthDigit)
    {
        string esCapCua;
        if (firstDigit == fourthDigit && secondDigit == thirdDigit)
        {
            esCapCua = $"Es Cap i Cua {firstDigit} {secondDigit} {thirdDigit} {fourthDigit}";
        }
        else
        {
            esCapCua = $"No es Cap i Cua {firstDigit} {secondDigit} {thirdDigit} {fourthDigit}";
        }
        return esCapCua;
    }
}