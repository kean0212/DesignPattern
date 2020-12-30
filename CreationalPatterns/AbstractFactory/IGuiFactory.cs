namespace CreationalPatterns.AbstractFactory
{
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
        void Paint()
        {
            CreateButton();
            CreateCheckbox();
        }
    }
}