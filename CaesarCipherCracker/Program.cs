using CaesarCipherCracker;

Console.WriteLine("Enter a string to decode or hit enter to use the caeser string:");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input)) input = "Znoy oy g Igkykx Iovnkx Zkyz";
Decoder decode = new(input);
Console.WriteLine("Do you know the shift? (y\\n) " +
    "\n - If you select Y you will be asked to enter the shift " +
    "\n - If you select N the program will attempt every possible shift");
string option = Console.ReadLine().ToLower();
switch (option)
{
    case "y":
        Console.WriteLine("Enter the shift as an integer:");
        int shift = int.Parse(Console.ReadLine());
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




