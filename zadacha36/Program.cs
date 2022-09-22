// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Задайте массив: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
int sum = 0;

 for (int i = 0; i < array.Length; i++)
if (array[i] % 2 != 0)
    sum = sum + array[i];

    Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
        }
}
void PrintArray(int[]array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}