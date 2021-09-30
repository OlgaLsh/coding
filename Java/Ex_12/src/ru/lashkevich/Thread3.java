package ru.lashkevich;

public class Thread3 extends Thread{
    private Object object;

    public Thread3(Object object){
        this.object=object;
    }

    @Override
    public void run() {
        while(true){
            synchronized (object){
                try{
                    System.out.println(getName());
                    object.notify();
                    object.wait();
                }catch (InterruptedException e){
                    System.out.println(e.getMessage());
                }
            }
        }
    }
}
