
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

int SumUnPos(int[] array)
{
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = GetArray("Введите длину массива: ", 1, 99);
System.Console.WriteLine(string.Join(", ", array));
SumUnPos(array);
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позиция равна: {sum}");
