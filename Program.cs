// Не используя рекурсию, выведите
//первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToInt32(Console.ReadLine());
}
int N = GetNumber("N");
void Fibonachi(int N)
{
    int num1=0;
    int num2=1;
    int num3=0;
    Console.Write("0 1 ");
    for (int i = 2; i <= N-1; i++)
    {
        num3=num1+num2;
        num1=num2;
        num2=num3;
        Console.Write(num2 + " ");
    }
}
Fibonachi(N);