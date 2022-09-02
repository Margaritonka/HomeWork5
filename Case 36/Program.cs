// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = FillArray(10);

int []  FillArray(int N)
{
int [] array = new int[N];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(-20,20);
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

int FindSumPos()
{
int i = 0;
int sum = 0;
while (i < array.Length)
{
    if (i%2 == 1)
    {
        sum+=array[i];
    }
i++;
}
return sum;
}

Console.WriteLine($"Сумма цифр на нечётных позициях =  {FindSumPos()} ");