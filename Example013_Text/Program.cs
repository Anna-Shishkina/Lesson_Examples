// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".
// Ясна ли задача?

string text = "- Я думаю, - Сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали виесто нашего миого Винценгероде,"
            + "вы бы взяли приступо Согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"           
//             012
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');   //заменить пробелы на "|"
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');   //заменить "к" на "К"
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');   //заменить "С" на "с"
Console.WriteLine(newText);