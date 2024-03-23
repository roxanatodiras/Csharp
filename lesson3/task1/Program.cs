double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    // не смотря на то что результат умножения будет целочисленный
    // нужно указать тип данных double чтобы result получился double
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

// если просто написать функцию CalculateFormula(1, 2, 3, 4); 
// все считается, но не выводится на экран
// для того чтобы вывести результат создадим переменную с типом данных double
double result = CalculateFormula(1, 2, 3, 4);
// и выведем на экран через Console
Console.WriteLine(result);
