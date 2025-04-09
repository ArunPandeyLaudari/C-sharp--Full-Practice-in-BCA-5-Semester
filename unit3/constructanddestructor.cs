using System;

class Example
{
    private string message;

    // Constructor
    public Example(string msg)
    {
        message = msg;
        Console.WriteLine("Constructor called: " + message);
    }

    // Destructor
    ~Example()
    {
        Console.WriteLine("Destructor called for message: " + message);
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Message: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Example example = new Example("Hello, Constructor and Destructor!");
        example.DisplayMessage();

        // The destructor will be called automatically when the object is garbage collected.
    }
}