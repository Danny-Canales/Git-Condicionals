using System;
class Program
{
    static void Main(string[] args)
    {
        //Q1 = 0<0<90
        //Q2 = 90<0<80
        //Q3 = 180<0<270
        //Q4 = 270<0<360

        int angle;
        Console.WriteLine("Introdueix un angle: ");
        angle = int.Parse(Console.ReadLine());
        string posicio = Quadrant(angle);
        Console.WriteLine(posicio);
    }
    /// <summary>
    /// funcio que calcula en quin quadrant es troba un angle
    /// </summary>
    /// <param name="angle"> valor entrat per teclat</param>
    /// <returns></returns>
    public static string Quadrant(int angle)
    {
        string quadrant;
        if (angle < 0)
            angle += 360;

        if (angle >= 0 && angle <= 90)
            quadrant = "Estas al primer quadrant";
        else if (angle > 90 && angle <= 180)
            quadrant = "Estas al segon quadrant";
        else if (angle > 180 && angle <= 270)
            quadrant = "Estas al tercer quadrant";
        else if (angle > 270 && angle <= 360)
            quadrant = "Estas al quart quadrant";
        else
            quadrant = "angle no valid";
        return quadrant;
    }
}