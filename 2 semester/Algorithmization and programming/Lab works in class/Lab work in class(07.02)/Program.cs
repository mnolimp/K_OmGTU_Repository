namespace ConsoleApp1
{
    internal class Program
    {
        static List<Auditorium> auditoriums;
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.showMenu();
        }


        public class Menu
        {
            public Menu()
            {

            }

            public static void showIfDidntFind()
            {
                Console.Clear();
                Console.WriteLine("Такой аудитории не было найдено\nНажмите любую клавишу, чтобы вернуться в меню");
                Console.ReadKey();
                Console.Clear();
            }

            public void showMenu()
            {
                do
                {
                    Console.Clear();
                    int variant;
                    Console.WriteLine("1.  Создание бд\r\n2.  Добавление в базу\r\n3.  Изменение данных аудитории по заданному номеру\r\n4.  Выборка аудиторий с кол-вом посадочных мест больше равным заданного \r\n5.  Выборка аудиторий с проектором \r\n6.  Выборка аудиторий с пк и заданным кол-вом посадочных мест\r\n7.  Выборка аудиторий по номеру этажа\r\n8.  Вывод всех данных по аудиториям\r\n9.  Выход");
                    variant = Convert.ToInt32(Console.ReadLine());
                    switch (variant)
                    {
                        case 1:
                            Auditorium.createBD();
                            break;
                        case 2:
                            Auditorium.addToDB();
                            break;
                        case 3:
                            Console.WriteLine("Напишите номер аудитории в формате <<этаж-номер>>");
                            try
                            {
                                Auditorium.changeInfobyNumber(Console.ReadLine());
                            } catch (System.FormatException)
                            {
                                Console.WriteLine("Данные введены некорректно. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Введите число посадочных мест");
                            try
                            {
                                Auditorium.findAuditoriumswithPlaces(Convert.ToInt32(Console.ReadLine()));
                            } catch (System.FormatException)
                            {
                                Console.WriteLine("Данные введены некорректно. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            Auditorium.findAuditoriumwithProjector();
                            break;
                        case 6:
                            int places, PCs;
                            Console.WriteLine("Введите количество посадочных мест");
                            places = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите количество ПК");
                            PCs = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                Auditorium.findAuditoriumwithPCsAndPlaces(places, PCs);
                            } catch (System.FormatException)
                            {
                                Console.WriteLine("Данные введены некорректно. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                                Console.ReadKey();
                            }
                            break;
                        case 7:
                            Auditorium.findAuditoriumbyFlat(0);
                            break;
                        case 8:
                            Auditorium.getAllInfoAllAuditoriums();
                            break;
                        case 9:
                            Environment.Exit(0);
                            break;

                    }
                } while (true);
            }
        }

        public class Auditorium
        {
            private String number;
            private int places;
            private bool projector;
            private int PCs;
            public Auditorium(String number, int places, bool projector, int PCs)
            {
                this.number = number;
                this.places = places;
                this.projector = projector;
                this.PCs = PCs;
            }

            public static void createBD()
            {
                auditoriums = new List<Auditorium>();
                Console.Clear();
                Console.WriteLine("Новая база данных успешно создана \nНажмите любую клавишу, чтобы вернуться в меню");
                Console.ReadKey();
                Console.Clear();
            }

            public static void addToDB()
            {
                String number, strProjector;
                int places;
                bool projector;
                int PCs;
                try
                {
                    Console.WriteLine("Введите номер аудитории в формате <<этаж-номер>>");
                    number = Console.ReadLine();

                    Console.WriteLine("Введите количество посадочных мест");
                    places = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Подтвердите наличие/отсуствие проектора в аудитории(Да/Нет)");
                    strProjector = Console.ReadLine();

                    switch (strProjector)
                    {
                        case "да":
                        case "Да":
                        case "ДА":
                        case "дА":
                            projector = true;
                            break;
                        case "нет":
                        case "Нет":
                        case "НЕТ":
                        case "нЕТ":
                        case "нЕт":
                        case "неТ":
                        case "НеТ":
                        case "НЕт":
                            projector = false;
                            break;
                        default:
                            projector = false;
                            break;
                    }

                    Console.WriteLine("Введите количество компьютеров в аудитории(введите 0 если их нет)");
                    PCs = Convert.ToInt32(Console.ReadLine());
                    if (auditoriums != null)
                    {
                        auditoriums.Add(new Auditorium(number, places, projector, PCs));
                        Console.Clear();
                        Console.WriteLine("Аудитория успешно добавлена в базу данных \nНажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("База данных не инициализированна. Добавление аудитории в базу данных прервано. Нажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                    }
                } catch (System.FormatException)
                {

                    Console.WriteLine("Данные введены некорректно. Добавление аудитории в базу данных прервано. Нажмите любую клавишу, чтобы вернуться в меню");
                    Console.ReadKey();
                }
            }


            public static void changeInfobyNumber(String number)
            {
                if (auditoriums != null)
                {
                    Auditorium changingAuditorium = findAuditoriumbyNumber(number);
                    if (changingAuditorium == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Такой аудитории не было найдено\nНажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                    else
                    {
                        String changingNumber, strProjector;
                        int changingPlaces, indexOfChangingAuditorium;
                        bool changingProjector;
                        int changingPCs;

                        Console.WriteLine("Введите номер аудитории в формате <<этаж-номер>>");
                        changingNumber = Console.ReadLine();

                        Console.WriteLine("Введите количество посадочных мест");
                        changingPlaces = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Подтвердите наличие/отсуствие проектора в аудитории(Да/Нет)");
                        strProjector = Console.ReadLine();

                        switch (strProjector)
                        {
                            case "да":
                            case "Да":
                            case "ДА":
                            case "дА":
                                changingProjector = true;
                                break;
                            case "нет":
                            case "Нет":
                            case "НЕТ":
                            case "нЕТ":
                            case "нЕт":
                            case "неТ":
                            case "НеТ":
                            case "НЕт":
                                changingProjector = false;
                                break;
                            default:
                                changingProjector = false;
                                break;
                        }

                        Console.WriteLine("Введите количество компьютеров в аудитории(введите 0 если их нет)");
                        changingPCs = Convert.ToInt32(Console.ReadLine());

                        Auditorium updatedAuditorium = new Auditorium(changingNumber, changingPlaces, changingProjector, changingPCs);
                        indexOfChangingAuditorium = auditoriums.IndexOf(changingAuditorium);
                        auditoriums[indexOfChangingAuditorium] = updatedAuditorium;

                        Console.Clear();
                        Console.WriteLine("Аудитория успешно отредактирована \nНажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("База данных не инициализированна. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                    Console.ReadKey();
                }
            }

            public static void findAuditoriumswithPlaces(int places)
            {
                Console.Clear();
                bool foundAuditorium = false;
                if (auditoriums != null)
                {
                    for (int i = 0; i < auditoriums.Count; i++)
                    {
                        if (auditoriums[i].places >= places)
                        {
                            Console.WriteLine(getAllInfo(auditoriums[i]));
                            foundAuditorium = true;
                        }
                    }
                    if (foundAuditorium)
                    {
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                    } else
                    {
                        Menu.showIfDidntFind();
                    }
                }
                else
                {
                    Console.WriteLine("База данных не инициализированна. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                    Console.ReadKey();
                }
            }

            public static void findAuditoriumwithProjector()
            {
                Console.Clear();
                bool foundAuditorium = false;
                if (auditoriums != null)
                {
                    for (int i = 0; i < auditoriums.Count; i++)
                    {
                        if (auditoriums[i].projector == true)
                        {
                            Console.WriteLine(getAllInfo(auditoriums[i]));
                            foundAuditorium = true;
                        }
                    }
                    if (foundAuditorium)
                    {
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                    } else
                    {
                        Menu.showIfDidntFind();
                    }
                } else
                {
                    Console.WriteLine("База данных не инициализированна. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                    Console.ReadKey();
                }
            }

            public static void findAuditoriumwithPCsAndPlaces(int places, int PCs)
            {
                Console.Clear();
                bool foundAuditorium = false;
                if (auditoriums != null)
                {
                    for (int i = 0; i < auditoriums.Count; i++)
                    {
                        if ((auditoriums[i].places >= places) & (auditoriums[i].PCs >= PCs))
                        {
                            Console.WriteLine(getAllInfo(auditoriums[i]));
                            foundAuditorium = true;
                        }
                    }
                    if (foundAuditorium)
                    {
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                    } else
                    {
                        Menu.showIfDidntFind();
                    }
                } else
                {
                    Console.WriteLine("База данных не инициализированна. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                    Console.ReadKey();
                }
            }

            public static void findAuditoriumbyFlat(int flat)
            {
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                Console.ReadKey();
                Console.Clear();
            }

            public static void getAllInfoAllAuditoriums()
            {
                bool foundAuditorium = false;
                Console.Clear();
                if (auditoriums != null)
                {
                    for (int i = 0; i < auditoriums.Count(); i++)
                    {
                        Console.WriteLine(getAllInfo(auditoriums[i]));
                        foundAuditorium = true;
                    }
                    if (foundAuditorium)
                    {
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine("База данных пуста\nНажмите любую клавишу, чтобы вернуться в меню");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } else
                {
                    Console.WriteLine("База данных не инициализированна. Операция прервана. Нажмите любую клавишу, чтобы вернуться в меню");
                    Console.ReadKey();
                }
            }

            public void setNumber(Auditorium auditorium, String number)
            {
                this.number = number;
            }

            public void setPlaces(Auditorium auditorium, int places)
            {
                this.places = places;
            }

            public void setProjector(Auditorium auditorium, bool projector)
            {
                this.projector = projector;
            }

            public void setPCs(Auditorium auditorium, int PCs)
            {
                this.PCs = PCs;
            }

            public String getNumber(Auditorium auditorium)
            {
                return auditorium.number;
            }

            public int getPlaces(Auditorium auditorium)
            {
                return auditorium.places;
            }

            public bool getProjector(Auditorium auditorium)
            {
                return auditorium.projector;
            }

            public int getPCs(Auditorium auditorium)
            {
                return auditorium.PCs;
            }

            public static String getAllInfo(Auditorium auditorium)
            {
                return "Номер: " + auditorium.number + " Количество посадочных мест: " + auditorium.places + " Наличие проектора: " + auditorium.projector + " Количество компьютеров: " + auditorium.PCs;
            }

            public static Auditorium findAuditoriumbyNumber(String number)
            {
                bool isAuditoriumFound = false;
                int n = 0;
                for(int i = 0; i < auditoriums.Count; i++)
                {
                    if (auditoriums[i].number == number)
                    {
                        n = i;
                        isAuditoriumFound = true;
                        break;
                    }
                }
                if (isAuditoriumFound)
                {
                    return auditoriums[n];
                } else
                {
                    return null;
                }
            }
        }
    }
}