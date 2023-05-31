// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

    string Polindrom(int number)
    {
    int tmp_number = number;
    int reverse = 0;
    string result = "";    
    while(tmp_number!=0)
        {
        reverse = (reverse*10) + tmp_number%10;
        tmp_number/=10;
        }
        Console.WriteLine($"Обратное число равно {reverse}");
    if(number == reverse)
        {
        result="Введенное число является полиндромом";
        }
    else
        result="Введенное число не является полиндромом";
return result;
    }

    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(Polindrom(number));
    
    
    
    
    

