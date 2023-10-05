int n, number, red_number, counter_of_no_odd = 0, sum = 0, prev_number = 0, max_sum = 0, counter_of_pairs_divided_by_7 = 0;
int[] numbers;
Boolean is_odd = true, is_all_numbers_5_even_sum = true, is_any_number_divided_by_5 = false;

n = Convert.ToInt32(Console.ReadLine());

numbers = new int[n];

for(int i = 0; i < n; i++)
{
    is_odd = true;
    sum = 0;
    number = Convert.ToInt32(Console.ReadLine());
    red_number = number;
    numbers[i] = number;
    while(red_number > 0)
    {
        sum += red_number % 10;
        if((red_number % 10) % 2 == 0)
        {
            is_odd = false;
        }
        red_number /= 10;
    }
    if (is_odd)
    {
        counter_of_no_odd++;
    }

    if(number % 5 == 0)
    {
        is_all_numbers_5_even_sum = true;
        if(sum % 2 != 0)
        {
            is_all_numbers_5_even_sum = false;
        }   
    }
    if (i > 0)
    {
        if(prev_number < number)
        {
            if(max_sum < (prev_number + number))
            {
                max_sum = prev_number + number;
            }
        }
    }
    prev_number = number;
}

for(int i = 0; i < numbers.Length; i++)
{
    for(int j = i + 1; j < numbers.Length; j++)
    {
        if ((numbers[i] * numbers[j]) % 7 == 0)
        {
            counter_of_pairs_divided_by_7++;
        }
    }
}

Console.WriteLine(counter_of_no_odd + " чисел без четных цифр");

if (is_any_number_divided_by_5)
{
    if (is_all_numbers_5_even_sum)
    {
        Console.WriteLine("Все элементы кратные 5 имеют четную сумму цифр");
    }
    else
    {
        Console.WriteLine("Не все элементы кратные 5 имеют четную сумму цифр");
    }
} else
{
    Console.WriteLine("Нет элементов кратных 5");
} 

Console.WriteLine(max_sum + " наибольшая сумма пар в которых первый элемент меньше второго");

Console.WriteLine(counter_of_pairs_divided_by_7 + " пар элементов у которых произведение кратно 7");