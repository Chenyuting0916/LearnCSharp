namespace LearnCSharp;

public class Relationship
{
    private Dog a = new Dog();
}

public class Animal
{
    
}

public class Dog : Animal
{
    // is a relationship    
}


public class School{
    // has a relationship
    public Student Student { get; set; }
}

public abstract class Student
{
}