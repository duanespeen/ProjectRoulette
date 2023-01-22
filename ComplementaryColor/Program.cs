using System.Globalization;

/*Take Input
use int.Parse and NumberStyles.HexNumber to convert the input to an int
subtract from 0xFFFFFF to get the complement
convert the int to a hex string with 6 digits
*/

string input = Console.ReadLine();
int color = int.Parse(input, NumberStyles.HexNumber);
color = 0xFFFFFF - color;
Console.WriteLine(color.ToString("X6"));