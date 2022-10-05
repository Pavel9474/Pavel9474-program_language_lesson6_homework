// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}
void GetCross(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1!=k2 && b1!=b2)
    {
        x=(b2-b1)/(k1-k2);
        y=k1*(b2-b1)/(k1-k2)+b1;
        Console.WriteLine("Точка пересечения прямых имеет следующие координаты: (" +  x + "; " + y +")");
    }
    else if (k1==k2 && b1==b2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Прямые параллельны");
}
double b1 = GetNumber("b1");
double k1 = GetNumber("k1");
double b2 = GetNumber("b2");
double k2 = GetNumber("k2");
GetCross(b1, k1, b2, k2);
