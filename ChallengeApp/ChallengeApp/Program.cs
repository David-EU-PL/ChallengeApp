using System.Diagnostics.Metrics;
using System;
int number = 1010;
string numberInString = number.ToString();     
char[] lettters= numberInString.ToArray();
Console.WriteLine("W liczbie " + number + " są następujące cyfry:");
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (var letter in lettters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Cyfr 0 => " + counter0);
Console.WriteLine("Cyfr 1 => " + counter1);
Console.WriteLine("Cyfr 2 => " + counter2);
Console.WriteLine("Cyfr 3 => " + counter3);
Console.WriteLine("Cyfr 4 => " + counter4);
Console.WriteLine("Cyfr 5 => " + counter5);
Console.WriteLine("Cyfr 6 => " + counter6);
Console.WriteLine("Cyfr 7 => " + counter7);
Console.WriteLine("Cyfr 8 => " + counter8);
Console.WriteLine("Cyfr 9 => " + counter9);