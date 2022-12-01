/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Введите число > ");
int value1 = Convert.ToInt32(Console.ReadLine());

int EvaluatePower(int Number)
{
    int i = 0;
    while (Number > 0)
    {
    i++;
    Number = Number / 10;
    }
    return i;
}

int power = EvaluatePower(value1);
bool poly = false;
double symmetryHead = value1 / Math.Pow(10, power-1);
double symmetryEnd = value1 % 10;
if(Math.Truncate(symmetryHead) == Math.Truncate(symmetryEnd))
{
    poly = true;
    for(int i = 1; i < power/2; i++)
    {
        symmetryHead = (value1 / Math.Pow(10, power-i-1)) % 10;
        symmetryEnd = (value1 % Math.Pow(10, i+1)) / Math.Pow(10, i);
        if(Math.Truncate(symmetryHead) == Math.Truncate(symmetryEnd)) poly = true;
        else poly = false;
    }
}

if(poly) Console.WriteLine($"Число является полиндромом");
else Console.WriteLine($"Число не является полиндромом");
