// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num>100)
    {
        double razr = Math.Log10(num);
        int i = 1;
        while (i<razr-2)
        {
            num = num/10;
            i++;
        }
        num = num%10;
        System.Console.WriteLine($"третье число равно  {num}");
    }
    else
            System.Console.WriteLine($"в числе {num} нет третьей цифры");
