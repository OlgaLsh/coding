package ru.lashkevich;

public abstract class Person {
    protected String Name;
    protected String Lastname;

    public Person(String Name, String Lastname) {
        this.Name = Name;
        this.Lastname = Lastname;
    }

    public String getName(){
        return Name;
    }
    public String getLast_name(){
        return Lastname;
    }
    public abstract void Print();
}
