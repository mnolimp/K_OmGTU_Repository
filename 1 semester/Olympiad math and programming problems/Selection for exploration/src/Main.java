import java.util.Scanner;

public class Main {
    static Scanner scanner;
    public static void main(String[] args) {
        scanner = new Scanner(System.in);
        int n, k = 0, c;

        System.out.println("Введите количество солдат");
        n = scanner.nextInt();

        if(n >= 3){
            c = 1;

            while(c <= n/2){
                c *= 2;
            }

            if (n <= c + c / 2) k = n - c;
            else k = 2 * c - n;
        }

        System.out.println(k);
    }
}