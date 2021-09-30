package ru.lashkevich;

import java.util.Random;

public class vector {
    private double x;
    private double y;
    private double z;

    vector(){
        x=y=z=0;
    }

    public vector(double x, double y, double z) {
        this.x = x;
        this.y = y;
        this.z = z;

    }

    public double VectorLength(){
        return Math.sqrt(Math.pow(x,2)+Math.pow(y,2)+Math.pow(z,2));
    }

    public double ScalarMult(vector v){
        vector v2=new vector();
        double sc = x*v.x+y*v.y+z*v.z;
        return sc;
    }

    public vector VectorMult (vector v1, vector v2) {
        double x3=v1.y*v2.z-v2.y*v1.z;
        double y3=v1.x*v2.z-v2.x*v1.z;
        double z3=v1.x*v2.y-v2.x*v1.y;
        vector v3 = new vector(x3,y3,z3);
        return  v3;
    }

    public double VectorAngle (vector v) {
        double SM=this.ScalarMult(v);
        double vl1=this.VectorLength();
        double vl2=v.VectorLength();
        double cosA=SM/(vl1*vl2);
        return  cosA;
    }

    public vector SumVectors (vector v1, vector v2) {
        double x3=v1.x+v2.x;
        double y3=v1.y+v2.y;
        double z3=v1.z+v2.z;
        vector v=new vector(x3,y3,z3);
        return v;

    }

    public vector DifferenceVectors (vector v1, vector v2) {
        double x3=v1.x-v2.x;
        double y3=v1.y-v2.y;
        double z3=v1.z-v2.z;
        vector v=new vector(x3,y3,z3);
        return v;
    }
    public static vector[] VectorArray(int N){
        vector[] VArr = new vector[N];
        for (int i=0;i<N;i++){
            vector v = new vector(Math.random()*10,Math.random()*10,Math.random()*10);
            VArr[i]=v;
        }
        return VArr;
    }
    @Override
    public String toString(){
        return String.format("{%.2f;%.2f;%.2f}",x,y,z);
    }

}