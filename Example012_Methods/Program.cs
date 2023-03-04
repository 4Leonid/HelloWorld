// Вид 1
/*
void Method1()
{
    Console.WriteLine("Author...");
}

Method1();

// Вид 2
void Method2(string message)
{
    Console.WriteLine(message);
}

Method2("Text of the message");

// 
void Method22(string message, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(message);
        i += 1;
    }
    
}

Method22(message:"Hello, world",count: 4);


// Вид 3
int Method3()
{
return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Вид 4
string Method4(int count, string str)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result += str;
        i += 1;
    }
    return result;
}

string result = Method4(10, "abc");
Console.WriteLine(result);


string Method4(int count, string str)
{
    string result = String.Empty;

    for (int i = 0; i < count; i+=1)
    {
        result += str;
    }
    return result;
}

string result = Method4(10, "abc");
Console.WriteLine(result);



for (int i = 2; i <= 10; i +=1)
{
    for (int j = 2; j <= 10; j += 1)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

 
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” заменить маленькими “с”.
// 
 
 string text = "-Я думаю, — сказал князь, улыбаясь, — что, "
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля. "
             + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i += 1)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i += 1)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j += 1)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i += 1)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i += 1)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j += 1)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);