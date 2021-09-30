package ru.lashkevich;

public class Ball extends SolidOfRevolution{
    public Ball(double radius){
        super(radius);
    }

    @Override
    public double getVolume() {
        volume=(4*Math.PI*Math.pow(radius,3))/3;
        return volume;
    }
}
