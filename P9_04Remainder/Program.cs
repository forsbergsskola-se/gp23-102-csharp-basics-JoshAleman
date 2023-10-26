// P09_04Remainder:
Console.WriteLine("Enter two numbers");
Console.WriteLine("Enter number 1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2:");
int number2 = int.Parse(Console.ReadLine());
float result = (float)number1 % number2;
Console.WriteLine($"That would be {result}.");
