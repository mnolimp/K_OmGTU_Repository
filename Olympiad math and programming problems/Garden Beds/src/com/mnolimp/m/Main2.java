package com.mnolimp.m;

import java.util.Scanner;

public class Main2 {

    static int p, k, l, n, s = 0;
    // p - distance between well and garden bed
    // k - weight of garden bed
    // l - length of garden bed
    // n - number of garden beds
    // s - sum

    static Scanner scanner;

    public static void main(String[] args) {
        scanner = new Scanner(System.in);
        System.out.println("Distance between well and garden bed p");
        p = scanner.nextInt();
        System.out.println("Weight of garden bed k");
        k = scanner.nextInt();
        System.out.println("Length of garden bed l");
        l = scanner.nextInt();
        System.out.println("Number of garden beds n");
        n = scanner.nextInt();

        s = 2 * n * (p + k + l) + l * n * (n - 1);

        System.out.println(s);
    }
}
