package com.mnolimp.m;

import java.util.Scanner;

public class Main {

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

        for(int i = 0; i < n; i++){
            s += (2*p + l*i*2 + 2*k + 2*l);
        }
        System.out.println(s);
    }
}
