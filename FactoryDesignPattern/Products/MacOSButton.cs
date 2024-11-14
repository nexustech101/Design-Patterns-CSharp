namespace AbstractFactoryPattern.Products
{
    using System;

    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a MacOS style button.");
        }

        public void OnClick()
        {
            Console.WriteLine("MacOS Button clicked!");
        }
    }
}
