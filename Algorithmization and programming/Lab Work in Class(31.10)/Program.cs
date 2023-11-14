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







/* Gas stantion problem
 * int n; // amount of cities
int k; // distance limit
int sum = 0; // sum of all distances between cities and gas stantion
int coord = 0; // sum of all distances between neighbour cities
int coord_of_gas_stantion; // coord of gas stantion 

List<int> summ = new List<int>(); // all sums of distances

Console.WriteLine("Введите количество городов");
n = Convert.ToInt32(Console.ReadLine());
int[] distanceBetweenCities = new int[n - 1];
int[] coordsOfCities = new int[n];
coordsOfCities[0] = 0;

for (int i = 0; i < n - 1; i++)
{
    Console.WriteLine("Введите расстояние от " + (i + 1) + " города до " + (i + 2) + " города");
    distanceBetweenCities[i] = Convert.ToInt32(Console.ReadLine());
    coord += distanceBetweenCities[i];
    coordsOfCities[i + 1] = coord;
}

Console.WriteLine("Введите минимальное расстояние от города до заправки");
k = Convert.ToInt32(Console.ReadLine());

if (distanceBetweenCities.Length % 2 != 0)
{
    {
        for (int g = 0; g < n - 1; g++) {
            sum = 0;
            if (distanceBetweenCities[g] >= 2 * k)
            {
                coord_of_gas_stantion = coordsOfCities[g + 1] - k;
                for (int j = 0; j < n; j++)
                {
                    sum += Math.Abs(coord_of_gas_stantion - coordsOfCities[j]);
                }
            }
            summ.Add(sum);
        }
    }
}
else
{
    {
        for (int g = 0; g < n - 1; g++)
        {
            sum = 0;
            if (distanceBetweenCities[g] >= 2 * k)
            {
                coord_of_gas_stantion = coordsOfCities[g + 1] - k;
                for (int j = 0; j < n; j++)
                {
                    sum += Math.Abs(coord_of_gas_stantion - coordsOfCities[j]);
                }
            }
            summ.Add(sum);
        }
    }
}
if (sum == 0)
{
    Console.WriteLine("Размещение невозможно");
} else
{
    Console.WriteLine(summ.Min());
}
*/