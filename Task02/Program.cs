//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int number)
{
    
    int sum = 0;
       while (number > 0)
    {
      sum = sum + number%10;
      number = number / 10;
    }
    return sum;
}
int sum = SumNum(number);
Console.WriteLine($"Сумма цифр = {sum}");
