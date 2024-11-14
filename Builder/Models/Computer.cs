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
            return $"Computer [CPU={CPU}, RAM={RAM}, Storage={Storage}, GPU={GPU}, OS={OS}]";
        }
    }
}