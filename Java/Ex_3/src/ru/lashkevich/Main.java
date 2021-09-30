package ru.lashkevich;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    static int size;
    static int [] array;
    public static void main(String[] args) {
        System.out.println("Ex1 и Ex2:");
        checkOfSortASC();
        System.out.println("Ex3: ");
        changeFirstAndLastElem();
        System.out.println("Ex4: ");
        firstUniqueNumber();
        System.out.println("Ex5: ");
        fibonacci();
        System.out.println("Ex6: ");
        int [] arr = randomMassive();
        int [] sortedArr = mergeSort(arr);
        System.out.println("Отсортированный массив: " + Arrays.toString(sortedArr));
    }

    public static void enterTheMassive() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите число элементов массива: ");
        size = scanner.nextInt();
        System.out.print("Введите члены массива: ");
        array = new int[size];
        for (int i=0;i<size;i++) {
            array[i]=scanner.nextInt();
        }
        System.out.printf("Array:");
        for (int i=0;i<size;i++){
            System.out.print(" " + array[i]);
        }

    }
    public static void checkOfSortASC() {
        enterTheMassive();
        boolean sorted = true;
        for (int i=0;i< size-1;i++){
            if (array[i]>array[i+1]) {
                sorted = false;
                break;
            }
        }
        if (sorted==false){
            System.out.println("\nPlease, try again");}
        else{
            System.out.println("\nOK");}

    }

    public static void changeFirstAndLastElem() {
        enterTheMassive();
        int a=array[0];
        array[0]=array[size-1];
        array[size-1]=a;
        System.out.print("\nNew array: ");
        for (int i=0;i<size;i++){
            System.out.print(Arrays.toString(array));
        }
    }

    public static void firstUniqueNumber() {
        enterTheMassive();
        for (int i=0;i<size; i++) {
            boolean rep = true;
            for (int j = 0; j < size; j++) {
                if (array[i] == array[j] && i != j) {
                    rep = false;
                    break;
                }
            }
            if (rep) {
                System.out.println("\nПервое уникальное число в массиве: " + array[i]);
                break;
            }
        }
    }

    public static void fibonacci () {
        Scanner sc = new Scanner(System.in);
        System.out.println("Какое число по счету в последовательности Фибоначчи Вы хотите вычислить?");
        int n = sc.nextInt();
        int f1=0;
        int f2=1;
        int f=1;
        for (int i=1;i<n;i++){
            f=f1+f2;
            f1=f2;
            f2=f;
        }
        System.out.println(n + " число в последовательности Фибоначчи равно: " + f2);
    }

    public static int[] randomMassive() {
        int num =(int) (Math.random()*30);
        int [] arr = new int [num];
        for (int i=0;i<num;i++){
            arr[i] = (int) (Math.random()*100);
        }
        System.out.println("Массив из "+ num + " элементов: " + Arrays.toString(arr));
        return arr;
    }

    public static void merge(int[]arr, int lowIndex, int midIndex, int highIndex) {
        int left = lowIndex;
        int right = midIndex+1;
        int [] tempArr = new int[highIndex-lowIndex+1];
        int index = 0;
        while ((left<=midIndex)&&(right<=highIndex)){
            if (arr[left]<arr[right]){
                tempArr[index] = arr[left];
                left++;
            }
            else{
                tempArr[index] = arr[right];
                right++;
            }
            index++;
        }
        for (int i = left; i <= midIndex; i++)
        {
            tempArr[index] = arr[i];
            index++;
        }
        for (int i = right; i <= highIndex; i++)
        {
            tempArr[index] = arr[i];
            index++;
        }
        for (int i = 0; i < tempArr.length; i++)
        {
            arr[lowIndex + i] = tempArr[i];
        }
    }

    public static int[] mergeSort(int[]arr, int lowIndex, int highIndex) {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            mergeSort(arr, lowIndex, middleIndex);
            mergeSort(arr, middleIndex + 1, highIndex);
            merge(arr, lowIndex, middleIndex, highIndex);
        }
        return arr;
    }
    public static int[] mergeSort(int[]arr) {
        return mergeSort(arr, 0, arr.length - 1);
    }
}