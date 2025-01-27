﻿/*
Задача №17. 
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

*/

//int X =  new Random().Next(-10, 10);
//int y =  new Random().Next(-10, 10);

// процедура
void PrintCord(int x, int y){
    if(x == 0 || y == 0){
        Console.WriteLine($"Точка с координатами x: {x} и y: {y} находится вне четвертей");
    }else if(x > 0){
        if(y > 0){        
            Console.WriteLine($"Точка с координатами x: {x} и y: {y} находится в 1й четверти");
        }else if(y < 0){
            Console.WriteLine($"Точка с координатами x: {x} и y: {y} находится в 4й четверти");
        };
    }else if(x < 0){
        if(y > 0){        
            Console.WriteLine($"Точка с координатами x: {x} и y: {y} находится в 2й четверти");
        }else if(y < 0){
            Console.WriteLine($"Точка с координатами x: {x} и y: {y} находится в 3й четверти");
        };
    };
};


Console.Clear();
Console.Write("Введите X: ");
int cordX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int cordY = Convert.ToInt32(Console.ReadLine());

PrintCord(cordX, cordY);
PrintCord(new Random().Next(-10, 10), new Random().Next(-10, 10));


