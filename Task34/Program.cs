// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateNewArray(int a)
{
    int[] array = new int[a];

    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }

}
int SumEvenNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += arr[i];
        }
    }
    return count;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myarr = CreateNewArray(num);
PrintArray(myarr);
int sum = SumEvenNumbers(myarr);
Console.WriteLine($" Sum of the even numbers of the array is {sum}");



