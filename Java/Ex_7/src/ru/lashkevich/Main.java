package ru.lashkevich;

public class Main {

    public static void main(String[] args) {
        //1. Car and Truck
        Truck truck = new Truck(34890, "Cat 772", 'ж', 80, 6, 82100);
        truck.outPut();
        truck.newWheels(8);

        //2. Shapes
        Shape fig1 = new Ball(4);
        Shape fig2=new Cylinder(2,4);
        Shape fig3= new Pyramid(15,12);
        Box box=new Box(500);
        System.out.println(box.add(fig1));
        System.out.println(box.add(fig2));
        System.out.println(box.add(fig3));
    }
}
