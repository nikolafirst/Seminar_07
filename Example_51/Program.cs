// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)


Console.Write("Пожалуйста, введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = Convert.ToInt32(Console.ReadLine());

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
Console.WriteLine("Сумма элементов, находящихся на главной диагонали: ");

int sum = 0;
for (int i = 0; i < matrix.GetLength(1) || i < matrix.GetLength(0); i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum);
