// Задача 46: Задайте двумерный массив размером M × N, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

/*Console.Write("Введите количество строк rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrx(rows, columns);

Print(matrix);

int[,] = InitMatrx(rows, columns);
{
    int[,] tmp = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++) ;
    {
        for (int j = 0; j < columns; j++)
        {
            tmp[i, j] = random.Next(5, 101);
        }

    }
    return tmp;
}

void GetMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(5, 101);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/


Console.Write("Пожалуйста, введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
int[,] matrix = new int[rows,colums];
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < colums; j++){
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(" " + matrix[i,j]);
    }
}
