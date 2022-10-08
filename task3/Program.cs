// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int A = 1;
int avg = 1;
while (A <= N)
{
    avg = avg * A;
    A++;
}
Console.WriteLine(avg);