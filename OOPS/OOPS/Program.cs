using System;

// Interface definition
interface IAnimal
{
    void MakeSound(); // Method to make sound
}

// Base class
class Animal : IAnimal
{
    // Private field
    private static int totalCount = 0;

    // Public property
    public static int TotalCount
    {
        get { return totalCount; }
    }

    // Private constructor
    private Animal()
    {
        totalCount++;
    }

    // Public constructor
    public Animal(string name)
    {
        Name = name;
        totalCount++;
    }

    // Public property
    public string Name { get; set; }

    // Public method to make sound
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    // Public static method
    public static void PrintTotalCount()
    {
        Console.WriteLine("Total animals created: " + totalCount);
    }
}

// Derived class
class Dog : Animal
{
    // Constructor
    public Dog(string name) : base(name)
    {
    }

    // Override method to make sound
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects
        Dog dog = new Dog("Buddy");
        Animal animal = new Animal("Unknown");

        // Calling methods
        dog.MakeSound();
        animal.MakeSound();

        // Calling static method
        Animal.PrintTotalCount();

        Console.ReadLine();
    }
}
