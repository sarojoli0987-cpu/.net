using System;

class Student
{
    private string[] names = new string[3];

    // Indexer
    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // Using the indexer
        s[0] = "Ram";
        s[1] = "Shyam";
        s[2] = "Hari";

        Console.WriteLine("Students:");
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);
    }
}
