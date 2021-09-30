package ru.lashkevich;

import java.util.Scanner;
import java.time.Year;

public class Home {
    private int floors;
    private int year;
    private String name;
    public void All_data(int floors,int year,String name){
        this.floors=floors;
        this.year=year;
        this.name=name;
    }
    public void Data_output(){
        System.out.println("Name: "+name+"\nYear built: "+year+"\nNumber of floors: "+floors);
    }
    public int Home_age(){
        int age=Year.now().getValue()-year;
        return age;
    }
}
