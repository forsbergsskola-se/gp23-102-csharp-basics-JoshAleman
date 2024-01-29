// P09_08BMI
Console.WriteLine("What is your weight in kg?");
string inputA = Console.ReadLine();
float weight = float.Parse(inputA);
Console.WriteLine("How tall are you?");
string heightText = Console.ReadLine();
float height = float.Parse(heightText);
float bodyMass = weight / (height * height);
Console.WriteLine($"Your BMI is: {bodyMass}");