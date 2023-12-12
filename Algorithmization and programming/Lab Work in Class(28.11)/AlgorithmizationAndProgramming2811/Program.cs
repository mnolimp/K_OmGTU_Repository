String sortEducation = "Second", sortName = "Fill";
int sortYear = 2000;


Person[] persons = new Person[10];

persons[0] = new Person("Fill", 2005, "Second", "27 Line, 47");
persons[1] = new Person("Doll", 1997, "Higher", "5 Line, 7");
persons[2] = new Person("Bill", 2000, "Second", "27 Line, 47");
persons[3] = new Person("Ulona", 2000, "None", "27 Line, 47");
persons[4] = new Person("Fill", 1976, "Professor", "27 Line, 40");
persons[5] = new Person("Berl", 1891, "None", "27 Line, 40");
persons[6] = new Person("Ulona", 2002, "Higher", "7 Line, 12");
persons[7] = new Person("Mack", 2010, "Second", "7 Line, 13");
persons[8] = new Person("Piter", 1988, "Second", "27 Line, 47");
persons[9] = new Person("Merlin", 2002, "Higher", "27 Line, 40");

Console.WriteLine("Сортировка по образованию типа: " + sortEducation);

for (int i = 0; i < persons.Length; i++)
{
    Person person = persons[i];
    if (person.sortByEducation(person, sortEducation) != null)
    {
        Console.WriteLine(person.getPersonInformation(person.sortByEducation(person, sortEducation)));
    }
}

Console.WriteLine("Сортировка по году рождения: " + sortYear);

for (int i = 0; i < persons.Length; i++)
{
    Person person = persons[i];
    if (person.sortByYear(person, sortYear) != null)
    {
        Console.WriteLine(person.getPersonInformation(person.sortByYear(person, sortYear)));
    }
}

Console.WriteLine("Сортировка по имени:" + sortName);

for (int i = 0; i < persons.Length; i++)
{
    Person person = persons[i];
    if (person.sortByName(person, sortName) != null)
    {
        Console.WriteLine(person.getPersonInformation(person.sortByName(person, sortName)));
    }
}

class Person
{
    private String Name;
    private int YearOfBirth;
    private String Education;
    private String Adress;
    public Person(String Name, int YearOfBirth, String Education, String Adress)
    {
        this.Name = Name;
        this.YearOfBirth = YearOfBirth;
        this.Education = Education;
        this.Adress = Adress;
    }

    public Person sortByName(Person person, String name)
    {
        if (person.Name.Equals(name))
        {
            return person;
        }
        else
        {
            return null;
        }
    }

    public Person sortByYear(Person person, int year)
    {
        if (person.YearOfBirth == year)
        {
            return person;
        }
        else
        {
            return null;
        }
    }

    public Person sortByEducation(Person person, String education)
    {
        if (person.Education.Equals(education))
        {
            return person;
        }
        else
        {
            return null;
        }
    }

    public String getName(Person person)
    {
        return person.Name;
    }

    public int getYearOfBirth(Person person)
    {
        return person.YearOfBirth;
    }

    public String getEducation(Person person)
    {
        return person.Education;
    }

    public String getAdress(Person person)
    {
        return person.Adress;
    }

    public String getPersonInformation(Person person)
    {
        if (person != null)
        {
            return person.Name + "|" + Convert.ToString(person.YearOfBirth) + "|" + person.Education + "|" + person.Adress;
        }
        else
        {
            return null;
        }
    }

    public void setName(String name)
    {
        this.Name = name;
    }

    public void setYearOfBirth(int yearOfBirth)
    {
        this.YearOfBirth = yearOfBirth;
    }

    public void setEducation(String education)
    {
        this.Education = education;
    }

    public void setAdress(String adress)
    {
        this.Adress = adress;
    }
}







/*int amount_of_small_roads, t, s, n, len_s = 0, len_n = 0, len = 0;
bool isUp = true;

Console.WriteLine("Введите количество пар");
amount_of_small_roads = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину перехода");
t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < amount_of_small_roads; i++)
{
    Console.WriteLine("Введите длину верхней " + i + " дорожки");
    s = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину нижней " + i + " дорожки");
    n = Convert.ToInt32(Console.ReadLine());



}

Console.WriteLine(len);
*/

/*    polyndrom
String str;

Console.WriteLine("Введите строку");
str = Console.ReadLine();

calculatingMaxLenOfPal(str);
void calculatingMaxLenOfPal(String text)
{
    int N = text.Length;
    if (N == 0)
        return;
    N = 2 * N + 1;
    int[] L = new int[N + 1];
    L[0] = 0;
    L[1] = 1;
    int C = 1;
    int R = 2; 
    int i = 0;
    int iMirror;
    int maxLPSLength = 0;
    int maxLPSCenterPosition = 0;
    int start = -1;
    int end = -1;
    int diff = -1;
    String pal = "";

    for (i = 2; i < N; i++)
    {
        iMirror = 2 * C - i;
        L[i] = 0;
        diff = R - i;

        if (diff > 0)
            L[i] = Math.Min(L[iMirror], diff);

        while (((i + L[i]) + 1 < N && (i - L[i]) > 0) &&
                           (((i + L[i] + 1) % 2 == 0) ||
                       (text[(i + L[i] + 1) / 2] ==
                        text[(i - L[i] - 1) / 2])))
        {
            L[i]++;
        }

        if (L[i] > maxLPSLength)
        {
            maxLPSLength = L[i];
            maxLPSCenterPosition = i;
        }

        if (i + L[i] > R)
        {
            C = i;
            R = i + L[i];
        } 
    }

    start = (maxLPSCenterPosition - maxLPSLength) / 2;
    end = start + maxLPSLength - 1;
    Console.Write("Максимальная длина палиндрома: ");
    for (i = start; i <= end; i++)
        pal += text[i];
    Console.WriteLine(pal.Length);
}
*/