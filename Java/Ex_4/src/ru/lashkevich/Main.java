package ru.lashkevich;
import java.util.*;

public class Main {


    public static void main(String[] args) {
        System.out.println("1. Написать метод для поиска самой длинной строки: ");
        String[] words = {"строка", "1 строка", "вторая строка", "abc"};
        System.out.println("Самая длинная строка: " + longestString(words));

        System.out.println("2. Написать метод, который проверяет является ли слово палиндромом: ");
        palindrom();

        System.out.println("3.Напишите метод, заменяющий в тексте все вхождения слова «бяка» на «[вырезано цензурой]»: ");
        censored();
        System.out.println( "4.	Имеются две строки. Найти количество вхождений одной (являющейся подстрокой) в другую: ");
        substrings();
        System.out.println( "5. Напишите метод, который инвертирует слова в строке. : ");
        inversions();


    }

    private static String longestString(String[] strings) {
        String longest = "";
        for (int i = 0; i < strings.length; i++) {
            if (strings[i].length() > longest.length()) {
                longest = strings[i];
            }
        }
        return longest;
    }
    public static void palindrom() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите слово на проверку палиндрома: ");
        String word = scanner.nextLine();
        String[] splited = word.split("");
        int count=0;
        int j= splited.length-1;
        for (int i=0;i<splited.length/2;i++){
            j=j-i;
            if (splited[i].equalsIgnoreCase(splited[j])){
                count++;
            }
        }
        if (count==splited.length/2)
            System.out.println("Это палиндром");
        else
            System.out.println("Это не палиндром");
    }

    public static void censored() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите фразу со словом бяка: ");
        String phrase = scanner.nextLine();
        System.out.println(phrase.replace("бяка","[вырезано цензурой]"));
    }

    public static void substrings () {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите две строки, где первая содержит вторую: ");
        String str1 = scanner.nextLine();
        String str2 = scanner.nextLine();
        System.out.println(str1.split(str2,-1).length-1);
    }

    public static void inversions () {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите фразу для её инверсии: ");
        String phrase = scanner.nextLine();
        String[] ok_str = new StringBuilder(phrase).reverse().toString().split(" ");
        StringBuilder inv_str = new StringBuilder();
        for (int i= ok_str.length-1;i>=0;i--){
            inv_str.append(ok_str[i]+" ");
        }
        System.out.println(inv_str);

    }

}
