package ru.lashkevich;

public class Customer extends Person{

    private String bank;

    Customer(String Lastname,String Name,String bank){
        super(Lastname, Name);
        this.bank=bank;
    }
    public void Print(){
        System.out.println("Клиент "+Lastname+" "+Name+" обслуживается в банке "+bank);
    }
}
