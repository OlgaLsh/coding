package ru.lashkevich;

import java.util.ArrayList;

public class Box implements Shape{
    private double volume;
    private ArrayList<Shape> shapes = new ArrayList<>();
    public Box(double volume){
        this.volume=volume;
    }
    public boolean add(Shape fig){
        if(this.volume>=fig.getVolume()) {
            shapes.add(fig);
            this.volume -= fig.getVolume();
            return true;
        }
        else
            return false;
    }

    @Override
    public double getVolume() {
        return this.volume;
    }
}
