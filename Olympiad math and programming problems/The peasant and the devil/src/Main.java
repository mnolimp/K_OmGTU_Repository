import java.util.Scanner;

public class Main {
    static Scanner scanner;
    public static void main(String[] args) {
        int counter = 0, maxN, n, t;
        scanner = new Scanner(System.in);

        System.out.println("Введите максимальное количество монет");
        maxN = scanner.nextInt();
        for(int i = 0; i <= maxN; i++){
            n = i;
            for(int k = 1; k <= i * 2; k++){
                if(k >= i){
                    n = i;
                    while(n > 0){
                        t = n;
                        n = n * 2 - k;
                        if(n >= t) break;
                    }
                    if(n == 0) counter++;
                }
            }
        }
        System.out.println(counter);
    }
}