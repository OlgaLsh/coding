package ru.lashkevich;

public class Tree {
    private int age;
    private String name;
    private boolean living_tree;
    public Tree(int age, String name){
        this.name=name;
        this.age=age;
    };
    public Tree(int age,String name,boolean living_tree){
        this.name=name;
        this.age=age;
        this.living_tree=living_tree;
    };
    public Tree(){
        System.out.println("Пустой конструктор без параметров сработал\n");
    }
}
