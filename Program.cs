﻿using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de la variable X1
        Console.Write("Ingrese X1: ");
        double x1 = double.Parse(Console.ReadLine());

        // Entrada del usuario de la variable Y1
        Console.Write("Ingrese Y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese X2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese Y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double m = (y2 - y1) / (x2 - x1);
        Console.WriteLine("la pendiente es:" + m);

        double b = y1 - (m * x1);
        Console.WriteLine("el intercepto es:" + b);

        double a = (x2 - x1) * (y2 - y1);
        double d = Math.Sqrt(a);
        Console.WriteLine("distancia:" + a);



        // Entrada del usuario de las variables restantes
        // ...
    }
}