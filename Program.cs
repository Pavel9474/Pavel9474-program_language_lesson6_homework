// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToArr(Console.ReadLine());
Console.Write(numbers);
SumPositive(numbers);
void SumPositive(int[] numbers)
{
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($" Положительных значений " + sum);
}
int[] StringToArr(string input)
{
    int count = 1;     //Считаем количество элементов, чтобы потом задать массив
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
        int[] numbers = new int [count]; //Задаем массив
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp =""; //Пустая стринговая переменная, сюда будут записываться числа
        while (input [i] != ',') //Важно чтобы цикл не выполнялся для разделителей чисел
        {
        if(i != input.Length - 1)
        {
            temp += input [i];
            i++;
        }
        else
        {
            temp += input [i];
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp); //Меняем тип данных
        index++;
    }
    return numbers;
}