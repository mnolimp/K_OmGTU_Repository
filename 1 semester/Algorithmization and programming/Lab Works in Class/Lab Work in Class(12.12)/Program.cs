Book[] books = new Book[10];

books[0] = new Book("Стив", "Программирование на C++", 1997, new int[12] {0,0,0,0,1,1,1,0,1,1,1,1});
books[1] = new Book("Олег", "Др-др-др", 2018, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
books[2] = new Book("Олег", "Разгон Ryzen 7 3700x до 5 ГГц в домашних условиях", 2023, new int[12] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 });
books[3] = new Book("Андрей", "Программирование на Go", 2022, new int[12] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 });
books[4] = new Book("Роман", "Программирование на C#", 2022, new int[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
books[5] = new Book("Андрей", "Хрыч", 2022, new int[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
books[6] = new Book("Стив", "Программирование на C++", 1999, new int[12] { 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1 });
books[7] = new Book("Чертила", "Программирование на Cher'те", 2022, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 });
books[8] = new Book("Денис", "Создание Телеграм-бота для отметки посещаемости учениками высших учебных заведений занятий", 2023, new int[12] { 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1 });
books[9] = new Book("Стив", "Программирование на C++", 2001, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 });

String sortAuthor = "Стив";
int sortYearofPublication = 2000;
Book sortBook = books[2];

for(int i = 0; i < books.Length; i++)
{
    Console.WriteLine("Даты выдачи для книги <<" + books[i].getName(books[i]) + ">>: " + books[i].getDateOfIssue(books[i]));
}

Console.WriteLine("Сортировка по имени автора " + sortAuthor);
Console.WriteLine(sortBook.getBookInformation(sortBook.findAllBooksOfWrittenAuthor(books, sortAuthor)));

Console.WriteLine("Сортировка по году издания, больше указанного " + sortYearofPublication);
for(int i = 0; i < books.Length; i++)
{
    Console.WriteLine(books[i].getBookInformation(books[i].sortByYearofPublication_moreThanWritten(books[i], sortYearofPublication)));
}

Console.WriteLine("Информация о книге <<Разгон Ryzen 7 3700x до 5 ГГц в домашних условиях>>" + sortBook.getBookInformation(sortBook));


class Book
{
    private string Author;
    private string Name;
    private int Year_of_Publication;
    private int[] Date_of_Issue = new int[12];
    
    public Book(string Author, string Name, int Year_of_Publication, int[] Date_of_Issue)
    {
        this.Author = Author;
        this.Name = Name;
        this.Year_of_Publication = Year_of_Publication;
        this.Date_of_Issue = Date_of_Issue;
    }

    public int getCountOfIssueOfBook(Book book)
    {
        int counterOfIssueOfBook = 0;
        for(int i = 0; i < 12; i++)
        {
            if (book.Date_of_Issue[i] == 1)
            {
                counterOfIssueOfBook++;
            }
        }
        return counterOfIssueOfBook;
    }

    public Book sortByYearofPublication_moreThanWritten(Book book, int sortYear)
    {
        if(book.Year_of_Publication > sortYear)
        {
            return book;
        }
        else
        {
            return null;
        }
    }

    public Book findAllBooksOfWrittenAuthor(Book[] book, String sortinAuthor)
    {
        for (int i = 0; i < book.Length; i++)
        {
            if (book[i].Author.Equals(sortinAuthor))
            {
                return book[i];
            }
        }
        return null;
    }

    public String getBookInformation(Book book)
    {
        String datesOfIssue = "";
        for(int i = 0; i < 12; i++)
        {
            if (book.Date_of_Issue[i] == 1)
            {
                datesOfIssue += (i + 1) + "в месяце; ";
            }
        }
        return "Название книги: " + book.Name + "\n Год издания: " + book.Year_of_Publication + "\n Автор:" + book.Author + "\n Была выдана в" + datesOfIssue;
    }

    public void setName(String name)
    {
        this.Name = name;
    }

    public void setYearOfPublication(int year_Of_Publication)
    {
        this.Year_of_Publication = year_Of_Publication;
    }

    public void setAuthor(String author)
    {
        this.Author = author;
    }

    public void setDateOfIssue(int month, int type)
    {
        this.Date_of_Issue[month] = type;
    }

    public String getName(Book book)
    {
        return book.Name;
    }

    public int getYearOfPublication(Book book)
    {
        return book.Year_of_Publication;
    }

    public String getAuthor(Book book)
    {
        return book.Author;
    }

    public String getDateOfIssue(Book book)
    {
        String datesOfIssue = "";
        for (int i = 0; i < 12; i++)
        {
            if (book.Date_of_Issue[i] == 1)
            {
                datesOfIssue += (i + 1) + "в месяце; ";
            }
        }

        return "Книга была выдана " + datesOfIssue;
    }
}