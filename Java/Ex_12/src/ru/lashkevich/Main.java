package ru.lashkevich;

public class Main {

    public static void main(String[] args) throws InterruptedException {
        for(int i=1;i<=10;i++){
            new Thread1("Thread_" + i).start();
        }

        Thread thread1 = new Thread1("Thread1");
        System.out.println(thread1.getState());
        thread1.start();
        System.out.println(thread1.getState());
        Thread.sleep(1000);
        System.out.println("\n"+thread1.getState());

        Counter counter = new Counter();
        for (int i = 0; i < 100; i++) {
            new Thread2(counter).start();
        }
        Thread.sleep(1000);
        System.out.println(counter.count);

        Object object=new Object();
        new Thread3(object).start();
        new Thread3(object).start();
    }
}
