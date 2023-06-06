// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}


int SummOddIndex(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            result = result + array[i];
        }
    }
    return result;
    }


Console.Clear();
System.Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
int count = SummOddIndex(array);
System.Console.WriteLine($"Сумму элементов массива, стоящих на нечетных индексах равна: {count}");
