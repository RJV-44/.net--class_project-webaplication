using System;

/*
 ====================================================================================================
                                      RULES OF CONSTRUCTORS IN C#
 ====================================================================================================

 WHAT IS A CONSTRUCTOR?
 ----------------------
 A Constructor is a special member method of a class or struct that is invoked automatically 
 whenever an instance (object) of that type is created using the 'new' keyword.
 Its primary purpose is to allocate memory and initialize the object's fields and data members.

 KEY RULES OF CONSTRUCTORS:
 --------------------------
 1. NAME MATCHING:
    - A constructor MUST have the exact same name as its declaring class or struct.
    - It is case-sensitive (e.g., class 'Car' must have constructor 'Car()').

 2. NO RETURN TYPE:
    - A constructor CANNOT have any return type, not even 'void'.
    - Specifying a return type turns it into a regular method, not a constructor.

 3. AUTOMATIC INVOCATION:
    - Constructors are called automatically when an object is instantiated via 'new'.
    - They cannot be invoked directly like ordinary methods (except via constructor chaining: 'this()' or 'base()').

 4. DEFAULT (IMPLICIT) CONSTRUCTOR:
    - If you DO NOT define any constructor in a class, the C# compiler automatically provides 
      a public parameterless constructor (default constructor).
    - It initializes numeric types to 0, booleans to false, and reference types to null.

 5. LOSS OF DEFAULT CONSTRUCTOR:
    - As soon as you define ANY constructor (such as a parameterized constructor), the C# compiler 
      NO LONGER provides the implicit default parameterless constructor.
    - If you still need a parameterless constructor, you MUST explicitly write it.

 6. ACCESS MODIFIERS:
    - Constructors can have access modifiers: public, private, protected, internal, protected internal, private protected.
    - EXCEPTION: Static constructors CANNOT have any access modifier.

 7. CONSTRUCTOR OVERLOADING:
    - A class can have multiple constructors as long as their parameter lists are unique 
      (differing in number of parameters, data types, or parameter order).

 8. STATIC CONSTRUCTOR RULES:
    - Declared using the 'static' keyword (e.g., 'static MyClass() { }').
    - CANNOT take any parameters.
    - CANNOT have any access modifier (no public, private, etc.).
    - Executed automatically ONLY ONCE per type (before the first instance is created or any static member is accessed).
    - Cannot be called manually and cannot be inherited.

 9. PRIVATE CONSTRUCTOR RULES:
    - If a class only has private constructors, it CANNOT be instantiated from outside the class.
    - Commonly used in:
      a) Singleton Design Pattern (controlled single instance).
      b) Utility / Helper classes containing only static methods (e.g., System.Math).

 10. CONSTRUCTOR CHAINING:
     - Using 'this(...)': Calls another constructor within the SAME class (avoids duplicate initialization code).
     - Using 'base(...)': Calls a constructor in the PARENT / BASE class.
     - Execution Order in Inheritance: Base class constructor ALWAYS executes BEFORE the derived class constructor.

 11. DISALLOWED KEYWORDS:
     - Constructors CANNOT be declared as: abstract, virtual, override, sealed, or async.

 12. STRUCT CONSTRUCTOR RULES:
     - In C# 7.3 / .NET Framework, structs cannot contain an explicit parameterless constructor.
     - Struct parameterized constructors must initialize ALL fields of the struct before exiting.

 13. COPY CONSTRUCTOR PATTERN:
     - C# does not have a dedicated copy constructor keyword (unlike C++), but the pattern is 
       implemented by creating a constructor that accepts an object of the same class and copies its values.

 ====================================================================================================
*/

namespace Concept_demo
{
    // ==============================================================================================
    // 1. ORIGINAL DEMO CLASS: Parameterless & Parameterized Constructors
    // ==============================================================================================
    internal class Constructor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        // CONCEPT: Default / Parameterless Constructor (User-Defined)
        // Explicitly defined so callers can create an empty instance or use object initializers.
        public Constructor()
        {
            Name = "Default Product";
            Description = "No description provided";
            Price = 0.0;
        }

        // CONCEPT: Parameterized Constructor
        // Accepts parameters to initialize object fields at the time of creation.
        public Constructor(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }

    // ==============================================================================================
    // 2. COMPREHENSIVE CONSTRUCTOR DEMO CLASS:
    //    Overloading, Chaining (this), Copy Constructor, Static Constructor, Optional Parameters
    // ==============================================================================================
    public class DemoProduct
    {
        // Instance Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        // Static field shared across all instances
        public static string StoreName;
        public static int TotalInstanceCount;

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Static Constructor
        // - Rule: No access modifiers (cannot be public/private).
        // - Rule: Cannot take parameters.
        // - Rule: Runs ONLY ONCE before the first object is instantiated or static member accessed.
        // ------------------------------------------------------------------------------------------
        static DemoProduct()
        {
            StoreName = "Antigravity MegaMart";
            TotalInstanceCount = 0;
            Console.WriteLine("[Static Constructor] Invoked: StoreName initialized to '" + StoreName + "'.");
        }

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Master Parameterized Constructor
        // Initializes all core fields and increments the shared instance counter.
        // ------------------------------------------------------------------------------------------
        public DemoProduct(int id, string title, string category, double price)
        {
            Id = id;
            Title = title;
            Category = category;
            Price = price;
            TotalInstanceCount++;
            Console.WriteLine("[Parameterized Constructor] Full product created: " + Title);
        }

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Constructor Chaining using ': this(...)'
        // - Calls another constructor in the SAME class.
        // - Prevents redundant code and centralizes initialization logic.
        // ------------------------------------------------------------------------------------------
        public DemoProduct() : this(0, "Untitled Product", "General", 0.0)
        {
            Console.WriteLine("[Parameterless Constructor] Chained to Master Constructor with defaults.");
        }

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Constructor Overloading (Different Signature: 2 parameters)
        // - Chains to the 4-parameter constructor providing default category & price.
        // ------------------------------------------------------------------------------------------
        public DemoProduct(int id, string title) : this(id, title, "General", 0.0)
        {
            Console.WriteLine("[Overloaded Constructor] Chained with Id and Title.");
        }

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Copy Constructor
        // - A constructor that creates a new object by copying data from an existing object.
        // ------------------------------------------------------------------------------------------
        public DemoProduct(DemoProduct existingProduct)
        {
            if (existingProduct != null)
            {
                Id = existingProduct.Id;
                Title = existingProduct.Title + " (Copy)";
                Category = existingProduct.Category;
                Price = existingProduct.Price;
                TotalInstanceCount++;
                Console.WriteLine("[Copy Constructor] Cloned product from: " + existingProduct.Title);
            }
        }

        public void Display()
        {
            Console.WriteLine($"   ID: {Id} | Title: {Title} | Category: {Category} | Price: ${Price:F2}");
        }
    }

    // ==============================================================================================
    // 3. BASE CLASS & DERIVED CLASS: Constructor Chaining in Inheritance using ': base(...)'
    // ==============================================================================================
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        // Base class parameterized constructor
        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
            Console.WriteLine($"[Base Constructor] Vehicle initialized: {Brand} ({Year})");
        }
    }

    public class ElectricCar : Vehicle
    {
        public int BatteryCapacityKWh { get; set; }

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Base Constructor Chaining using ': base(...)'
        // - Rule: Base constructor ALWAYS executes FIRST before this derived constructor body.
        // - Passes 'brand' and 'year' up to the Vehicle base constructor.
        // ------------------------------------------------------------------------------------------
        public ElectricCar(string brand, int year, int batteryCapacity) : base(brand, year)
        {
            BatteryCapacityKWh = batteryCapacity;
            Console.WriteLine($"[Derived Constructor] ElectricCar initialized with {BatteryCapacityKWh} kWh battery.");
        }
    }

    // ==============================================================================================
    // 4. PRIVATE CONSTRUCTOR: Singleton Pattern / Preventing External Instantiation
    // ==============================================================================================
    public class DatabaseManager
    {
        // Holds the single instance
        private static readonly DatabaseManager _instance = new DatabaseManager();

        public string ConnectionString { get; set; }

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Private Constructor
        // - Rule: Cannot be accessed from outside this class (e.g. 'new DatabaseManager()' is illegal).
        // - Ensures that only this class can instantiate itself.
        // ------------------------------------------------------------------------------------------
        private DatabaseManager()
        {
            ConnectionString = "Server=localhost;Database=DemoDb;Integrated Security=True;";
            Console.WriteLine("[Private Constructor] DatabaseManager instance created internally.");
        }

        // Public property providing global access to the single instance
        public static DatabaseManager Instance
        {
            get { return _instance; }
        }
    }

    // ==============================================================================================
    // 5. STRUCT CONSTRUCTOR: Value Type Constructors
    // ==============================================================================================
    public struct CoordinatePoint
    {
        public int X;
        public int Y;

        // ------------------------------------------------------------------------------------------
        // CONCEPT: Struct Parameterized Constructor
        // - Rule: In C# 7.3, all fields (X and Y) MUST be explicitly assigned before constructor finishes.
        // ------------------------------------------------------------------------------------------
        public CoordinatePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"   Coordinate Point: ({X}, {Y})");
        }
    }

    // ==============================================================================================
    // 6. EXPRESSION-BODIED CONSTRUCTOR (C# 7+)
    // ==============================================================================================
    public class Customer
    {
        public string FullName { get; set; }

        // CONCEPT: Expression-Bodied Constructor
        // Uses the '=>' lambda operator for single-line constructor implementations.
        public Customer(string fullName) => FullName = fullName;
    }

    // ==============================================================================================
    // 7. DEMONSTRATION & EXECUTION (Main Entry Point)
    // ==============================================================================================
    class Details
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("         C# CONSTRUCTORS - COMPREHENSIVE CONCEPT DEMO           ");
            Console.WriteLine("================================================================\n");

            // --------------------------------------------------------------------------------------
            // Demo 1: Original Code Demonstration (User's Constructor Class)
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 1: Parameterized & Default Constructors (Original Demo) ---");
            Constructor c1 = new Constructor("Laptop", "This is a laptop", 50000);
            Console.WriteLine("Name: " + c1.Name);
            Console.WriteLine("Description: " + c1.Description);
            Console.WriteLine("Price: " + c1.Price);

            var c2 = new Constructor();
            c2.Name = "Tablet";
            c2.Description = "This is a tablet";
            c2.Price = 25000;
            Console.WriteLine("Name: " + c2.Name);
            Console.WriteLine("Description: " + c2.Description);
            Console.WriteLine("Price: " + c2.Price);
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 2: Static Constructor
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 2: Static Constructor ---");
            Console.WriteLine("Accessing static property 'DemoProduct.StoreName' (triggers static constructor):");
            Console.WriteLine("Store: " + DemoProduct.StoreName);
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 3: Parameterized Constructor & Overloading
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 3: Parameterized Constructor & Overloading ---");
            DemoProduct p1 = new DemoProduct(101, "Mechanical Keyboard", "Accessories", 89.99);
            p1.Display();
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 4: Constructor Chaining via 'this(...)'
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 4: Constructor Chaining (: this) ---");
            DemoProduct p2 = new DemoProduct(); // Chained to 4-parameter constructor
            p2.Display();

            DemoProduct p3 = new DemoProduct(102, "Wireless Mouse"); // Chained to 4-parameter constructor
            p3.Display();
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 5: Copy Constructor
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 5: Copy Constructor ---");
            DemoProduct p4 = new DemoProduct(p1); // Copies values from p1
            p4.Display();
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 6: Inheritance & Base Constructor Chaining (: base)
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 6: Inheritance & Base Chaining (: base) ---");
            ElectricCar ev = new ElectricCar("Tesla", 2024, 85);
            Console.WriteLine($"   Vehicle: {ev.Brand} | Year: {ev.Year} | Battery: {ev.BatteryCapacityKWh} kWh");
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 7: Private Constructor (Singleton Pattern)
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 7: Private Constructor (Singleton) ---");
            // DatabaseManager db = new DatabaseManager(); // COMPILE ERROR! Private constructor cannot be called from outside.
            DatabaseManager db1 = DatabaseManager.Instance;
            DatabaseManager db2 = DatabaseManager.Instance;
            Console.WriteLine("   Connection: " + db1.ConnectionString);
            Console.WriteLine("   Are db1 and db2 the exact same instance? " + ReferenceEquals(db1, db2));
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 8: Struct Constructor
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 8: Struct Constructor ---");
            CoordinatePoint pt = new CoordinatePoint(45, 90);
            pt.Display();
            Console.WriteLine();

            // --------------------------------------------------------------------------------------
            // Demo 9: Expression-Bodied Constructor (C# 7+)
            // --------------------------------------------------------------------------------------
            Console.WriteLine("--- DEMO 9: Expression-Bodied Constructor ---");
            Customer customer = new Customer("Alice Johnson");
            Console.WriteLine("   Customer Name: " + customer.FullName);
            Console.WriteLine();

            // Summary
            Console.WriteLine($"Total DemoProduct instances created: {DemoProduct.TotalInstanceCount}");
            Console.WriteLine("================================================================");
            Console.WriteLine("Demo completed successfully.");
        }
    }
}
