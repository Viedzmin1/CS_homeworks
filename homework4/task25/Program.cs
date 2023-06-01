// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int exponentiation (int NumA, int NumB)
{
int result = NumA;
for (int i = 1; i < NumB; i++)
{
    result = result*NumA;
}

return result;
}

System.Console.WriteLine("Введите число A");
int NumA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int NumB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(exponentiation (NumA, NumB));

