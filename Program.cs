﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// На этой ветке создадим метод для заполнения массива



void FillUserArray (string [] userArray)
{
    int length = userArray.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"Введите {i+1}-й элемент массива: ");
        userArray [i] = Console.ReadLine();
    }
// На этой ветке создаем метод для вывода элементов массива


void PrintArray (string [] printArray)
{
    int length = printArray.Length;
    Console.Write ("[");
    for (int i = 0; i < length-1; i++)
    {
        Console.Write (printArray[i]+", ");
    }
    Console.Write ($"{printArray[length-1]}]");
}