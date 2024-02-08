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