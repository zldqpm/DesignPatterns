namespace AbstractFactory
{
    public interface IButton
    {
        void Render();
    }

    public interface ITextBox
    {
        void Render();
    }

    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows button.");
        }
    }

    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac button.");
        }
    }

    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows text box.");
        }
    }

    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac text box.");
        }
    }

    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }

    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }

    public class Client
    {
        private readonly IUIFactory uiFactory;

        public Client(IUIFactory factory)
        {
            uiFactory = factory;
        }

        public void RenderUI()
        {
            IButton button = uiFactory.CreateButton();
            ITextBox textBox = uiFactory.CreateTextBox();

            button.Render();
            textBox.Render();
        }
    }

}
