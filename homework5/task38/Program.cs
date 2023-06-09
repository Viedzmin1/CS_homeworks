// // Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

double FindMax(double[] array)
{
   
   double max = array[0];   
   for (int i = 0; i < array.Length; i++)
   {
    if (array[i] > max)
    {
        max = array[i];
    }    
   } 
   return max;
}

double FindMin(double[] array)
{
   
   double min = array[0];   
   for (int i = 0; i < array.Length; i++)
   {
    if (array[i] < min)
    {
        min = array[i];
    }    
   } 
   return min;
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
PrintArray(array);
double max = FindMax(array);
double min = FindMin(array);
double diff = max - min;
System.Console.WriteLine($"Максимальный элемент массива равен: {max}");
System.Console.WriteLine($"Минимальный элемент массива равен: {min}");
System.Console.WriteLine($"Разница между максимальным и минимальными элементами массива равна: {diff}");



// void PrintArray(double[] array)
// {
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// double[] array = {2, 6, 8, 7, 3, 5};

//     double min = array[0];
//     double max = array[0];
//     double result = max - min;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//         else if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
   
//    double diff = max - min;
   
//    PrintArray(array);
//    System.Console.WriteLine($"{max}");
//    System.Console.WriteLine($"{min}");
//    System.Console.WriteLine($"{diff}");
