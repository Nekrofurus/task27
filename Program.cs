// Задача 27 Написать программу, которая принимает число и  выдает сумму цифр в числе
Console.Write("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
int SummNumbers(int num)
{
    int summ = 0;
    if(numberA > 0)
    while (num / 10 > 0)
    {
        summ = summ + num % 10;
        num = num / 10;
    }
   else
{
    num = num * -1;
     while (num / 10 > 0)
    {
        summ = summ + num % 10;
        num = num / 10; 
    }
}
return summ;
}
int summNumbers = SummNumbers(numberA);
Console.WriteLine($"Сумма цифр числа {numberA} = {summNumbers}");