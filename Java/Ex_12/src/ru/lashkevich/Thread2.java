package ru.lashkevich;

public class Thread2 extends Thread{
    Counter counter;
    public Thread2(Counter counter){
        this.counter=counter;
    }
    @Override
    public void run() {
        synchronized (counter){
            for (int i=0;i<1000;i++){
                counter.increment();
            }
        }
    }
}