namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式（Simple Factory Pattern）是一种创建型设计模式，用于根据不同的输入条件创建不同类型的对象。在简单工厂模式中，有一个工厂类负责创建对象，而客户端只需要通过工厂类来获取所需的对象，而无需直接实例化对象。
            //简单工厂模式适用于需要根据不同的条件创建不同类型对象的场景。它提供了一种集中化的对象创建机制，将对象的创建逻辑封装在工厂类中，使客户端代码与具体产品类解耦，提高了代码的灵活性和可维护性。

            //简单工厂模式适用于以下场景：
            //1.创建对象的逻辑相对简单，不涉及复杂的业务规则。
            //2.客户端不需要知道具体的产品类，只需要通过工厂获取产品对象。
            //3.在程序中需要根据某个条件动态地创建不同类型的对象。
            //以下是一个使用简单工厂模式的示例，假设我们有一个图形类，包括圆形和正方形，我们可以通过简单工厂模式来创建不同类型的图形对象
            Console.WriteLine("简单工厂模式!");
            ShapeFactory factory = new ShapeFactory();
            Client client = new Client(factory);
            client.DrawShape("Circle");
            client.DrawShape("Square");
            Console.ReadLine();
            //在上述示例中，我们定义了一个 IShape 接口来表示图形的共同行为。然后我们有两个具体的图形类 Circle 和 Square，它们实现了 IShape 接口并提供了各自的绘制逻辑。
            //接下来我们有一个 ShapeFactory 类，它是简单工厂的核心。在 ShapeFactory 中，我们有一个 CreateShape 方法，根据传入的类型参数来创建相应的图形对象。在示例中，我们通过传入参数 "Circle" 和 "Square" 来创建具体的图形对象。
            //最后，在客户端代码中，我们创建了一个 ShapeFactory 对象，并通过 Client 类调用 DrawShape 方法来绘制不同类型的图形。通过这种方式，我们使用简单工厂模式将创建对象的逻辑封装在工厂类中，客户端代码只需要关注绘制图形而不需要知道具体的图形类。
            //这样，我们可以根据需要创建不同类型的图形对象，而不需要直接实例化具体的图形类。简单工厂模式将对象的创建和使用进行了解耦，提高了代码的灵活性和可维护性。
        }
    }
}