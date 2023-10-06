using System;
using System.Linq;
using System.Runtime.CompilerServices;
namespace HW_S2;
public static class Program 
{
    static void Main(string[] args)
    {
        //Задача 10
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());
        int n = GetSecondDigit(num);
        Console.WriteLine(n);
        Console.WriteLine("Нажмите любую кнопку");
        Console.ReadKey(true);
        //Задача 13
        Console.WriteLine("Введите число");
        int numA = Convert.ToInt32(Console.ReadLine());
        while (numA < 99) 
            {
                Console.WriteLine ("Число не трехзначное!");
                Console.WriteLine("Введите число");
                numA = Convert.ToInt32(Console.ReadLine());
            }
        while (numA > 999) 
            {
                Console.WriteLine ("Число не трехзначное!");
                Console.WriteLine("Введите число");
                numA = Convert.ToInt32(Console.ReadLine());
            }
        int nA = GetThirdDigit(numA);
        Console.WriteLine(nA);
        Console.WriteLine("Нажмите любую кнопку");
        Console.ReadKey(true);
        //Задача 15: Программа, принимает число и выводит день недели соответсвующий введеному числу.
        Console.WriteLine("Введите число");
        int day = Convert.ToInt32(Console.ReadLine());
        day = day --;
        string [] weekDay = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        Console.WriteLine(weekDay[day]);
        Console.WriteLine("Нажмите любую кнопку");
        Console.ReadKey(true);
    }
     //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    static int GetSecondDigit(int n1)
    {
        while (n1 >= 100) n1 /= 10;
        int n = n1 % 10;
        return n;
    }
    //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    static int GetThirdDigit(int n1)
    {
        while (n1 >= 1000) n1 /= 10;
        int nA = n1 % 10;
        return nA;
    }
} 