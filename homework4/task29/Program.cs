// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void Array(int amount)
{
    int [] numbers = new int [amount];
    Random rand = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next(100);
        Console.Write(numbers[i] + " ");
    }
}

System.Console.WriteLine("Введите количество элементов массива");
int amount = Convert.ToInt32(Console.ReadLine());
Array(amount);