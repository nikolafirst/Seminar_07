// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Двумерный массив создан со следующими значениями:");
Console.WriteLine(" ");
double[,] matrix = new double[new Random().Next(10, 10), new Random().Next(10, 10)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
Console.WriteLine($"Массив содержит {matrix.GetLength(1)} столбцов");

string output = " ";
double SecondaryEducation = 0;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        SecondaryEducation += matrix[j, i];
    }
    SecondaryEducation /= matrix.GetLength(1);
    SecondaryEducation = Math.Round(SecondaryEducation, 1);
    output += $" {i + 1}. {SecondaryEducation} ";
    SecondaryEducation = 0;
}

Console.WriteLine("Среднее арифметическое каждого столбца : " + output);
