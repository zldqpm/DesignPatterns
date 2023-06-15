namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //工厂方法模式（Factory Method Pattern）是一种创建型设计模式，用于定义创建对象的接口，但将实际的对象创建延迟到子类中。这样，子类可以决定具体要创建哪个对象。工厂方法模式通过将对象的创建委托给子类来实现解耦，使得客户端代码与具体对象的创建逻辑分离。
            Console.WriteLine("工厂方法模式!");
            //工厂方法模式适用于以下场景：
            //1.当一个类无法预知需要创建哪种具体对象时，可以使用工厂方法模式。这种情况下，将对象的创建推迟到子类中更具灵活性。
            //2.当一个类希望将对象的创建委托给子类来进行扩展时，可以使用工厂方法模式。这样，通过添加新的子类，可以方便地添加新的产品变体，而无需修改现有的代码。

            //以下是一个使用工厂方法模式的示例，假设我们有一个商品类 Product，并且有两个具体的商品类 Book 和 Toy。
            //我们创建一个抽象的商品工厂类 ProductFactory，其中包含一个抽象的工厂方法 CreateProduct，让子类来实现具体的对象创建。
            //通过工厂方法模式，我们将对象的创建委托给子类，使得可以方便地添加新的商品类和工厂类，而无需修改现有的代码。这提供了更大的灵活性和可扩展性。
            ProductFactory factory = new BookFactory();
            Client client = new Client(factory);
            client.ShowProduct();

            factory = new ToyFactory();
            client = new Client(factory);
            client.ShowProduct();
            Console.ReadLine();
            //在上述示例中，我们定义了一个抽象的 Product 类，它包含一个抽象的 Show 方法，用于展示商品的信息。然后我们有两个具体的商品类 Book 和 Toy，它们继承自 Product 并实现了 Show 方法。
            //接下来，我们定义了一个抽象的 ProductFactory 类，其中包含一个抽象的工厂方法 CreateProduct，用于创建具体的商品对象。然后我们有两个具体的工厂类 BookFactory 和 ToyFactory，它们继承自 ProductFactory 并实现了 CreateProduct 方法来创建相应的商品对象。
            //最后，在客户端代码中，我们创建了一个具体的工厂对象，并通过 Client 类调用 ShowProduct 方法来展示商品信息。客户端代码不需要直接实例化具体的商品类，而是通过工厂方法来创建商品对象。
            //通过工厂方法模式，我们将对象的创建委托给子类，使得可以方便地添加新的商品类和工厂类，而无需修改现有的代码。这提供了更大的灵活性和可扩展性
        }
    }
}