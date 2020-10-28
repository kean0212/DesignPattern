using System;

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