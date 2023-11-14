int n, k; //n - строки, k - столбцы

int max, min, counter_of_max_min = 0;

bool all_number_are_positive = true;

int counter_of_zero = 0;

bool zero = false;
int sum = 0;

int counter_of_pairs = 0;
bool all_strings_are_pairs = true;

Console.WriteLine("Введите количество строк ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите массив");

int[,] numbers = new int[n, k];

int[] first_s = new int[k];
int[] second_s = new int[k];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < n; i++)
{
    sum = 0;
    max = numbers[i, 0];
    min = numbers[i, 0];
    for (int j = 0; j < k; j++)
    {
        if (numbers[i, j] > max)
        {
            max = numbers[i, j];
        }

        if (numbers[i, j] < min)
        {
            min = numbers[i, j];
        }

        if (numbers[i, j] == 0)
        {
            counter_of_zero++;
        }
        sum += numbers[i, j];
    }
    if((max % 2 == 0) & (min % 2 == 0)){
        counter_of_max_min++;
    }
    if(sum == 0)
    {
        zero = true;
    }
}

Console.WriteLine("Количество строк с четным макс и мин элементами " + counter_of_max_min);
Console.Write("Столбцы со всеми положительными элементами ");

for (int i = 0; i < k; i++)
{
    all_number_are_positive = true;
    for (int j = 0; j < n; j++)
    {
        if (numbers[j, i] < 0)
        {
            all_number_are_positive = false;
            break;
        }
    }
    if (all_number_are_positive)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine();
Console.WriteLine("Количество нулевых элементов " + counter_of_zero);
Console.WriteLine("Наличие строки с нулевой суммой " + zero);


for (int i = 0; i < n - 1; i++)
{
    for (int g = 0; g < k; g++)
    {
        first_s[g] = numbers[i, g];
    }
    for (int h = i; h < n - 1; h++)
    {
        for (int j = 0; j < k; j++)
        {
            second_s[j] = numbers[h, j];   
        }

        Array.Sort(first_s);
        Array.Sort(second_s);
        if(first_s.SequenceEqual(second_s))
        {
            counter_of_pairs++;
        } else
        {
            all_strings_are_pairs = false;
        }
    }
}

if (!all_strings_are_pairs)
{
    counter_of_pairs /= 2;
}
Console.WriteLine("Количество пар строк, состоящих из одинаковых элементов " + counter_of_pairs);

/*
 * задача про мышь 
 * 
int n, k, pos, cur_position;
bool swither = true;
List<int> mouse = new List<int>();
List<int> red_mouse = new List<int>();

Console.WriteLine("Введите количество мышей");
n = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите какую каждую мышь съедать");
k = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите позицию белой мыши");
pos = Convert.ToInt32(Console.ReadLine()) - 1;

for (int i = 0; i < n; i++)
{

    for (int j = 0; i <= n; i++)
    {
        if (i == pos)
        {
            red_mouse.Add(1);
        }
        else
        {
            red_mouse.Add(0);
        }
    }

    cur_position = i + k;
    if (cur_position >= red_mouse.Count)
    {
        while (cur_position >= red_mouse.Count)
        {
            cur_position -= red_mouse.Count;
        }
    }
    red_mouse.RemoveAt(cur_position);

    while (red_mouse.Count > 1)
    {
        cur_position += (k + 1 - (mouse.Count - red_mouse.Count));

        if(cur_position >= red_mouse.Count) {
            while (cur_position >= red_mouse.Count)
            {
                cur_position -= red_mouse.Count;
            }
        }

        red_mouse.RemoveAt(cur_position);
    }

    if (red_mouse[0] == 1)
    {
        Console.WriteLine(i);
        break;
    }
} 
*/