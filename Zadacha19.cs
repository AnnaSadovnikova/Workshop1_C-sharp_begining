using System;

class Program
{
    static void Main() {
         //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        
        
        int number = 23532;
        int digitOnes = number%10;
        int digitTens = number/10%10;
        int digitThousands = number/1000%10;
        int digitTenOfThousands = number/10000;
        
        if (digitOnes == digitTenOfThousands && digitTens == digitThousands)
        {
            Console.WriteLine("eto palindrom");
        }
        else 
        {
            Console.WriteLine("eto ne palindrom");
        } 
    }
}