// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество колонок: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Двумерный массив создан:");
double[,] matrix = new double[rows,columns];
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < columns; j++){
        matrix[i,j] = new Random().NextDouble();
        Console.Write(" " + matrix[i,j]);
    }
}