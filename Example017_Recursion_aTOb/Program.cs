// 1. Собрать строку с числами от a до b, a ≤ b

string NumbersFor(int a, int b)         // простой способ
{
    string result = String.Empty;    
    for (int i = a; i <= b; i++)    
    {        
        result += $"{i} ";    
    }    
    return result; 
}


string NumbersRec(int a, int b)         // рекурсией
{    
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);    
    else return String.Empty; 
} 
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10 
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// 2. Собрать строку с числами от a до b, a ≥ b

string NumbersFor(int a, int b)                                      // простой способ
{    
    string result = String.Empty;    
    for (int i = a; i >= b; i--)    
    {        
        result += $"{i} ";    
        }    
        return result; 
} 

string NumbersRec(int a, int b)                                      // рекурсией
{    
    if (a <= b) 
    return NumbersRec(a + 1, b) + $"{a} ";    
    else return String.Empty; 
} 
Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1 
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

// 3. Сумма чисел от 1 до n

int SumFor(int n)                                                          // простой способ
{    
    int result = 0;    
    for (int i = 1; i <= n; i++) 
    result += i;    
    return result; 
} 
int SumRec(int n)                                                        // рекурсией
{    
    if (n == 0) return 0;    
    else return n + SumRec(n - 1); 
} 
Console.WriteLine(SumFor(10)); // 55 
Console.WriteLine(SumRec(10)); // 55

// 4. Факториал числа n

int FactorialFor(int n)                                                      // простой способ
{    
    int result = 1;    
    for (int i = 1; i <= n; i++) 
    result *= i;    
    return result; 
} 
int FactorialRec(int n)                                                      // рекурсией
{    
    if (n == 1) return 1;    
    else return n * FactorialRec(n - 1); 
} 
Console.WriteLine(FactorialFor(10)); // 3628800 
Console.WriteLine(FactorialRec(10)); // 3628800

// 5. Вычислить а в степени n

int PowerFor(int a, int n)                                                   // простой способ
{   
    int result = 1;    
    for (int i = 1; i <= n; i++) 
    result *= a;    
    return result; 
} 
int PowerRec(int a, int n)                                                       // рекурсией
{   
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;    //денарный оператор
    if (n == 0) return 1;    
    else return PowerRec(a, n - 1) * a; 
}    
int PowerRecMath(int a, int n)                                               //улучшенный способ 
{    
    if (n == 0) return 1;    
    else if (n % 2 == 0) 
    return PowerRecMath(a * a, n / 2);    
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024 
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

// 6. Перебор слов 
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из T букв, которые можно построить из букв этого алфавита

char[] s = { 'а', 'и', 'с','в'};                                                     // решение простым способом
int count = s.Length; 
int n = 1; 
for (int i = 0; i < count; i++)                                                      // однобуквенные слова
{   
    for (int j = 0; j < count; j++)                                                  // двухбуквенные слова
    {       
        for (int k = 0; k < count; k++)                                              // трехбуквенные слова  
        {           
            for (int l = 0; l < count; l++)                                          // четырехбуквенные слова         
            {               
                for (int m = 0; m < count; m++)                                      // пятибуквенные слова         
                {                   
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");               
                }           
            }       
        }   
    }
}

int n = 1;                                                                            // решение рекурсией
void FindWords(string alphabet, char[] word, int length = 0)                           
{   
    if (length == word.Length)   
    {       
        Console.WriteLine($"{n++} {new String(word)}");  
        return;   
    }   
    for (int i = 0; i < alphabet.Length; i++)   
    {       
        word[length] = alphabet[i];       
        FindWords(alphabet, word, length + 1);   
    } 
} 
FindWords(“аисв”, new char[5]);

// 7. Как посмотреть содержимое папки?
void CatalogInfo(string path, string indent = "") 
{   
    DirectoryInfo catalogs = new DirectoryInfo(path);   
    foreach (var currentCatalog in catalogs.GetDirectories())   
    {       
        Console.WriteLine($"{indent}{currentCatalog.Name}");       
        CatalogInfo(currentCatalog.FullName, indent + "  ");   
    }   
    foreach (var item in catalogs.GetFiles())   
    {       
        Console.WriteLine($"{indent}{item.Name}");   
    } 
} 
string path = @"/Users/sergejkamaneckij/Projects/HelloCode"; 
CatalogInfo(path);

// 8.Игра в пирамидки
void Towers(string with = "1",                   // рабочий шпиль, т.е. откуда
            string on = "3",                     // третий шпиль, т.е. куда
            string some = "2",                   // промежуточный шпиль
            int count = 3)                       // кол-во блинчиков
{   
    if (count > 1) Towers(with, some, on, count - 1);   
    Console.WriteLine($"{with} >> {on}");   
    if (count > 1) Towers(some, on, with, count - 1); 
}

// 9. Обход разных структур

string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; 
//                 0    1    2     3    4    5    6    7    8    9    10   11 
void InOrderTraversal(int pos = 1) 
{   
    if (pos < tree.Length)   
    {       
        int left = 2 * pos;       
        int right = 2 * pos + 1;       
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);       
        Console.WriteLine(tree[pos]);       
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);   
    } 
}