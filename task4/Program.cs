// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int number = 0;
while (number <= N)
{
    if (number % 2 == 0)
    {
        double result = Math.Pow(number, 3);
        Console.WriteLine("Куб числа " + number + " = " + result);
    }
    number++;
}