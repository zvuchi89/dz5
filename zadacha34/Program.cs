// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

Console.WriteLine("Задайте массив: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");

void InputArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}