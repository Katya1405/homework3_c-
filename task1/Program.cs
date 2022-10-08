// Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
int B = int.Parse(Console.ReadLine());
int A = 1;
while(A<=B)
{
    double result = Math.Pow(A,3);
    Console.WriteLine("Куб " + A + " = " + result);
    A++;
}