namespace AbstractFactoryPattern.Products
{
    using System;

    public class MacOSCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a MacOS style checkbox.");
        }

        public void OnCheck()
        {
            Console.WriteLine("MacOS Checkbox checked!");
        }
    }
}
