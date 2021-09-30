package ru.lashkevich;

public class Cylinder extends SolidOfRevolution{
    private double height;
    public Cylinder(double height,double radius){
        super(radius);
        this.height=height;
    }

    @Override
    public double getVolume() {
        volume=Math.PI*height*Math.pow(radius,2);
        return volume;
    }
}