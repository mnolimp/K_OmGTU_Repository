double lenght_of_path, volume_of_tourists, distance_between_start_and_stop, time, max_distance, cur_distance = 0;
int time_of_sunrise, time_of_sunset, amount_of_stop_points, days = 0;

Console.WriteLine("Введите длину пути");
lenght_of_path = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите скорость туристов в километрах в час");
volume_of_tourists = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите количество остановок");
amount_of_stop_points = Convert.ToInt32(Console.ReadLine());

double[] dictances = new double[amount_of_stop_points + 2];
dictances[0] = 0;
dictances[amount_of_stop_points + 1] = lenght_of_path;

List<int> stops = new List<int>();

Console.WriteLine("Введите время восхода в формате (часы пробел минуты)");
String[] input_sunrise = Console.ReadLine().Split(" ");
time_of_sunrise = Convert.ToInt32(input_sunrise[0])*60 + Convert.ToInt32(input_sunrise[1]);

Console.WriteLine("Введите время захода в формате (часы пробел минуты)");
String[] input_sunset = Console.ReadLine().Split(" ");
time_of_sunset = Convert.ToInt32(input_sunset[0])*60 + Convert.ToInt32(input_sunset[1]);

time = (time_of_sunset - time_of_sunrise) / 60;

max_distance = volume_of_tourists * time;

Console.WriteLine("Введите в последовательности расстояния от начала пути до каждого остановочного пункта");

cur_distance += max_distance;

for (int i = 1; i < amount_of_stop_points + 1; i++)
{
    dictances[i] = Convert.ToDouble(Console.ReadLine());
}

for(int i = 1; i < amount_of_stop_points + 2; i++)
{
    if (dictances[i] > cur_distance)
    {
        days++;
        cur_distance = dictances[i - 1];
        cur_distance += max_distance;
        stops.Add(i - 1);
    }
}

Console.WriteLine("Затраченные дни " + days);

for(int i = 0; i < stops.Count; i++)
{
    Console.WriteLine("Остановка " + stops[i]);
}