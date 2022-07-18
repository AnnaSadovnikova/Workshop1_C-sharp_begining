using System;

class Program
{
    static void Main() {
         //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        
        int Ax = 6;
        int Ay = 7;
        int Bx = 14;
        int By = 22;
        
        double distance = Math.Sqrt(Math.Pow(Ax-Bx, 2) + Math.Pow(Ay -By, 2));
        Console.WriteLine(distance);
    }
}