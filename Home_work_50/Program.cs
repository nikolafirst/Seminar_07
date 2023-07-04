// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Создаем случайный массив:");
int[,] matrix = new int[10, 10];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10, 100);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);

Console.Write("Введите строку: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите столбец: ");
int columns = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine($"Элемент находящийся в строке {rows} и в столбце {columns} имеет значение : " + matrix[rows, columns]);
}
catch (System.Exception)
{
    Console.WriteLine("В массиве нет такого элемента");
    Environment.Exit(1);
}


