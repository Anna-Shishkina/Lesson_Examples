// Вид 1   - не принимает, не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();    закомментировано, чтобы вызывать другие методы



//Вид 2   - принимает, не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }      
}
//Method21(msg: "Текст", count: 4); // или Method21(count: 4, msg: "новый текст");



// Вид 3   - не принимает, возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);



// Вид 4   - принимает, возвращает

/* цикл while:
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;     // строка будет пустой
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}*/

// цикл for:
string Method4(int count, string text)
{
    
    string result = String.Empty;     // строка будет пустой
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);


// цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}