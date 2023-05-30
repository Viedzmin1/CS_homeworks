// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=1 && num<=7)
{
    if (num>5)
    {
        System.Console.WriteLine($"День недели номер {num} является выходным");
    }
    else 
    System.Console.WriteLine($"День недели номер {num} НЕ является выходным");
}
else 
    System.Console.WriteLine($"День недели номер {num} НЕ является днем недели");
