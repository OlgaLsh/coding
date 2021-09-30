package ru.lashkevich;

public abstract class SolidOfRevolution implements Shape{
    protected double radius;
    protected double volume;
    public SolidOfRevolution(double radius){
        this.radius=radius;
    }
    @Override
    public double getVolume() {
        return this.volume;
    }
}
