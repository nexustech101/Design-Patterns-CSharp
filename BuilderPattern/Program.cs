using Builders;  // for IComputerBuilder and ComputerBuilder
using Directors; // for ComputerDirector
using Models;    // for Computer

class Program
{
    static void Main(string[] args)
    {
        // Creating the builder
        IComputerBuilder builder = new ComputerBuilder();

        // Director responsible for guiding the builder
        ComputerDirector director = new ComputerDirector(builder);

        // Build a gaming computer
        Computer gamingComputer = director.BuildGamingComputer();
        Console.WriteLine("Gaming Computer: " + gamingComputer);

        // Build an office computer
        Computer officeComputer = director.BuildOfficeComputer();
        Console.WriteLine("Office Computer: " + officeComputer);
    }
}
