import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {
    static Scanner scanner;
    public static void main(String[] args) {
        DecimalFormat decimalFormat = new DecimalFormat("#.##");
        scanner = new Scanner(System.in);
        int N, x1, y1, z1, x2, y2, z2;
        double c1, c2, package_price1, package_price2, package_volume1, package_volume2, milk_price;
        String input;
        String[] split_input;
        ArrayList<Double> list = new ArrayList<Double>();

        System.out.println("Введите количество фирм");
        N = scanner.nextInt();
        for(int i = 0; i < N; i++){

            System.out.println("Введите размеры упаковок и стоимость для фирмы " + (i+1) + " в формате <<x1 y1 z1 x2 y2 z2 c1 c2>>");
            input = scanner.nextLine();

            split_input = input.split(" ");
            x1 = Integer.parseInt(split_input[0]);
            y1 = Integer.parseInt(split_input[1]);
            z1 = Integer.parseInt(split_input[2]);
            x2 = Integer.parseInt(split_input[3]);
            y2 = Integer.parseInt(split_input[4]);
            z2 = Integer.parseInt(split_input[5]);
            c1 = Double.parseDouble(split_input[6]);
            c2 = Double.parseDouble(split_input[7]);

            package_volume1 = x1 * y1 * z1;
            package_volume2 = x2 * y2 * z2;

            package_price1 = 2 * (x1 * y1 + y1 * z1 + x1 * z1);
            package_price2 = 2 * (x2 * y2 + y2 * z2 + x2 * z2);

            milk_price = ((c1 - c2 * package_price1/package_price2) / (package_volume1 - package_volume2 * package_price1/package_price2) * 1000);
            list.add(milk_price);
        }

        System.out.println((list.indexOf(Collections.min(list)) + 1) + " " + decimalFormat.format(list.get(list.indexOf(Collections.min(list)))));
    }
}