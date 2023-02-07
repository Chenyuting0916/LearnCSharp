namespace LearnCSharp.BasicCsharp;

// public class Relationship
// {
//     private Dog _dog = new Dog();
//     private Student? _student = new School().Student;
// }

public class Animal
{
}

public class Dog : Animal
{
    // is-a relationship    
}

public class School
{
    // has-a relationship
    public Student Student { get; }

    public School(Student student)
    {
        Student = student;
    }
}

public class Student
{
}