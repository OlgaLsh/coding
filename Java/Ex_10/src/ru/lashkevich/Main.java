package ru.lashkevich;

import java.io.IOException;
import java.util.*;


public class Main {

    public static void main(String[] args) throws IOException {
        ArrayList<String> lang = new ArrayList<>();
        lang.add("Apple");
        lang.add("Banana");
        lang.add("Orange");
        lang.add("Apple");
        lang.add("Orange");
        lang.add("Melon");
        for(String l : UniqueColl(lang)){
            System.out.println(l);
        }
        ArrayList<String> list1=new ArrayList<>();
        LinkedList<String> list2=new LinkedList<>();
        System.out.println("Время добавления 1000000 элементов в ArrayList: ");
        MinElements(list1);
        System.out.println("Время добавления 1000000 элементов в LinkedList: ");
        MinElements(list2);
        System.out.println("Время выбора элемента 100000 раз из ArrayList: ");
        RandomElem(list1);
        System.out.println("Время выбора элемента 100000 раз из 100000 раз из LinkedList: ");
        RandomElem(list2);

        Map<User,Integer> U_scores = new HashMap<>();
        U_scores.put(new User("Анна"),95);
        U_scores.put(new User("Мария"),84);
        U_scores.put(new User("Екатерина"),63);
        U_scores.put(new User("Елена"),81);

        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите имя пользователя: ");
        String name= scanner.nextLine();
        User user = new User(name);
        Integer score = U_scores.get(user);
        if (score!=null)
            System.out.println("У пользователя "+ name + " " + score+" очков");
        else
            System.out.println(name+" не в списке");

        System.out.println(arrayToMap(lang.toArray()));

    }
    public static TreeSet<String> UniqueColl(ArrayList<String> list){
        TreeSet<String> list2 = new TreeSet<>(list);
        return list2;
    }
    public static void MinElements(List<String> list){
        long startTime=System.nanoTime();
        for(int i=0;i<1000000;i++){
            String p ="Added string";
            list.add(p);
        }
        long estimatedTime=System.nanoTime()-startTime;
        System.out.println(estimatedTime);
    }
    public static void RandomElem(List<String>list){
        long startTime=System.nanoTime();
        for(int i=0;i<100000;i++){
            list.get((int)Math.random()*1000000);
        }
        long estimatedTime=System.nanoTime()-startTime;
        System.out.println(estimatedTime);
    }
    public static <K>Map<K,Integer> arrayToMap(K[]ks){
        Map<K,Integer> result=new HashMap<>();
        for (K k:ks){
            if (result.containsKey(k)){
                result.put(k,result.get(k)+1);
            }
            else
                result.put(k,1);
        }
        return result;
    }
}
