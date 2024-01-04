Dog[] dogs = new Dog[10];

dogs[0] = new Dog("Шарик", 2005, "Обычная", "Пестрый", "Мужской");
dogs[1] = new Dog("Ганс", 2007, "Немецкая овчарка", "Черно-желтый", "Мужской");
dogs[2] = new Dog("Рекс", 2008, "Немецкая овчкарка", "Черный", "Мужской");
dogs[3] = new Dog("Белка", 2007, "Лайка", "Белый", "Женский");
dogs[4] = new Dog("Автобус", 2005, "Такса", "Коричневый", "Женский");
dogs[5] = new Dog("Стрелка", 2010, "Обычная", "Темно-серый", "Женский");
dogs[6] = new Dog("Мухтар", 2005, "Чихуахуа", "Черный", "Мужской");
dogs[7] = new Dog("Аямая", 2012, "Чихуахуа", "Пестрый", "Женский");
dogs[8] = new Dog("Армен", 2010, "Шпиц", "Солнечный", "Мужской");
dogs[9] = new Dog("Андрей", 2005, "Лайка", "Темно-синий", "Мужской");

String sortBreed = "Обычная", sortColorForChanging = "Белый", changingColor = "Синий";
int sortYearOfBirth = 2005;

Console.WriteLine("Собаки с породой: " + sortBreed);

for(int i = 0; i < dogs.Length; i++)
{
    if ((dogs[i].sortBreed(dogs[i], sortBreed)) != null)
    {
        Console.WriteLine(dogs[i].getAllInfo(dogs[i].sortBreed(dogs[i], sortBreed)));
    }
}

Console.WriteLine("\nСобаки с годом рождения: " + sortYearOfBirth);

for (int i = 0; i < dogs.Length; i++)
{
    if ((dogs[i].sortYearOfBirth(dogs[i], sortYearOfBirth)) != null)
    {
        Console.WriteLine(dogs[i].getAllInfo(dogs[i].sortYearOfBirth(dogs[i], sortYearOfBirth)));
    }
}

Console.WriteLine("\nЗамена цвета: " + sortColorForChanging + "; На: " + changingColor + "\n");

for (int i = 0; i < dogs.Length; i++)
{
    if ((dogs[i].getColor(dogs[i]).Equals(sortColorForChanging))) {
        Console.WriteLine("Замена цвета для собаки: " + dogs[i].getAllInfo(dogs[i]));
        dogs[i].setColor(changingColor);
        Console.WriteLine("Текущая информация о собаке: " + dogs[i].getAllInfo(dogs[i]) + "\n");
    }
}

class Dog
{
    private String Nickname;
    private int YearOfBirth;
    private String Breed;
    private String Color;
    private String Gender;

    public Dog(String Nickname, int YearOfBirth, String Breed, String Color, String Gender)
    {
        this.Nickname = Nickname;
        this.YearOfBirth = YearOfBirth;
        this.Breed = Breed;
        this.Color = Color; 
        this.Gender = Gender;
    }

    public Dog sortBreed(Dog dog, String Breed)
    {
        if(dog.Breed.Equals(Breed))
        {
            return dog;
        }
        else
        {
            return null;
        }
    }

    public Dog sortYearOfBirth(Dog dog, int YearOfBirth) 
    {
        if (dog.YearOfBirth.Equals(YearOfBirth))
        {
            return dog;
        }
        else
        {
            return null;
        }
    }

    public String getNickname(Dog dog)
    {
        return dog.Nickname;
    }

    public int getYearOfBirth(Dog dog)
    {
        return dog.YearOfBirth;
    }

    public String getBreed(Dog dog)
    {
        return dog.Breed;
    }

    public String getColor(Dog dog)
    {
        return dog.Color;
    }

    public String getGender(Dog dog)
    {
        return dog.Gender;
    }

    public void setNickname(String Nickname)
    {
        this.Nickname = Nickname;
    }

    public void setYearOfBirth(int YearOfBirth)
    {
        this.YearOfBirth = YearOfBirth;
    }

    public void setBreed(String Breed)
    {
        this.Breed = Breed;
    }

    public void setColor(String Color)
    {
        this.Color = Color;
    }

    public void setGender(String Gender)
    {
        this.Gender = Gender;
    }

    public String getAllInfo(Dog dog)
    {
        return "Кличка: " + dog.Nickname + "; Год рождения: " + dog.YearOfBirth + "; Порода: " + dog.Breed + "; Окрас: " + dog.Color + "; Пол: " + dog.Gender;
    }
}