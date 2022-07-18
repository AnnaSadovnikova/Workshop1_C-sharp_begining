using System;

class Program
{
    static void Main() {
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        //Nahodit Oshibku - jdoodle.cs(21,246): error CS1525: Unexpected symbol `end-of-file'
        
        int number = 23532;
        int digitOnes = number%10;
        int digitTens = number/10%10;
        int digitThousands = number/1000%10;
        int digitTenOfThounds = number/10000;
        
        if (digitOnes == digitTenOfThounds && digitTens == digitThounds)
        {
            Console.WriteLine("eto palindrom");
        }
        else 
        {
            Console.WriteLine("eto ne palindrom");
        }    
}