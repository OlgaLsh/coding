package ru.lashkevich;

public class BankEmployee extends Person{
    private String bank;

    BankEmployee(String Lastname,String Name,String bank) {
        super(Lastname, Name);
        this.bank = bank;
    }
    public void Print(){
        System.out.println("Работница "+Lastname+" "+Name+" является сотрудницей в банке "+bank);
    }
}
