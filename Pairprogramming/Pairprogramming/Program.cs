using System.Data.SqlTypes;

namespace Pairprogramming;

public class Program
{
    static void Main()
    {
        Console.WriteLine(RomanNumerials(9999));
    }
    public static string RomanNumerials(int Engnums)
    {
        if (Engnums > 10000 || Engnums < 0) throw new ArgumentOutOfRangeException();
        string RomNums = "";
        while (Engnums >= 1000)
        {
            RomNums += "M";
            Engnums -= 1000;
        }
        while (Engnums >= 900)
        {
            RomNums += "CM";
            Engnums -= 900;
        }
        while (Engnums >= 500)
        {
            RomNums += "D";
            Engnums -= 500;
        }
        while (Engnums >= 400)
        {
            RomNums += "CD";
            Engnums -= 400;
        }
        while (Engnums >= 100)
        {
            RomNums += "C";
            Engnums -= 100;
        }
        while (Engnums >= 90)
        {
            RomNums += "XC";
            Engnums -= 90;
        }
        while (Engnums >= 50)
        {
            RomNums += "L";
            Engnums -= 50;
        }
        while (Engnums >= 40)
        {
            RomNums += "XL";
            Engnums -= 40;
        }
        while (Engnums >= 10)
        {
            RomNums += "X";
            Engnums -= 10;
        }
        while (Engnums >= 9)
        {
            RomNums += "IX";
            Engnums -= 9;
        }
        while (Engnums >= 5)
        {
            RomNums += "V";
            Engnums -= 5;
        }
        while (Engnums >= 4)
        {
            RomNums += "IV";
            Engnums -= 5;
        }
        while (Engnums >= 1)
        {
            RomNums += "I";
            Engnums -= 1;
        }

        return RomNums;
    }
}