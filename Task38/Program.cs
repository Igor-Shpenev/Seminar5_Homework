// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.[3.0 7.2 22.7 2.1 78.3] -> 76.2

double[] NewArray(int a)
{
    double[] array = new double[a];
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().NextDouble() * 10;         // Наполняем массив рандомными дробными числами от 0,00 до 1,00 умноженные на 10
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}, ");                  // Показываем элементы массива на экране
    }
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Minimum is {min}");                // Определяем и выводим на экран элемент массива с минимальным значением
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"Maximum is {max}");                 // Определяем и выводим на экран элемент массива с максимальным значением
    return max;
}

Console.Write("Input lenght array: ");                      // Просим пользователя указать кол-во элементов массива
int lenght = Convert.ToInt32(Console.ReadLine());
double[] RandomArray = NewArray(lenght);
PrintArray(RandomArray);
double DifferenceMaxMin = Max(RandomArray) - Min(RandomArray); // Вычисляем разницу между максимальным и минимальным значением       
Console.WriteLine($"The difference between the maximum and minimum value is {DifferenceMaxMin}");


