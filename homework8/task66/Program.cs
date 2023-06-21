// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Func(int M, int N)
{
    if (N == M) return M;
    return N + Func(M, N-1);
}


System.Console.WriteLine("Введите целое число M ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число N ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Func(M, N));
