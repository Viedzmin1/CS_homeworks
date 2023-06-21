// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


string GetNumbersRec(int num)
{
    if (num == 0)  return "";
    return num + " " + GetNumbersRec(num-1);    
}


System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetNumbersRec(num));
