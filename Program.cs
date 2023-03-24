// See https://aka.ms/new-console-template for more information
using Hours_And_Minutes;

var exit = 'n';
while (exit == 'n')
{
    int hr, min = 0;
    TimeModel time;
    Console.WriteLine("Analogue clock hour degree calculator \r");
    Console.WriteLine("_____________________________________ \n");
   
    // prompt user to input hour
    Console.WriteLine("Enter hour\n");
    hr = Convert.ToInt32(Console.ReadLine());

    // prompt user to input minutes
    Console.WriteLine("Enter minutes\n");
    min = Convert.ToInt32(Console.ReadLine());
    time = new TimeModel(hr, min);

    var degrees = DegreeCalculator.CalculateTotalDegrees(time);
   
    Console.WriteLine(degrees + " degrees");
   
    // prompt to quit
    Console.WriteLine("Press 'y' to quit. press any character key to continue.");
    char selection=Convert.ToChar(Console.ReadLine());
    if (selection == 'y' || selection == 'Y')
        exit = 'y';
   
}