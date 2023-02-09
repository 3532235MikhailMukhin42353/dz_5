/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int elements = new Random().Next(5, 21);
int[] myArray = new int[elements];
FillArray(myArray);
PrintArray(myArray);
PrintChetyie(myArray);

void FillArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] myArray)
{
    Console.WriteLine($"Массив заполнен {elements} числами: ");
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + "\t");
    }
    Console.WriteLine();
}

void PrintChetyie(int[] myArray)
{
    int chet = 0;
    int nechet = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0) chet++;
        else nechet++;
    }
    Console.WriteLine($"В данном массиве чётных чисел {chet}, а нечётных {nechet}.");
}
