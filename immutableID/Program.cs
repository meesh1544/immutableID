using System;
namespace immutableID
{
  class Student
  {
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    
    public Student(int i)
    {
        Id = i;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Student(int i, string First, string Last) 
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }
   
    public static void Main()
    {
        Student student = new(01, "Hazel", "Basil");
        Console.WriteLine(student);
        Student student2 = new(02);
        student2.FirstName = "Kody";
        student2.LastName = "Klure";
        Console.WriteLine(student2);
     }
   }
}
