// See https://aka.ms/new-console-template for more information

//Person person1 = new();
//person1.Name = "umer";
//person1.Age = 23;
//Console.WriteLine($"Full name is {person1.FullName}");
//class Person
//{
//    private string name;
//    private int age;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//    public int Age 
//    {
//        get { return age; }
//        set 
//        { 
//        if(value > 30)
//            {
//                age = 0;
//            }
//        else
//            {
//                age = value;
//            }
//        }
//    }
//    public string FullName
//    {
//        get { return $"{name} {age}"; }
//    }
//}



// Person Info
//Person person1 = new();
//person1.Name = "Umer";
//person1.Age = 23;
//Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
//class Person
//{
//    private string name;
//    private int age;
    
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//    public int Age
//    {
//        get { return age; }
//        set 
//        {
//            if (value > 0)
//            {
//                age = value;
//            }
//            else
//            {
//                Console.WriteLine("Age must be positive!");
//            }
//        }
//    }
//}



// Student Report System
//Student student = new("Ali", 18, 86);
//Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Marks: {student.Marks}, Grade: {student.Grade}");

//class Student
//{
//    private string name;
//    private int age;
//    private double marks;

//    public Student(string name, int age, double marks)
//    {
//        this.name = name;
//        this.age = age;
//        this.marks = marks;
//    }

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (!string.IsNullOrWhiteSpace(value))
//            {
//                name = value;
//            }
//            else
//            {
//                Console.WriteLine("Name can't be empty!");
//            }
//        }
//    }
//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value > 0 && age <= 100)
//            {
//                age = value;
//            }
//            else
//            {
//                Console.WriteLine("Invalid age entered!");
//            }
//        }
//    }
//    public double Marks
//    {
//        get { return marks; }
//        set
//        {
//            if (value >= 0 && value <= 100)
//            {
//                marks = value;
//            }
//            else
//            {
//                Console.WriteLine("Marks should be between 0 and 100!");
//            }
//        }
//    }
//    public string Grade
//    {
//        get
//        {
//            if (marks >= 80)
//            {
//                return "A";
//            }
//            else if (marks >= 60)
//            {
//                return "B";
//            }
//            else if (marks >= 40)
//            {
//                return "C";
//            }
//            else
//            {
//                return "F";
//            }
//        }
//    }
//}


