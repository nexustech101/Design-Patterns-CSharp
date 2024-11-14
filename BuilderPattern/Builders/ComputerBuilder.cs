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
