namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("建造者模式!");
            //建造者模式（Builder Pattern）是一种创建型设计模式，用于创建复杂对象，将对象的构建过程与其表示分离，使得同样的构建过程可以创建不同的表示。

            //建造者模式适用于以下场景：
            //1.当创建一个复杂对象的过程非常复杂，并且需要多个步骤或组件参与时，可以使用建造者模式。通过将构建过程分解为多个步骤，可以更加灵活地构建对象，并且可以复用相同的构建逻辑来创建不同的表示。
            //2.当一个对象的构建过程需要根据不同的配置选项或参数进行灵活配置时，可以使用建造者模式。通过使用不同的建造者对象或配置参数，可以创建具有不同配置的对象，而无需修改客户端代码。

            //以下是一个使用建造者模式的示例，假设我们要构建一份汽车，其中包含品牌、颜色和引擎等组件。我们定义了一个汽车类 Car，其中包含了各个组件的属性。然后我们定义了一个抽象建造者类 CarBuilder，其中包含了构建汽车各个组件的抽象方法。然后我们有具体的建造者类 SportsCarBuilder 和 SUVBuilder，它们分别实现了抽象建造者类的方法来构建特定类型的汽车。最后，我们定义了一个指导者类 CarDirector，它负责指导建造者来构建汽车。
            CarBuilder sportsCarBuilder = new SportsCarBuilder();
            CarDirector sportsCarDirector = new CarDirector(sportsCarBuilder);
            sportsCarDirector.ConstructCar();
            Car sportsCar = sportsCarDirector.GetCar();
            sportsCar.Display();

            CarBuilder suvBuilder = new SUVBuilder();
            CarDirector suvDirector = new CarDirector(suvBuilder);
            suvDirector.ConstructCar();
            Car suvCar = suvDirector.GetCar();
            suvCar.Display();
            //在上述示例中，我们定义了一个产品类 `Car`，其中包含了汽车的各个组件属性。然后我们定义了一个抽象建造者类 `CarBuilder`，其中包含了创建汽车各个组件的抽象方法。然后我们有具体的建造者类 `SportsCarBuilder` 和 `SUVBuilder`，它们分别实现了抽象建造者类的方法来构建特定类型的汽车。
            //最后，在指导者类 `CarDirector` 中，我们使用具体的建造者对象来指导构建汽车的过程。客户端代码只需创建指导者对象，并通过指导者对象来构建汽车，无需直接与具体的建造者类交互。
            //通过建造者模式，我们可以灵活地构建不同配置的复杂对象，将对象的构建过程与其表示分离，提高了代码的可读性和可维护性。
        }
    }
}