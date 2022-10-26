var array = new double[6, 7];
Random rnd = new Random();
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 7; j++)
    {
        array[i, j] = rnd.Next(1, 100);
    }
}
var originalArray = array;
//Console.WriteLine("Введите элементы матрицы");
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        array[i, j] = double.Parse(Console.ReadLine());
//    }
//}


var odd = 0;
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] % 2 != 0)
            odd++;

var result = array[0,4] * array[1, 4] * array[2, 4] * array[3,4] * array[4, 4] * array[5, 4];
var t = array[1, 2];
array[1, 2] = array[2, 4];
array[2, 4] = t;

Console.WriteLine("Оригинальная матрица:");
for (int i = 0; i < originalArray.GetLength(0); i++)
{
    for (int j = 0; j < originalArray.GetLength(1); j++)
    {
        Console.Write(originalArray[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine(($"Количество нечетных чисел в матрице: {odd}"));
Console.WriteLine($"Произведение элементов 5 столбца: {result}");
Console.WriteLine();

Console.WriteLine("Измененная матрица:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

