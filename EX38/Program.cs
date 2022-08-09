// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


float [] array = new float[4];

float min = 999;
float max = 0;
float difference = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,999);
    Console.Write(array[i] + " ");
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
difference = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {difference}" );