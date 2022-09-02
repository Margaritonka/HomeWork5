// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [,] array = FillArray(5,5);

double [,]  FillArray(int N, int A)
{
double [,] array = new double[N,A];
for (int i = 0; i < 5; i++) 
{
    for (int j = 0; j < 5; j++)
    {
        array[i,j] = Math.Round (new Random().NextDouble()*100, 3);
    }
}
return array;
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
        Console.Write($"{array[i,j]}    ");
        }
    }
}

PrintArray(array);
Console.WriteLine();

double [] Max()
{
    double max = array[0,0];
    for (int i = 1; i <5; i++)
    {
        for (int j = 1; j <5; j++)
        {
            if (array[i,j] > max)
            max = array[i,j];
        }
    }

    double min = array[0,0];
    for (int i = 1; i < 5; i++)
    {
        for (int j = 1; j < 5; j++)
        {
            if (array[i,j] < min)
            min = array[i,j];
        }
    }
double [] answer = {max, min};
return answer;
}
Console.WriteLine();
double [] answer = Max();

Console.WriteLine($"Максимальный элемент массива - {answer[0]} ");
Console.WriteLine($"Минимальный элемент массива - {answer[1]} ");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {answer[0]} - {answer[1]} = {answer[0] - answer[1]} ");
