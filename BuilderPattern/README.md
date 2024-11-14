
---

# Builder Design Pattern in C#

This is an educational example of the **Builder Design Pattern** implemented in C#. The Builder pattern is a creational design pattern that allows constructing complex objects step by step. It is especially useful when the construction process involves several parts and configurations.

## Table of Contents

- [Introduction](#introduction)
- [Design Pattern Explanation](#design-pattern-explanation)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Classes and Components](#classes-and-components)
  - [Computer](#computer)
  - [IComputerBuilder](#icomputerbuilder)
  - [ComputerBuilder](#computerbuilder)
  - [ComputerDirector](#computerdirector)
- [Running the Project](#running-the-project)
- [Conclusion](#conclusion)

---

## Introduction

This project demonstrates the Builder Design Pattern using a **Computer** class as the product. The goal is to show how you can use the Builder pattern to construct different types of computers (e.g., a gaming PC and an office PC) by combining various components (CPU, RAM, GPU, etc.) through a series of method calls, instead of creating a constructor with too many parameters.

The Builder pattern decouples the construction of the object from its representation, allowing you to create a complex object step by step and potentially reuse the same builder to create different configurations.

---

## Design Pattern Explanation

The **Builder Pattern** separates the construction of an object from its representation. This allows the same construction process to create different representations. This pattern involves the following key components:

1. **Builder**: Specifies the abstract steps for constructing a product.
2. **ConcreteBuilder**: Implements the Builder interface to construct the parts of the product and assemble them.
3. **Product**: The complex object being constructed (e.g., `Computer`).
4. **Director**: Responsible for constructing the product using a specific Builder object.

In our case:
- **Product** is a `Computer` object.
- **Builder** is represented by the `IComputerBuilder` interface and its implementation in `ComputerBuilder`.
- **Director** is the `ComputerDirector`, which constructs different configurations of `Computer` using a builder.

---

## Project Structure

The project is structured as follows:

```
BuilderDesignPattern/
│
├── BuilderDesignPattern.csproj       # Project file
├── Program.cs                        # Main entry point (client code)
│
├── Models/                           # Folder for the product (complex object)
│   └── Computer.cs                   # Product: Computer class
│
├── Builders/                         # Folder for builder-related classes
│   ├── IComputerBuilder.cs           # Builder interface
│   └── ComputerBuilder.cs            # Concrete Builder
│
├── Directors/                        # Folder for the Director class
│   └── ComputerDirector.cs           # Director class
│
└── README.md                         # Documentation for the project
```

### `Program.cs`
The main entry point of the program where the client code creates the builder and director, then demonstrates how the builder pattern works.

### `Models/Computer.cs`
Defines the `Computer` class, which represents the product being built (a complex object). The class includes properties such as CPU, RAM, Storage, GPU, and OS.

### `Builders/IComputerBuilder.cs`
An interface defining the steps required to build a `Computer`. This interface outlines the methods for setting various parts of the computer.

### `Builders/ComputerBuilder.cs`
A concrete implementation of the `IComputerBuilder` interface. This class builds the parts of the `Computer` object step by step.

### `Directors/ComputerDirector.cs`
A director class that constructs a specific `Computer` configuration by using a builder. The director uses the builder's methods to create different kinds of computers (e.g., a gaming computer or an office computer).

---

## Usage

1. Clone the repository or download the project files.
2. Open the project folder in your preferred IDE (e.g., Visual Studio, Visual Studio Code).
3. Restore dependencies and build the project:
   ```bash
   dotnet restore
   dotnet build
   ```
4. Run the project:
   ```bash
   dotnet run
   ```

This will execute the `Program.cs` file, which demonstrates building two types of computers:
- A **Gaming Computer** with high-performance components.
- An **Office Computer** with more moderate specifications.

---

## Classes and Components

### `Computer`

This is the product that the builder will construct. It includes properties like CPU, RAM, GPU, Storage, and OS.

```csharp
namespace Models
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }
        public string OS { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}, OS: {OS}";
        }
    }
}
```

### `IComputerBuilder`

An interface that defines the methods needed to build different parts of a `Computer`.

```csharp
namespace Builders
{
    using Models;

    public interface IComputerBuilder
    {
        void SetCPU(string cpu);
        void SetRAM(string ram);
        void SetStorage(string storage);
        void SetGPU(string gpu);
        void SetOS(string os);
        Computer Build();
    }
}
```

### `ComputerBuilder`

A concrete implementation of the `IComputerBuilder` interface. It constructs the parts of the `Computer` object and assembles them.

```csharp
namespace Builders
{
    using Models;

    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public void SetCPU(string cpu) { _computer.CPU = cpu; }
        public void SetRAM(string ram) { _computer.RAM = ram; }
        public void SetStorage(string storage) { _computer.Storage = storage; }
        public void SetGPU(string gpu) { _computer.GPU = gpu; }
        public void SetOS(string os) { _computer.OS = os; }

        public Computer Build() { return _computer; }
    }
}
```

### `ComputerDirector`

The director class, which guides the builder to create a specific type of `Computer`. It uses the `IComputerBuilder` to set different configurations for gaming and office computers.

```csharp
namespace Directors
{
    using Builders;
    using Models;

    public class ComputerDirector
    {
        private readonly IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public Computer BuildGamingComputer()
        {
            _builder.SetCPU("Intel i9");
            _builder.SetRAM("32GB");
            _builder.SetStorage("1TB SSD");
            _builder.SetGPU("NVIDIA RTX 3080");
            _builder.SetOS("Windows 10");
            return _builder.Build();
        }

        public Computer BuildOfficeComputer()
        {
            _builder.SetCPU("Intel i5");
            _builder.SetRAM("16GB");
            _builder.SetStorage("512GB SSD");
            _builder.SetGPU("Integrated");
            _builder.SetOS("Windows 10");
            return _builder.Build();
        }
    }
}
```

---

## Running the Project

To run the project, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/builder-pattern-csharp.git
   ```

2. **Navigate to the project folder**:
   ```bash
   cd builder-pattern-csharp
   ```

3. **Build and run the project**:
   ```bash
   dotnet build
   dotnet run
   ```

4. **Output**:
   The output will display the details of the built gaming and office computers:

   ```
   Gaming Computer: CPU: Intel i9, RAM: 32GB, Storage: 1TB SSD, GPU: NVIDIA RTX 3080, OS: Windows 10
   Office Computer: CPU: Intel i5, RAM: 16GB, Storage: 512GB SSD, GPU: Integrated, OS: Windows 10
   ```

---

## Conclusion

This project demonstrates the **Builder Design Pattern** in C# through a practical example of constructing complex objects (computers) with multiple parts (CPU, RAM, GPU, etc.). The Builder pattern is a great way to manage the complexity of constructing an object, especially when the object has many parts that can be customized.

The pattern allows you to:
- Create complex objects step by step.
- Avoid telescoping constructors (many parameters in a constructor).
- Have better control over the construction process.

This implementation is simplified for educational purposes and can be expanded or modified to accommodate more complex scenarios.

--- 
