// Program.cs
using System;
using AbstractFactoryPattern.Factories;  // Importing Factories namespace
using AbstractFactoryPattern.Products;   // Importing Products namespace

class Program
{
    static void buildWindowsButton()
    {
        // Create a factory based on the platform (for example, WindowsFactory)
        IUIFactory factory = new WindowsFactory(); // Ensure this line uses parentheses to instantiate the object.

        // Now create products using the factory
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();

        // Render the button and checkbox
        button.Render();
        button.OnClick();

        checkbox.Render();
        checkbox.OnCheck();
    }

    static void buildMacOSButton()
    {
        // Create a factory based on the platform (for example, WindowsFactory)
        IUIFactory factory = new MacOSFactory(); // Ensure this line uses parentheses to instantiate the object.

        // Now create products using the factory
        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();

        // Render the button and checkbox
        button.Render();
        button.OnClick();

        checkbox.Render();
        checkbox.OnCheck();
    }

    static void Main(string[] args)
    {
        // Build Mac OS style button
        buildMacOSButton();
        Console.WriteLine("\n");
        // Build the windows style button
        buildWindowsButton();
    }
}
