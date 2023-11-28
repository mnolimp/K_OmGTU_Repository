String sortEducation = "Higher", sortName = "Fill";
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
        Console.WriteLine(person.getPersonInformation(person.sortByEducation(person, "Higher")));
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
    public Person(String Name, int YearOfBitrh, String Education, String Adress)
    {
        this.Name = Name;
        this.YearOfBirth = YearOfBitrh;
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
        return person.Name + "|" + Convert.ToString(person.YearOfBirth) + "|" + person.Education + "|" + person.Adress;
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