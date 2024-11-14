using Builders;
using Models;

namespace Directors
{
    public class ComputerDirector
    {
        private readonly IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder build)
        {
            _builder = build;
        }

        public Computer BuildGamingComputer()
        {
            _builder.SetCPU("Intel i9");
            _builder.SetRAM("32GB");
            _builder.SetStorage("1TB SSD");
            _builder.SetGPU("NVIDIA RTX 5040");
            _builder.SetOS("Windows 11 Pro");
            return _builder.Build();
        }

        public Computer BuildOfficeComputer()
        {
            _builder.SetCPU("Intel i5");
            _builder.SetRAM("8GB");
            _builder.SetStorage("512GB SSD");
            _builder.SetGPU("Integrated");
            _builder.SetOS("Windows 11");
            return _builder.Build();
        }
    }
}