package ru.lashkevich;

public class User {
    private String Name;
    public User(String Name){
        this.Name=Name;
    }
    public String getName(){
        return this.Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }
    @Override
    public boolean equals(Object ob){
        if(this==ob){
            return true;
        }
        return Name.equals(((User)ob).Name);
    }
    @Override
    public int hashCode() {
        return this.Name.hashCode();
    }
}
