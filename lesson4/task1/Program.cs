// Создать двумерный массив с размерами 3х5, состоящий из целых чисел
// вывести его элементы на экран

int[,] matrix = new int[3, 5];
Random rnd = new Random();

// цикл чтобы заполнить массив цифрами
// цикл для строк
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // цикл для столбцов
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = rnd.Next(1, 11);
    }
}

// цикл чтобы выводить на экран элементы массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // цикл для столбцов
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// это же задача но через функции
int[,] CreateMatrix(int rowCount, int columnCount)
// копируем код что выше где мы создали матрицу
// меняем 3 и 5 на "columnCount" и "rowCount"
{
    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }

    }
    // функция должна возвращать матрицу, по этому добавляем return
    return matrix;
}

// создадим функцию для печати на экран
void ShowMatrix(int[,] matrix)
// как тело функции используем код написан выше для вывода на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // цикл для столбцов
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix2 = CreateMatrix(4,5);
ShowMatrix(matrix2);