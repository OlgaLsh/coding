package ru.lashkevich;

import java.io.*;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;


public class Main {

    public static void main(String[] args) {

        readFile("./first.txt").forEach(System.out::println);
        //writeFile("./second.txt", "It's true!");
        //concatFiles("./first.txt", "./second.txt");
        //copyFile("./first.txt");
        //findFileName("./", "second").forEach(System.out::println);
        //findContainsInFile("./", "Java").forEach(System.out::println);
    }

    public static List<String> readFile (String path) {
        List<String> result = new ArrayList<>();
        try (BufferedReader reader = new BufferedReader(new FileReader(path))) {
            String line;
            while ((line = reader.readLine()) != null) {
                result.add(line);
            }
        }
        catch(IOException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    public static void writeFile (String path, String text) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(path, true))) {
            writer.append(text).append("\n");
        }
        catch (IOException ex) {
            System.out.println(ex.getMessage());
        }

    }

    public static void concatFiles (String path1, String path2) {
        List<String> file1 = readFile(path1);
        List<String> file2 = readFile(path2);
        file1.forEach(it->writeFile("./third.txt", it));
        file2.forEach(it->writeFile("./third.txt", it));
    }

    public static void copyFile (String path) {
        List<String> file = readFile(path);
        file.forEach(it->writeFile(path.replace(".txt", "(copy).txt"), it));
    }

    public static List<String> findFileName (String dir, String substring) {
        File folder = new File(dir);
        try {
            File[] listOfFiles = folder.listFiles();
            return Stream.of(listOfFiles)
                    .filter(File::isFile)
                    .map(File::getName)
                    .filter(it -> it.contains(substring))
                    .collect(Collectors.toList());
        }
        catch (Exception ex) {
            System.out.println(ex.getMessage());
            return Collections.emptyList();
        }
    }

    public static List<String> findContainsInFile (String dir, String substring) {
        File folder = new File(dir);
        try {
            File[] listOfFiles = folder.listFiles();
            List<String> result = new ArrayList<>();
            return Stream.of(listOfFiles)
                    .filter(File::isFile)
                    .filter(file -> readFile(file.getPath())
                            .toString()
                            .toLowerCase()
                            .contains(substring.toLowerCase()))
                    .map(File::getName)
                    .collect(Collectors.toList());
        }
        catch (NullPointerException ex) {
            System.out.println(ex.getMessage());
            return Collections.emptyList();
        }
    }
}
