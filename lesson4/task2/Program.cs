// Создать двумерный массив состоящих из целых чисел
// Вывести на экран "интересные" элементы массива
// Число "интересное" если сумма его цифр четная

// этапы


// 3) взятие очередного элемента





// 1) заполнение массива
int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }

    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
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

int [,] matrix = CreateMatrix(3,4);
ShowMatrix(matrix);

// 2) проход по элементам

// 5) вывод элемента если он интересный

foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

// 4) проверка на "интересность"
//     б) проверка суммы на четность
// функция IsInteresting
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 ==0)
    {
        return true;
    }
        return false;
}

//     а) вычисление суммы
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value >0)
    {
        sum = sum +value % 10;
        value = value/10;
    }
    return sum;
}