using System.Collections.Immutable;

int amount_of_strings, number;
string str;

Console.WriteLine("Введите количество строк ступенчатого массива");
amount_of_strings = Convert.ToInt32(Console.ReadLine());

int [][] step_array = new int[amount_of_strings][];

Console.WriteLine("Введите строки ступенчатого массива");
for (int i = 0; i < amount_of_strings; i++)
{
    str = Console.ReadLine();
    number = Convert.ToInt32(str);
    step_array[i] = new int[str.Length];
    for(int j = 0; j < str.Length; j++)
    {
        step_array[i][j] = number%10;
        number /= 10;
    }
}