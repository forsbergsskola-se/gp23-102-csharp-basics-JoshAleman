// P09_09Hypotenuse
Console.WriteLine("Calculate the length of the hypotenuse of a right triangle using the lengths of the other two sides");
Console.WriteLine("Enter the side 1:");
string side1 = Console.ReadLine();
float a = float.Parse(side1);
Console.WriteLine("Enter the side 2:");
string side2 = Console.ReadLine();
float b = float.Parse(side2);
float cSquared = (a * a) + (b * b);
float c = MathF.Sqrt(cSquared);
Console.WriteLine($"The hypotenuse is: {c}");