/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write("Введите количество элементов в массиве: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elements];
FillArray(myArray);
PrintArray(myArray);
PrintRaznitca(myArray);

void FillArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(0, 1001);
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

void PrintRaznitca(int[] myArray)
{
    int min = myArray[0];
    int max = myArray[1];
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] < min ) min = myArray[i];
        else if (myArray[i] > max ) max = myArray[i];
    }
    Console.WriteLine($"Мин значение в массиве = {min}, макс значение = {max}. Их разница равна {max-min}.");
}