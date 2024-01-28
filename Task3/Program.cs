int[] createArray(int size, int min, int max)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;
}
int N = new Random().Next(2, 10);
int [] res = createArray (N, 1, 5);
Console.WriteLine($"Рандомный массив:   [{string.Join(";", res)}]");
int temp = 0;
int [] revers = new int [res.Length];
int a=1;
for (int i = 0; i < res.Length; i++)
{
    revers[i]=res[res.Length-a];
    a++;
}
Console.WriteLine($"Развернутый массив: [{string.Join(";", revers)}]");