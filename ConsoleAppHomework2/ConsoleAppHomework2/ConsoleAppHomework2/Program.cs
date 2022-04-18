// See https://aka.ms/new-console-template for more information
// Simbolu daudzbveidībai programmā
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("1.Uzdevums - Sasveicināšanās konsoles aplikācija");
Console.WriteLine();
Console.WriteLine("Kā tevi sauc?");
string name = Console.ReadLine();
Console.WriteLine("Sveiks, " + name);


Console.WriteLine();
Console.WriteLine("2.Uzdevums - int.Parse");
Console.WriteLine();
Console.WriteLine("Kāds ir tavs vecums?");
int age = int.Parse(Console.ReadLine());
age++;
Console.WriteLine("Nākamgad tev būs " + age + " gadi");


Console.WriteLine();
Console.WriteLine("3.Uzdevums - Math.Max");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi četrus skaitļus");
Console.WriteLine("Tavs pirmais skaitlis:");
int maxNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs otrais skaitlis:");
int maxNum2 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs trešais skaitlis:");
int maxNum3 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs ceturtais skaitlis:");
int maxNum4 = int.Parse(Console.ReadLine());

int maxNum12 = Math.Max(maxNum1, maxNum2);
int maxNum34 = Math.Max(maxNum3, maxNum4);
int maxNum1234 = Math.Max(maxNum12, maxNum34);

Console.WriteLine($"Lielākais no tevis ievadītajiem skaitļiem bija: {maxNum1234}");


Console.WriteLine();
Console.WriteLine("4.Uzdevums - Math.Min");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi četrus skaitļus");
Console.WriteLine("Tavs pirmais skaitlis:");
int minNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs otrais skaitlis:");
int minNum2 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs trešais skaitlis:");
int minNum3 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs ceturtais skaitlis:");
int minNum4 = int.Parse(Console.ReadLine());

int minNum12 = Math.Min(minNum1, minNum2);
int minNum34 = Math.Min(minNum3, minNum4);
int minNum1234 = Math.Min(minNum12, minNum34);

Console.WriteLine($"Mazākais no tevis ievadītajiem skaitļiem bija: {minNum1234}");


Console.WriteLine();
Console.WriteLine("5.Uzdevums - %");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi divus skaitļus");
Console.WriteLine("Tavs pirmais skaitlis:");
int divNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs otrais skaitlis:");
int divNum2 = int.Parse(Console.ReadLine());

int divLeft = divNum1 % divNum2;

Console.WriteLine($"Izdalot pirmo ievadīto skaitli ar otro, atlikumā paliek: {divLeft}");


Console.WriteLine();
Console.WriteLine("6.Uzdevums - Odd or Even");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi skaitli:");
int oddEven = int.Parse(Console.ReadLine());
bool isEven = oddEven % 2 == 0;

Console.WriteLine($"{oddEven} ir pāra skaitlis: {isEven}");


Console.WriteLine();
Console.WriteLine("7.Uzdevums - Taisnstūra laukuma aprēķināšana");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi taisnstūra malu garumus");
Console.WriteLine("Malas A garums:");
double side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Malas B garums:");
double side2 = double.Parse(Console.ReadLine());

double area = Math.Round(side1 * side2, 2);

Console.WriteLine($"Taisnstūra laukums ir {area}");


Console.WriteLine();
Console.WriteLine("8.Uzdevums - Taisnleņķa trijstūra laukuma aprēķināšana");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi vienādsānu taisnleņķa trīsstūra sānu malas garumu:");
double sideLenght = double.Parse(Console.ReadLine());

double areaTriangle = Math.Round(sideLenght * sideLenght / 2, 2);

Console.WriteLine($"Trīsstūra laukums ir {areaTriangle}");


Console.WriteLine();
Console.WriteLine("9.uzdevums - Interpolācija");
Console.WriteLine();
Console.WriteLine("Kā tevi sauc?");
string name9 = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
int age9 = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks, {name9}. Tu esi {age9} gadus vecs.");