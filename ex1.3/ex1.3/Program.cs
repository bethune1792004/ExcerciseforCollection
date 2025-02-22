using System;
using System.Collections.Generic;
using System.Linq;

public class Student : IComparable<Student>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        ID = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}";
    }

    // Implement IComparable to sort by Name
    public int CompareTo(Student other)
    {
        if (other == null) return 1; // Handle null case

        return Name.CompareTo(other.Name); // Sort by name
    }


    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        students.Add(new Student(1, "Alice", 20));
        students.Add(new Student(3, "Bob", 22));
        students.Add(new Student(2, "Charlie", 21));
        students.Add(new Student(4, "David", 19));
        students.Add(new Student(5, "Eve", 23));


        // Sort the list by Name
        students.Sort();  // Uses the CompareTo method we implemented

        // Print the sorted list
        Console.WriteLine("Sorted list of students by name:");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        // Alternative sorting using LINQ (more concise, but less efficient for large lists)
        Console.WriteLine("\nSorted list of students by name (LINQ):");
        var sortedStudents = students.OrderBy(s => s.Name).ToList();
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

    }
}