namespace MaxGetcoinsandnotes;

public class Program
{
    static void Main()
    {
        Console.WriteLine(GetCoinsAndNotes(420.69));
    }
    public static string GetCoinsAndNotes(double money)
    {
        if (money < 0) throw new ArgumentOutOfRangeException();
        money = Math.Round(money, 2);
        double onePence = 0;
        double twoPence = 0;
        double fivePence = 0;
        double tenPence = 0;
        double twentyPence = 0;
        double fiftyPence = 0;
        double onePound = 0;
        double fivePound = 0;
        double tenPound = 0;
        double twentyPound = 0;


        if (money >= 20) twentyPound = (money - (money % 20)) / 20;
        money = money % 20;
        if (money >= 10) tenPound = (money - (money % 10)) / 10;
        money = money % 10;
        if (money >= 5) fivePound = (money - (money % 5)) / 5;
        money = money % 5;
        if (money >= 1) onePound = (money - (money % 1)) / 1;
        money = money % 1;
        if (money >= 0.5) fiftyPence = (money - (money % 0.5)) / 0.5;
        money = money % 0.5;
        if (money >= 0.2) twentyPence = (money - (money % 0.2)) / 0.2;
        money = money % 0.2;
        if (money >= 0.1) tenPence = (money - (money % 0.1)) / 0.1;
        money = money % 0.1;
        if (money >= 0.05) fivePence = (money - (money % 0.05)) / 0.05;
        money = money % 0.05;
        if (money >= 0.02) twoPence = (money - (money % 0.02)) / 0.02;
        money = money % 0.02;
        if (money >= 0.01) onePence = (money - (money % 0.01)) / 0.01;
        money = money % 0.01;



        return $"£20: {twentyPound}, £10: {tenPound}, £5: {fivePound}, £1: {onePound}, 50p: {fiftyPence}, 20p: {twentyPence}, 10p: {tenPence}, 5p: {fivePence}, 2p: {twoPence}, 1p: {onePence}";
    }
}