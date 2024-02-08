import java.util.Scanner;

public class Main {
    static Scanner scanner;
    public static void main(String[] args) {
        String start_date, final_date;
        String start_date_split[], final_date_split[];

        int start_year, start_month, start_day;
        int final_year, final_month, final_day;
        int overall_days = 0;

        int start_volume, final_volume = 0, added_volume;
        scanner = new Scanner(System.in);

        System.out.println("Введите дату начала в формате ДД,ММ,ГГГГ");
        start_date = scanner.next();
        System.out.println("Введите дату окончания в формате ДД,ММ,ГГГГ");
        final_date = scanner.next();
        System.out.println("Введите начальный выпуск продукции");
        start_volume = scanner.nextInt();
        added_volume = start_volume;

        start_date_split = start_date.split(",");
        final_date_split = final_date.split(",");

        start_day = Integer.parseInt(start_date_split[0]);
        start_month = Integer.parseInt(start_date_split[1]);
        start_year = Integer.parseInt(start_date_split[2]);

        final_day = Integer.parseInt(final_date_split[0]);
        final_month = Integer.parseInt(final_date_split[1]);
        final_year = Integer.parseInt(final_date_split[2]);

        for(int i = start_year; i <= final_year; i++){
            if(i % 4 == 0){
                overall_days += 366;
            } else {
                overall_days += 365;
            }
        }

        if(start_month < final_month){
            for(int i = start_month; i < final_month; i++){
                switch (i) {
                    case (2):
                        overall_days += 28;
                    case (4):
                    case (6):
                    case (9):
                    case (11):
                        overall_days += 30;
                    case (1):
                    case (3):
                    case (5):
                    case (7):
                    case (8):
                    case (10):
                        overall_days += 31;
                }
            }
        } else if(start_month > final_month) {
            for(int i = final_month; i < start_month; i++){
                switch (i) {
                    case (2):
                        overall_days -= 28;
                    case (4):
                    case (6):
                    case (9):
                    case (11):
                        overall_days -= 30;
                    case (1):
                    case (3):
                    case (5):
                    case (7):
                    case (8):
                    case (10):
                        overall_days -= 31;
                }
            }
        }

        overall_days = final_day - start_day + 1;

        for(int i = 0; i < overall_days; i++){
            final_volume += added_volume;
            added_volume += 1;
        }

        System.out.println(final_volume);
    }
}