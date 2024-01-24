// P09_10SecondsToMinutes
Console.WriteLine("Write a number of seconds:");
int totalseconds = int.Parse(Console.ReadLine());
int min = totalseconds / 60;
int sec = totalseconds % 60;
Console.WriteLine($"The result is {min} minute(s) and {sec} second(s).");