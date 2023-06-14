// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = i+j;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

int[] CheckNumber(int[,] array, int num)
{
    int iFind = 0;
    int jFind = 0;
    int indexes = massive[iFind, jFind];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        if (num == array[i,j])
        {
            int iFind = i;
            int jFind = j;
        }
        else
        System.Console.WriteLine($"Числа {num} нет в массиве"); 

        System.Console.WriteLine($"Координаты числа {num}: {iFind} , {jFind}");
        return new int[] {iFind, jFind};

}

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int NumIndexes = CheckNumber(array, num);
System.Console.WriteLine($"Координаты заданного числа: {NumIndexes}");


