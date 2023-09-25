
using System.Security.Permissions;

Console.Clear();

int sum = 0; 

int[] GetArray(string message, int min, int max)
{
    System.Console.Write(message);
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    Random random= new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int SumPosit(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = GetArray("Введите размер массива: ", 10, 1000);


SumPosit(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"Сумма четных чисел в массиве равна: {sum}");