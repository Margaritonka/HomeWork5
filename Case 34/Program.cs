// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = FillArray();

int []  FillArray()
{
int [] array = new int[30];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(100,1000);
}
return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

PrintArray(array);
Console.WriteLine();

int Find()
{
int i = 0;
int count = 0;
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
i++;
}
return count;
}
Console.WriteLine($"Количество четных чисел в массиве  = {Find()} ");