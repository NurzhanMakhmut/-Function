// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] createArray(int size, int min, int max)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}

// Console.Write("ведите размер массива: ");
int N = new Random().Next(2, 10);
int [] res = createArray (N, 100, 999);

Console.WriteLine($"Массив: [{string.Join(";", res)}]");
int sum = 0;
for (int i = 0; i < res.Length; i++)

{
    
    if (res[i]%2 == 0)
    {
        sum++;
    }
}
// Console.Write($"Четное количество чисел в массиве: [{string.Join(";", sum)}]");
 Console.Write($"Четное количество чисел в массиве: { sum }");