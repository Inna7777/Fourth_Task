﻿ //Напишите программу, которая задаёт массив 
 //из 8 элементов и выводит их на экран.
 int[] arr = new int[8];
void PrintArray(int[] arr)
{
         for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1 , 99);
        Console.Write($"{arr[i]}, ");     
      }

       }   
PrintArray(arr);
Console.WriteLine();