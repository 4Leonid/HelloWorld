/*
const double pi = 3.1415;
int backingField;

void SetValue(int value)
{
    backingField = value;
}

int GetValue()
{
    return backingField;
}

int MyProperty { get; set; }

// Making better
string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.Writeline(text);
}

DrawText("Intensive C# Demo text", 629, 360);
DrawText(caption, screenWidthPosition, screenHeightPosition);
DrawText(text: caption, left: screenWidthPosition, top: screenHeightPosition);


double a = 1, b = -26, c = 120;
var d = b * b - 4 * a * c;

double x1 = (-b + Math.Sqrt(d)) / (2 * a); 
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.Writeline($"x1 = {x1} * 2 = {x2}");

double a = 2, b = 1, c = -3;
var d = b * b - 4 * a * c;

double x1 = (-b + Math.Sqrt(d)) / (2 * a); 
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.Writeline($"x1 = {x1} * 2 = {x2}");

double a = 1, b = 1, c = -6;
var d = b * b - 4 * a * c;

double x1 = (-b + Math.Sqrt(d)) / (2 * a); 
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.Writeline($"x1 = {x1} * 2 = {x2}");

// Make better
public Roots Solve(double a, double b, double c)
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    return new Roots { x1 = x1, x2 = x2 };
}
*/
