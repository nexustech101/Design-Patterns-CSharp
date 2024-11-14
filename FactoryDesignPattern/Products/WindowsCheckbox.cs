namespace AbstractFactoryPattern.Products
{
    using System;

    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows style checkbox.");
        }

        public void OnCheck()
        {
            Console.WriteLine("Windows Checkbox checked!");
        }
    }
}
