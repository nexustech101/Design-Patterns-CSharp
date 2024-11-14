namespace AbstractFactoryPattern.Factories
{
    using AbstractFactoryPattern.Products;

    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
