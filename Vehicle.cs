using System;


class Vehicle
{
    public string VehicleNumber { get; set; }
    public string ModelName { get; set; }


    public Vehicle(string vehicleNumber, string modelName)
    {
        VehicleNumber = vehicleNumber;
        ModelName = modelName;
    }
}

// Derived class
class Car : Vehicle
{
    public string CarType { get; set; }

    public Car(string vehicleNumber, string modelName, string carType)
        : base(vehicleNumber, modelName)
    {
        CarType = carType;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Car Details ---");
        Console.WriteLine("Vehicle Number: " + VehicleNumber);
        Console.WriteLine("Model Name: " + ModelName);
        Console.WriteLine("Car Type: " + CarType);
    }
}

class Program2
{
    static void Main()
    {

        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");
        Console.Write("Enter Vehicle Number: ");
        string number = Console.ReadLine();

        Console.Write("Enter Model Name: ");
        string model = Console.ReadLine();

        Console.Write("Enter Car Type: ");
        string type = Console.ReadLine();

    
        Car car = new Car(number, model, type);

        car.DisplayDetails();
    }
}