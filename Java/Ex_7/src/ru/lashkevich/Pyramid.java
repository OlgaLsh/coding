package ru.lashkevich;

public class Pyramid implements Shape{
    private double s;
    private double h;
    private double volume;

    public Pyramid (double s,double h){
        this.s=s;
        this.h=h;
    }
    public double getVolume(){
        return volume=(s*h)/3;
    }

}