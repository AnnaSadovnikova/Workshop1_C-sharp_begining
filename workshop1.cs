using System;

class Program
{
    static void Main() {
        //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        int numberfirst = 5;
        int numbersecond = 7;
        
        if (numberfirst > numbersecond)
        {
            Console.WriteLine("Smaller number: " + numbersecond);
            Console.WriteLine("Bigger number: " + numberfirst);
        }
        else
        {   
            Console.WriteLine("Smaller number: " + numberfirst);
            Console.WriteLine("Bigger number: " + numbersecond);
        }
        
        
        //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        int numberA = 2;
        int numberB = 3;
        int numberC = 7;
        int max = numberfirst;
        
        if (numberB > max)
        {
            max = numberB;
        }
        
        if (numberC > max)
        {
            max = numberC;
        }
        Console.WriteLine("Bigger number: " + max);
        
        
        //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        int number = 20;
        
        if (number%2 == 0)
        {
            Console.WriteLine("even number");
        }
        else
        {
            Console.WriteLine("uneven number");
        }
        
        //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        int N = 20;
        int count = 2;
        
        while (count <= N)
        {
            Console.Write(count + " ");
            count += 2;
        }
        Console.WriteLine();
    }
}