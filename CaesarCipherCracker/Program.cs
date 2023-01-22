using CaesarCipherCracker;

Decoder decode = new("Kyzj zj r Trvjvi Tzgyvi Kvjk");
Console.WriteLine("Do you know the shift? (y\\n) \n - If you select Y you will be asked to enter the shift \n - If you select N the program will attempt every possible shift");
string input = Console.ReadLine().ToLower();
switch (input)
{
    case "y":
        Console.WriteLine("Enter the shift as an integer:");
        int shift = int.Parse(Console.ReadLine());
        if (shift > 26) shift = shift - 26;
        Console.WriteLine(decode.Caeser(shift));
        break;
    case "n":
        for (int i = 0; i < 26; i++)
        {
            Console.WriteLine($"Shift: {i} : {decode.Caeser(i)}");
        }
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}




