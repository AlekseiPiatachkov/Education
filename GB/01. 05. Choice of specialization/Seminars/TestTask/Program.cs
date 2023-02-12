﻿
Run();


void Run(){
    string rn = "\n";
    string title = 
        $"Контрольная работа.{rn}"+
        $"Задача:{rn}"+
        $"Напишите программу, которая из имеющегося массива строк формирует массив из строк,{rn}"+
        $"длина которых меньше либо равна 3 символам.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"['hello', '2', 'world', ':-)'] -> ['2', ':-)']{rn}"+
        $"['1234', '1567', '-2', 'computer science'] -> ['-2']{rn}"+
        $"['Russia', 'Denmark', 'Kazan'] -> []{rn}";


    ViewTitleTask(title);
    
    Console.Clear();


    Console.WriteLine(); 
};


// ViewTitleTask version 2.1
void ViewTitleTask(string? text = ""){
    string rn = "\n";
    Console.Clear();
    Console.WriteLine(
        $"{text}{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}{rn}"+
        $"Press any key to continue..."
    );
    Console.ReadKey();
    Console.Clear();
};
