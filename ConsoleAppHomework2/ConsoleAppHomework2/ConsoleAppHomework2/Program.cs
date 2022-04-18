// See https://aka.ms/new-console-template for more information
// Simbolu daudzbveidībai programmā
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("1.Uzdevums - Sasveicināšanās konsoles aplikācija");
Console.WriteLine();
Console.WriteLine("Kā tevi sauc?");
string Name = Console.ReadLine();
Console.WriteLine("Sveiks, " + Name);


Console.WriteLine();
Console.WriteLine("2.Uzdevums - int.Parse");
Console.WriteLine();
Console.WriteLine("Kāds ir tavs vecums?");
int Age = int.Parse(Console.ReadLine());
Age++;
Console.WriteLine("Nākamgad tev būs " + Age + " gadi");


Console.WriteLine();
Console.WriteLine("3.Uzdevums - Math.Max");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi četrus skaitļus");
Console.WriteLine("Tavs pirmais skaitlis:");
int MaxNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs otrais skaitlis:");
int MaxNum2 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs trešais skaitlis:");
int MaxNum3 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs ceturtais skaitlis:");
int MaxNum4 = int.Parse(Console.ReadLine());

int MaxNum12 = Math.Max(MaxNum1, MaxNum2);
int MaxNum34 = Math.Max(MaxNum3, MaxNum4);
int MaxNum1234 = Math.Max(MaxNum12, MaxNum34);

Console.WriteLine($"Lielākais no tevis ievadītajiem skaitļiem bija: {MaxNum1234}");


Console.WriteLine();
Console.WriteLine("4.Uzdevums - Math.Min");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi četrus skaitļus");
Console.WriteLine("Tavs pirmais skaitlis:");
int MinNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs otrais skaitlis:");
int MinNum2 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs trešais skaitlis:");
int MinNum3 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs ceturtais skaitlis:");
int MinNum4 = int.Parse(Console.ReadLine());

int MinNum12 = Math.Min(MinNum1, MinNum2);
int MinNum34 = Math.Min(MinNum3, MinNum4);
int MinNum1234 = Math.Min(MinNum12, MinNum34);

Console.WriteLine($"Mazākais no tevis ievadītajiem skaitļiem bija: {MinNum1234}");


Console.WriteLine();
Console.WriteLine("5.Uzdevums - %");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi divus skaitļus");
Console.WriteLine("Tavs pirmais skaitlis:");
int DivNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tavs otrais skaitlis:");
int DivNum2 = int.Parse(Console.ReadLine());

int DivLeft = DivNum1 % DivNum2;

Console.WriteLine($"Izdalot pirmo ievadīto skaitli ar otro, atlikumā paliek: {DivLeft}");


Console.WriteLine();
Console.WriteLine("6.Uzdevums - Odd or Even");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi skaitli:");
int OddEven = int.Parse(Console.ReadLine());
bool isEven = OddEven % 2 == 0;

Console.WriteLine($"{OddEven} ir pāra skaitlis: {isEven}");


Console.WriteLine();
Console.WriteLine("7.Uzdevums - Taisnstūra laukuma aprēķināšana");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi taisnstūra malu garumus");
Console.WriteLine("Malas A garums:");
double Side1 = double.Parse(Console.ReadLine());
Console.WriteLine("Malas B garums:");
double Side2 = double.Parse(Console.ReadLine());

double Area = Math.Round(Side1 * Side2, 2);

Console.WriteLine($"Taisnstūra laukums ir {Area}");


Console.WriteLine();
Console.WriteLine("8.Uzdevums - Taisnleņķa trijstūra laukuma aprēķināšana");
Console.WriteLine();
Console.WriteLine("Lūdzu ievadi vienādsānu taisnleņķa trīsstūra sānu malas garumu:");
double SideLenght = double.Parse(Console.ReadLine());

double AreaTriangle = Math.Round(SideLenght * SideLenght / 2, 2);

Console.WriteLine($"Trīsstūra laukums ir {AreaTriangle}");


Console.WriteLine();
Console.WriteLine("9.uzdevums - Interpolācija");
Console.WriteLine();
Console.WriteLine("Kā tevi sauc?");
string Name9 = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
int Age9 = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks, {Name9}. Tu esi {Age9} gadus vecs.");