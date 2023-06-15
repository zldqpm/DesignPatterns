namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //抽象工厂模式（Abstract Factory Pattern）是一种创建型设计模式，用于创建一系列相关或相互依赖的对象，而无需指定其具体类。抽象工厂模式提供了一个接口，用于创建一组相关对象的系列，这样可以将对象的创建与使用解耦，并确保一组对象之间的兼容性。
            //抽象工厂模式适用于以下场景：
            //1.当系统需要一系列相互依赖的对象时，可以使用抽象工厂模式。抽象工厂模式可以确保一组对象之间的兼容性，因为它们是由同一个工厂创建的。
            //2.当系统需要提供一个产品的系列，而不关心具体实现时，可以使用抽象工厂模式。抽象工厂模式将产品的实现细节隐藏在具体工厂的背后，使得客户端只需关注产品的接口而不需要知道具体的实现类。
            Console.WriteLine("抽象工厂模式");

            //下面是一个使用抽象工厂模式的示例，假设我们有一个跨平台的用户界面（UI）库，需要提供按钮和文本框等控件，
            //同时支持不同操作系统（如Windows和Mac）的风格。我们定义了抽象的控件工厂 UIFactory，
            //其中包含创建按钮和文本框的抽象方法。然后我们有具体的工厂类 WindowsUIFactory 和 MacUIFactory，
            //它们分别实现了控件工厂的抽象方法来创建特定操作系统风格的控件
            IUIFactory windowsFactory = new WindowsUIFactory();
            Client windowsClient = new Client(windowsFactory);
            windowsClient.RenderUI();
            IUIFactory macFactory = new MacUIFactory();
            Client macClient = new Client(macFactory);
            macClient.RenderUI();
            //在上述示例中，我们定义了两个抽象产品接口 IButton 和 ITextBox，分别用于表示按钮和文本框控件。然后我们有具体的产品类 WindowsButton、MacButton、WindowsTextBox 和 MacTextBox，它们分别实现了抽象产品接口。
            //接下来，我们定义了一个抽象工厂接口 IUIFactory，其中包含创建按钮和文本框的抽象方法。然后我们有具体的工厂类 WindowsUIFactory 和 MacUIFactory，它们分别实现了抽象工厂接口，用于创建特定操作系统风格的按钮和文本框控件。
            //最后，在客户端代码中，我们创建了具体的工厂对象（WindowsUIFactory 和 MacUIFactory），并通过 Client 类调用 RenderUI 方法来渲染用户界面。客户端代码不需要直接实例化具体的控件类，而是通过抽象工厂的方法来创建控件对象，以实现跨平台的兼容性。
            //通过抽象工厂模式，我们可以方便地创建一组相关的对象系列，并确保它们的兼容性。这样可以使客户端代码与具体的产品类解耦，提高代码的灵活性和可维护性。
        }
    }
}