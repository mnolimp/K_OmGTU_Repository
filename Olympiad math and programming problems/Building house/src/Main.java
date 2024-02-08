import java.util.Scanner;

public class Main {
    static Scanner scanner;
    public static void main(String[] args) {
        scanner = new Scanner(System.in);
        String []information = new String[9];
        int x, y, l, c1, c2, c3, c4, c5, c6;
        int restWall = 0, min_sum = 0, perimeter = 0;

        System.out.println("Введите данные о доме");
        for(int i = 0; i <= 8; i++) {
            information[i] = scanner.next();
        }
        x = Integer.parseInt(information[0]);
        y = Integer.parseInt(information[1]);
        l = Integer.parseInt(information[2]);
        c1 = Integer.parseInt(information[3]);
        c2 = Integer.parseInt(information[4]);
        c3 = Integer.parseInt(information[5]);
        c4 = Integer.parseInt(information[6]);
        c5 = Integer.parseInt(information[7]);
        c6 = Integer.parseInt(information[8]);

        perimeter = (x + y) * 2;

        if(l > perimeter){
            restWall = l - perimeter;
            perimeter = 0;
        } else perimeter -= l;
        
        if(c1 > (c2 + c3)){
            min_sum += (c2 + c3)*(l - restWall);
            l = 0;
        } else if(c1 > (c2 + c4 + c5 + c6)){
            min_sum += (c2 + c4 + c5 + c6) * (l - restWall);
            l = 0;
        } else if((Math.min(x, y)) > l){
            min_sum += c1 * l;
            l = 0;
        } else{
            min_sum += c1 * Math.max(x, y);
            l -= Math.max(x, y);
        }

        if((c2 + c3) > (c2 + c4 + c5 + c6)){
            if(l > 0) min_sum += (c2 + c4 + c5 + c6)*(l - restWall);
            l = 0;
        }

        if(l > 0) min_sum += (c2 + c3)*(l - restWall);

        min_sum += (c4 + c5) * perimeter ;
        min_sum += (c2 + c6) * restWall;

        System.out.println(min_sum);
    }
}