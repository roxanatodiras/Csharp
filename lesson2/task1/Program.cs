int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
Console.Writeline(arr[0]);
Console.Writeline(arr[1]);
Console.Writeline(arr[2]);
Console.Writeline(arr[3]);
Console.Writeline(arr[4]);

//Console.Writeline(arr[5]); если написать этот код выдаст 
//ошибку так как наш массив имеет только 5 элементов

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
// таким образом пишем массив и сразу задаем его элементы

int[] arr3 = { 1, 2, 3, 4, 5 };
// упрощенный метод для создания эементов

// метод для питона arr = [1,2,3,4,5]