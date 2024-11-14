namespace AbstractFactoryPattern.Factories
{
    using AbstractFactoryPattern.Products;

    public class MacOSFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }
}
