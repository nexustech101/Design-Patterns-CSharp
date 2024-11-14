namespace AbstractFactoryPattern.Factories
{
    using AbstractFactoryPattern.Products;

    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
