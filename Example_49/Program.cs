// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Write("Пожалуйста, введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
int[,] matrix = new int[rows, colums];
for (int i = 0; i < rows; i++)
{
    Console.WriteLine();
    for (int j = 0; j < colums; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(" " + matrix[i, j]);
    }
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < rows; i += 2)
{
    Console.WriteLine();
    for (int j = 0; j < colums; j += 2)
    {
        Console.Write(" " + matrix[i, j]);
    }
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Массив после замены");
for (int i = 0; i < rows; i++)
{
    Console.WriteLine();
    for (int j = 0; j < colums; j++)
    {
        Console.Write(" " + matrix[i, j]);
    }
}
