package ru.lashkevich;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Задание 1");
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java.");
        System.out.println("Задание 2");
        int count = 168;
        System.out.println("( 46 + 10 ) * ( 10 / 3 ) = " + count);
        int count2 = -1740;
        System.out.println("( 29 ) * ( 4 ) * (- 15 ) = " + count2);
        System.out.println("Задание 3");
        int number = 10500;
        int result = number / 10 / 10;
        System.out.println(result);
        System.out.println("Задание 4");
        double num1 = 3.6D;
        double num2 = 4.1D;
        double num3 = 5.9D;
        double result1 = num1 * num2 * num3;
        System.out.println(result1);
        System.out.println("Задание 6");
        Scanner Two = new Scanner(System.in);
        System.out.println("Число?");
        int input1 = Two.nextInt();
        int input2 = input1 % 2;
        if (input1 >= 100 && input2 == 0) {
            System.out.println("Выход за пределы диапазона");
        } else if (input2 != 0) {
            System.out.println("нечётное");
        } else {
            System.out.println("чётное");
        }
    }
}
