using System;

class Program
{
    static void Main() {
        // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        
        int number = 7;
        if (number == 6 || number == 7)
        {
            Console.WriteLine("Weekend");
        }
        else if (number > 7 || number < 1)
        {
            Console.WriteLine("error");
        }
        else Console.WriteLine("Not weekend");



    }
}