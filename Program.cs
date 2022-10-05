// Напишите программу, которая
// будет создавать копию заданного массива с
// помощью поэлементного копирования.
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,99);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
void Copyarray(int[] arr, int[] Copy)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Copy[i] = arr[i];
    }
}
int N=5;
int[] massiv = new int[N];
int[] Copy = new int [N];
FillArray(massiv);
PrintArray(massiv);
Copyarray(massiv, Copy);
PrintArray(Copy);