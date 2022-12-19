﻿/*
Итерация - повторение какого-либо действия

Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8

*/

void WaitSeconds(double sec)
{
    System.Threading.Thread.Sleep((int)(sec * 1000));
};

while (true)
{
    Console.Clear();

    Console.WriteLine(
        "Задача №7. Напишите программу, которая принимает на вход трёхзначное число\n" +
        "и на выходе показывает последнюю цифру этого числа.\n"
    );

    Console.Write("Введите целое трехзначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = a;

    if(b < 0){
        b *= -1;
    };
    
    if ((b < 100 || b >= 1000))
    {
        Console.WriteLine($"Вы ввели НЕ трехзначное число, ваше число: {a}. Попробуйте еще раз!");
        WaitSeconds(3);
    }
    else
    {
        Console.WriteLine($"{b % 10}");
        break;
    };
};
