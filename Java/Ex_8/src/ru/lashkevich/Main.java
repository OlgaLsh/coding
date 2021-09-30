package ru.lashkevich;

public class Main {

    public static void main(String[] args) {
        Customer cust1=new Customer("Карташова","Алина","Тинькофф");
        cust1.Print();
        BankEmployee bankemp1=new BankEmployee("Комиссарова","Елена","Сбербанк");
        bankemp1.Print();

        Customer cust2=new Customer("Прокофьев","Афанасий","Совхозбанк");
        cust2.Print();
        BankEmployee bankemp2=new BankEmployee("Иващенко","Александра","Банк Санкт-Петербург");
        bankemp2.Print();
    }
}
