package ru.lashkevich;

public class Truck extends Car{
    private int wheels;
    private int max_weight;

    public void newWheels(int wheels){
        this.wheels = wheels;
        System.out.println("Количество колёс: " + this.wheels);
    }

    public Truck (int w, String m, char c, float s, int wheels, int max_weight){
        super(w,m,c,s);
        this.wheels=wheels;
        this.max_weight=max_weight;
    }

}
