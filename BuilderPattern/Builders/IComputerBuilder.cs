namespace Builders
{
    public interface IComputerBuilder
    {
        void SetCPU(string cpu);
        void SetRAM(string ram);
        void SetStorage(string storage);
        void SetGPU(string gpu);
        void SetOS(string os);
        Models.Computer Build();
    }
}