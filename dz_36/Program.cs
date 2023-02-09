/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях. [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0*/

Console.Write("Введите количество элементов в массиве: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elements];
FillArray(myArray);
PrintArray(myArray);
PrintSumElements(myArray);

void FillArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-1000, 1001);
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

void PrintSumElements(int[] myArray)
{
    int chet = 0;
    int nechet = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (i % 2 == 0) chet = chet + myArray[i];
        else if (i % 2 != 0) nechet = nechet + myArray[i];
    }
    Console.WriteLine($"Сумма чисел на чётных индексах = {chet}, а на нечётных = {nechet}.");
}
