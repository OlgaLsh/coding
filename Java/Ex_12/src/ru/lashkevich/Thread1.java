package ru.lashkevich;

public class Thread1 extends Thread{
    Thread1(String name){
        super(name);
    }
    @Override
    public void run(){
        String name = Thread.currentThread().getName();
        System.out.println("\n"+name + " started"+"\n");
        for (int i=1;i<=100;i++){
            System.out.print(i+" ");
        }
    }
}
