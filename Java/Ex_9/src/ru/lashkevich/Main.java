package ru.lashkevich;

import java.util.Random;

public class Main {

    public static void main(String[] args) {

        int[][] array = {{123,400}, {124,742}, {125,351}};
        Main arr = new Main();
        System.out.println(arr.MaxElem(array));
        System.out.println(arr.IsSquare(array));
        System.out.println("Строка с максимальной суммой элементов:  " + arr.MaxSum(array));
        char[][] array1 = {{'X','X'}, {'X','X'}, {'X','X'}};
        arr.AlphabetArr(array1);
    }

    // 1. метод для поиска наибольшего элемента в двумерном массиве
    public int MaxElem(int[][] array)
    {
        int a = 0;
        for (int i = 0; i<array.length; i++)
        {
            for (int j = 0; j <array[i].length; j ++)
            {
                if (array[i][j]>a)
                {
                    try
                    {
                        a = array[i][j];
                    }
                    catch (Exception e)
                    {
                        System.out.println("Exception found!");
                    }
                }
            }
        }
        System.out.println("Наибольший элемент в массиве: ");
        return a;
    }
    // 2. метод, который проверяет, является ли двумерный массив квадратным
    public String IsSquare(int[][] array)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i<array.length; i++)
        {
            a = i;
            for (int j = 0; j <array[i].length; j ++)
            {
                b = j;
            }
        }
        if (a == b)
        {
            return "Это квадратный двумерный массив";
        }
        else
        {
            return "Двумерный массив не является квадратным";
        }
    }
    // 3. метод, который, в двумерном массиве (матрице) ищет строку, сумма
    // элементов которой является максимальной среди всех строк матрицы
    public int MaxSum (int[][] array)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        for (int i = 0; i<array.length; i++)
        {
            for (int j = 0; j <array[i].length; j ++)
            {
                a += array[i][j];

            }
            if (a > b)
            {
                b = a;
                a = 0;
                c = i;
            }

        }
        return c;
    }
    // 4. Двумерный массив MxN заполнить случайными символами алфавита
    public void AlphabetArr(char[][] array)
    {
        Random random = new Random();
        int a=0;
        int b=33;

        char[] letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".toCharArray();
        System.out.println("Рандомное наполнение массива буквами алфавита: ");

        for (int i = 0; i<array.length; i++)
        {
            for (int j = 0; j <array[i].length; j++)
            {
                try {
                    int x = a + random.nextInt(b - a + 1);
                    array[i][j] = letters[x];
                }
                catch(Exception e)
                {
                    System.out.println("Exception found! Отсутствие букв!");
                }
                System.out.println(array[i][j]);
            }
        }
    }
}
