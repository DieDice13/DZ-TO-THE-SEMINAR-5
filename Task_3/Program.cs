
Console.Clear();

double[] GetDoubleArray(string message, double min, double max)
{
    System.Console.Write(message);
    int size = int.Parse(Console.ReadLine());
    double[] arrayD = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arrayD.Length; i++)
    {
        arrayD[i] = rand.NextDouble() * (max - min);
    }
    return arrayD;
}

double SearchMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        
    }
    return max;
}

double SearchMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double Diff(double min, double max)
{
    double dif = 0;
    dif = max -= min;
    return dif;
}

double[] array = GetDoubleArray("Введите размер вашего массива вещественных чисел: ", 1, 99);
System.Console.WriteLine(string.Join(", ", array));
double min = SearchMin(array);
System.Console.WriteLine($"Самый минимальный элемент массива : {min}");
double max = SearchMax(array);
System.Console.WriteLine($"Самый максимальный элемент массива : {max}");
Diff(min, max);
double dif = Diff(min, max);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {dif}");