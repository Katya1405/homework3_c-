// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
int result = 0;
while (number > 0)
{
    result = number % 10;
    sum = sum + result;
    number = number / 10;
}
Console.WriteLine("Сумма цифр в числе = " + sum);