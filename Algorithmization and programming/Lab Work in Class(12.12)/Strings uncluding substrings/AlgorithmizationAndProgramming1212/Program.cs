using System.Text.RegularExpressions;

int amount_of_strings, sum = 0;
String ideal, current_string;

Console.WriteLine("Введите образец: ");
ideal = Console.ReadLine();

Console.WriteLine("Введите количество строк: ");
amount_of_strings = Convert.ToInt32(Console.ReadLine());

String[] strings = new String[amount_of_strings];

for (int i = 0; i < amount_of_strings; i++)
{
    strings[i] = Console.ReadLine();
    current_string = strings[i];
    sum += Regex.Matches(current_string, ideal).Count();
}

Console.WriteLine(sum);