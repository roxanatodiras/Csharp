int n = 10;
int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
Console.WriteLine(" ");
// еще метод
// int n = 10;
int[] array2 = { 1, 2, 3, 5, 6, 7, 8, 9, 6, 3 };
int ind = 0;

// обращаемся не к "n" а к длине массива, и тогда 
//нам не нужен "n" в самом начале
while (ind < array2.Length)
{
    if (array2[ind] % 2 == 0)
    {
        Console.Write($"{array2[ind]} ");
    }
    ind = ind + 1;
}