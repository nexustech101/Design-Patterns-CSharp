namespace AbstractFactoryPattern.Products
{
    using System;

    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows style button.");
        }

        public void OnClick()
        {
            Console.WriteLine("Windows Button clicked!");
        }
    }
}
