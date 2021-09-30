package ru.lashkevich;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        vector v1 = new vector(5.1,2.8,7.0);
        vector v2 = new vector(8.8,-1.5,6.7);
        System.out.printf("Длина 1: "+"%.2f\n",v1.VectorLength());
        System.out.printf("Длина 2:  "+"%.2f\n",v2.VectorLength());
        System.out.printf("Скалярное произведение: "+"%.2f\n",v1.ScalarMult(v2));
        vector v3 = new vector();
        System.out.println("Векторное произведение: " + v3.VectorMult(v1,v2).toString());
        System.out.printf("cos угла между векторами: "+"%.2f\n",v1.VectorAngle(v2));
        System.out.println("Сумма: "+v3.SumVectors(v1,v2).toString());
        System.out.println("Разность: "+v3.DifferenceVectors(v1,v2).toString());
        int N;
        Scanner scanner=new Scanner(System.in);
        System.out.println("Введите массив: ");
        N= scanner.nextInt();
        System.out.println("Массив векторов: ");
        vector[] vecarr = vector.VectorArray(N);
        for (int i=0;i<N;i++){
            System.out.println(vecarr[i]);
        }
    }
}
