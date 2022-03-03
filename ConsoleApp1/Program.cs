using System;
using System.Text;
using RNE;
using RN;

class Program
{
    static void Main(string[] args)
    {
        int digit1 = 0;
        int digit2 = 0;

        RomanNumber resultoperateadd;
        RomanNumber resultoperatesub;
        RomanNumber resultoperatemul;
        RomanNumber resultoperatediv;

        Console.WriteLine("Input number1");
        digit1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input number1");
        digit2 = Convert.ToInt32(Console.ReadLine());

        RomanNumber number1 = new RomanNumber(digit1);
        RomanNumber number2 = new RomanNumber(digit2);

        resultoperateadd = number1 + number2;
        resultoperatesub = number1 - number2;
        resultoperatemul = number1 * number2;
        resultoperatediv = number1 / number2;
    }
}


