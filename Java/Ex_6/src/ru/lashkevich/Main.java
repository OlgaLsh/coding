package ru.lashkevich;

public class Main {

    public static void main(String[] args) {
        // 1. Class Study
        Study st=new Study("Изучение Java-это просто!");
        System.out.println(st.printCourse());

        // 2. Class Home
        Home h1=new Home();
        Home h2=new Home();
        h1.All_data(10,1995,"ЖК Атлант");
        h2.All_data(25,2010,"ЖК Заречный");
        h1.Data_output();
        System.out.println("Количество лет с момента постройки: "+h1.Home_age()+"\n");
        h2.Data_output();
        System.out.println("Количество лет с момента постройки: "+h2.Home_age()+"\n");

        // 3. Class Tree
        Tree t1=new Tree(5,"Кедр", true);
        Tree t2=new Tree(15,"Ель");
        Tree t3=new Tree();

        //4. Class Plane
        Plane.Wing wing1=new Plane().new Wing();
        wing1.SetWeight(245.2);
        Plane.Wing wing2=new Plane().new Wing();
        wing2.SetWeight(300);
        System.out.println("Вес крыла 1: "+wing1.GetWeight()+"\nВес крыла 2: "+wing2.GetWeight());


    }
}
