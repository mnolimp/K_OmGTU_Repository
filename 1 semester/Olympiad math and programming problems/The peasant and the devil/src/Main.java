import java.util.Scanner;

public class Main {
    static Scanner scanner;
    public static void main(String[] args) {
        int total = 0, maxN, res;
        scanner = new Scanner(System.in);
        maxN = scanner.nextInt();
        for (int j = 1; j <= maxN; j++)
        {
            for (int i = 2; i <= 17; i++)
            {
                if (j % (int)Math.pow(2, i) - 1 == 0)
                {
                    total += 1;
                }
            }
        }
        res = maxN + total;
        System.out.println(res);
    }
}