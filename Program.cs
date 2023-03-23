// See https://aka.ms/new-console-template for more information
using Hours_And_Minutes;

int hr, min = 0;
TimeModel time;
Console.WriteLine("Analogue clock hour degree calculator \r");
Console.WriteLine("_____________________________________ \n");
Console.WriteLine("Enter hour\n");
hr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter minutes\n");
min = Convert.ToInt32(Console.ReadLine());
time = new TimeModel(hr, min);

var degrees = DegreeCalculator.CalculateTotalDegrees(time);
Console.WriteLine(degrees + " degrees");
