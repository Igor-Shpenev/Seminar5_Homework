// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateNewArray(int a)
{
    int[] array = new int[a];

    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(100, 1000);               // Наполняем массив рандомными числами от 100 до 999
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");                        // Выводим элементы массива на экран
    }

}
int SumEvenNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count ++;                                    // Суммируем кол-во четных элементов массива
        }
    }
    return count;
}

Console.Write("Input lenght of array: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myarr = CreateNewArray(num);   // Создаем новый массив                              
PrintArray(myarr);
int sum = SumEvenNumbers(myarr);
Console.WriteLine($"The number of even numbers in the array is {sum}");



