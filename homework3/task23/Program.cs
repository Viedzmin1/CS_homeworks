// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string ThirdDegree (int N)
{
    int count = 1;
    int cube;
    string result = "";

    while (count <= N)
    {
        cube = count*count*count;
        result = result + " " + cube.ToString();
        count++;
    }
    return result;
}

System.Console.WriteLine("Введите какое-нибудь целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Таблица кубов числа {N}: {ThirdDegree (N)}");





