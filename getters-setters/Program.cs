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



// Person Information
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




// Temperature Control
//RoomTemperature room = new();
//room.Temperature = 6;
//class RoomTemperature
//{
//    private double temperature;
//    public double Temperature
//    {
//        get { return temperature; }
//        set
//        {
//            if (value <= 16)
//            {
//                Console.WriteLine("Too Cold!");
//            }
//            else if(value >= 30)
//            {
//                Console.WriteLine("Too Hot!");
//            }
//            else
//            {
//                temperature = value;
//                Console.WriteLine($"Temperature set successfully! ({temperature}°C)");
//            }
//        }
//    }
//}



// Bank Account
//BankAccount account = new();
//account.AccountNumber = 12345;
//account.Balance = 500.0;
//account.Deposit(250.0);
// account.ShowInfo();
//class BankAccount
//{
//    private int accountNumber;
//    private double balance;

//    public int AccountNumber
//    {
//        get { return accountNumber; }
//        set { accountNumber = value; }
//    }
//    public double Balance
//    {
//        get { return balance; }
//        set
//        {
//            if (value > 0)
//            {
//                balance = value;
//            }
//            else
//            {
//                Console.WriteLine("Balance cannot be negative!");
//            }
//        }
//    }
//    public void Deposit(double amount)
//    {
//        if(amount > 0)
//        {
//            balance += amount;
//            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid deposit amount!");
//        }
//    }
//    public void ShowInfo()
//    {
//        Console.WriteLine($"Account Number: {accountNumber}, Balance: {balance}");
//    }
//}



// Product Inventory
//Product product1 = new();
//product1.Name = "Laptop";
//product1.Price = 1200.50;
//product1.Quantity = 3;
//Console.WriteLine($"Product: {product1.Name}, Price: {product1.Price}, Quantity: {product1.Quantity}, Product Value: {product1.TotalValue}");

//class Product
//{
//    private string name;
//    private double price;
//    private int quantity;

//    public string Name
//    {
//        get { return name; }
//        set { name = value ; }
//    }
//    public double Price
//    {
//        get { return price; }
//        set
//        {
//            if(value > 0)
//            {
//                price = value;
//            }
//            else
//            {
//                Console.WriteLine("Price can't be less than 0");
//            }
//        }
//    }
//    public int Quantity
//    {
//        get { return quantity; }
//        set
//        {
//            if(value >= 0)
//            {
//                quantity = value;
//            }
//            else
//            {
//                Console.WriteLine("Quantity can't be negative");
//            }
//        }
//    }
//    public double TotalValue
//    {
//        get { return price * quantity; }

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


