// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.
void FillArrayDouble(double[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().NextDouble()*100;
    }
}
double[] CreateRandomArrayDouble(int size)
{
    double[] result = new double[size];
    FillArrayDouble(result);
    return result;
}
double[] arr = CreateRandomArrayDouble(10);
Console.WriteLine($"arr = [{string.Join(", ", arr)}]");
double minEl = arr[0];
double maxEl = arr[0];
for (int i = 1; i< arr.Length; i++)
{
    if (arr[i] < minEl)
    {
        minEl = arr[i];
    }
        if (arr[i] > maxEl)
    {
        maxEl = arr[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным значениями составляет: {maxEl-minEl}");