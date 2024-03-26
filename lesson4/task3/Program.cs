// Считать с консоли строку, сотоящую из цифр и латинских букв
// Сформировать новую строку, состоящую из букв исходной строки

// этапы

string GetLettersFromString(string s)
{
    string letters = "";
    // 2) проход по элементам строки
    foreach (char e in s)
    {
        // 3) проверка является ли элемент буквой
        if (char.IsAsciiLetter(e) == true)
        {
            // 4) дописать подходящий элемент к новой строке
            letters = letters + e;
        }
    }
    return letters;
}

// 1) ввод строки
string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);