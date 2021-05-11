package ru.lashkevich;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	getExercise1();
	//getExercise2();
	//getExercise3();
	//getExercise4();
    //getExercise5_6();

    }

    public static void getExercise1() {
        int n = 100;
        for(int i = 0; i < 100; i++){
            if (i % 2 != 0) {
                System.out.print(i + " ");
            }
        }
    }

    public static void getExercise2() {
        System.out.print("Делится на 3: ");
        for (int i = 1; i <=100; i++) {
            if (i % 3 == 0) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
        System.out.print("Делится на 5: ");
        for (int i = 1; i <=100; i++){
            if(i%5==0) {
                System.out.print(i + " ");
            }
        }
        System.out.println();
        System.out.print("Делится на 3 и 5: ");
        for (int i = 1; i <=100; i++){
            if(i%5==0 && i%3==0) {
                System.out.print(i + " ");
            }
        }
    }

    public static void getExercise3() {
        Scanner Scan = new Scanner(System.in);
        System.out.println("Введите первое число:");
        int a = Scan.nextInt();
        System.out.println("Введите второе число:");
        int b = Scan.nextInt();
        System.out.println("Введите третье число:");
        int c = Scan.nextInt();
        System.out.println("Результат:" + ((a+b)==c));

    }

    public static void getExercise4() {
        Scanner Scan = new Scanner(System.in);
        System.out.println("Введите первое число:");
        int a = Scan.nextInt();
        System.out.println("Введите второе число:");
        int b = Scan.nextInt();
        System.out.println("Введите третье число:");
        int c = Scan.nextInt();
        System.out.println("Результат:" + ((b>a)&&(c>b)));
    }

    public static void getExercise5_6() {
        Scanner Scan2 = new Scanner(System.in);
        System.out.println("Введите размер массива (>= 2):");
        int size = Scan2.nextInt();
        int [] Arr1 = new int [size];
        System.out.println("Введите элементы массива:");
        for (int i = 0; i < size; i++) {
            Arr1[i] = Scan2.nextInt();
        }
        System.out.println(Arrays.toString(Arr1));
        System.out.println(Arr1[0]==3 || Arr1[size-1]==3); // Exercise 5
        System.out.println(Arrays.stream(Arr1).anyMatch(x->x==1) || Arrays.stream(Arr1).anyMatch(x->x==3)); // Exercise 6
    }


}


