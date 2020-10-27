namespace CreationalPatterns.FactoryMethod
{
    public class HtmlDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
