String str, str1;
int number = 0, amount_of_n = 0;
bool isPol = true;

Console.WriteLine("Введите строку");
str = Console.ReadLine().Replace(" ", "").ToLower();
for (int i = 0; i < str.Length; i++)
{
    if (char.IsDigit(str[i]))
    {
        if ((Convert.ToInt32(str[i])) % 2 != 0)
        {
            amount_of_n++;
        }
    }
}

for(int i = 0; i < str.Length/2; i++)
{
    if (!str[i].Equals(str[str.Length - 1 - i]))
    {
        isPol = false;
        break;
    }
}

if (isPol)
{
    Console.WriteLine("Строка - палиндром");
}
else
{
    Console.WriteLine("Строка - не палиндром");
}

Console.WriteLine("Количество нечетных цифр в строке: " + amount_of_n);
Console.WriteLine(str.Replace(" ", ""));