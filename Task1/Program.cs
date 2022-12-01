/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Введите пятизначное число > ");
int value1 = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int Number)
{
    if(Number >=10000 && Number < 1000000)
    {
        return true;
    }

    System.Console.WriteLine($"Число не пятизначное");
    return false;
}

if(ValidateNumber(value1))
{
    if(value1/10000 == value1%10 && (value1/1000)%10 == (value1%100)/10 ) System.Console.WriteLine($"Число {value1} является палиндромом");
    else System.Console.WriteLine($"Число {value1} не является палиндромом");
}