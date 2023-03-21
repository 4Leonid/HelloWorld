/*
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i += 1)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.Writeline(NumbersFor(1, 10));
Console.Writeline(NumbersRec(1, 10));


int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.Writeline($"{n++} {new String(word)}"); 
        return;
    }
    for (int i = 0; i < alphabet.Length; i += 1)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("abcd", new char[2]);
*/