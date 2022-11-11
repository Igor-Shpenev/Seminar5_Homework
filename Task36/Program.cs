// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateNewArray(int a, int min, int max)
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(min, max + 1);         // Метод по наполнению массива рандомными числами
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)                    
    {
        Console.Write($"{arr[i]}, ");                       // Вывод на экран элементов массива
    }
}

int SumOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)               // Поиск элементов массива с нечетными индексами
    {
        sum += array[i];                                    // Суммирование значений элементов с нечетными индексами
    }
    return sum;
}

Console.Write("Input lenght array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum elemet of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum elemet of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateNewArray(lenght, min, max);                // Создание нового массива
PrintArray(arr);
Console.WriteLine($"Sum of the odd positions of the array is {SumOddIndexes(arr)}");