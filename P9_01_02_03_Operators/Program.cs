// P09_01SpeedConverter:
Console.WriteLine("Enter a number in km/h");
string number = Console.ReadLine();
float userNumber = float.Parse(number);
float x = userNumber / 60 / 60 * 1000;
Console.WriteLine($"That would be {x} m/s.");

// P09_02MinutesToSeconds:
Console.WriteLine("Enter a number in minutes:");
int minutes = int.Parse(Console.ReadLine());
int seconds = minutes * 60;
Console.WriteLine($"{minutes} minutes are {seconds} seconds.");

// P09_03Division:
Console.WriteLine("Enter two numbers");
Console.WriteLine("Enter number 1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2:");
int number2 = int.Parse(Console.ReadLine());
float a = (float)number1 / number2;
Console.WriteLine($"That would be {a}.");