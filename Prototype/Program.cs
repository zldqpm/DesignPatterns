namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原型模式!");
            //原型模式（Prototype Pattern）是一种创建型设计模式，用于创建对象的克隆副本，而无需依赖于具体类的构造函数。原型模式通过复制现有对象的属性来创建新对象，从而避免了直接使用构造函数创建对象的开销。

            //原型模式适用于以下场景：
            //1.当创建对象的过程比较复杂或耗时时，可以使用原型模式。通过克隆现有对象，可以避免重复进行复杂的对象创建过程，提高了性能和效率。
            //2.当需要创建一组相似对象，其中的区别仅在于其属性的值时，可以使用原型模式。通过克隆原型对象并适当修改其属性值，可以快速创建相似但不完全相同的对象。

            //以下是一个使用原型模式的示例，假设我们有一个简单的电子商务平台，其中有多个产品，每个产品都有名称和价格属性。我们希望能够通过克隆现有产品来创建新的产品，而无需每次都手动设置名称和价格。
            Product laptop = new Laptop();
            Product clonedLaptop = laptop.Clone() as Product;
            laptop.Display();
            clonedLaptop.Display();

            Product smartphone = new Smartphone();
            Product clonedSmartphone = smartphone.Clone() as Product;
            smartphone.Display();
            clonedSmartphone.Display();
            //在上述示例中，我们定义了一个抽象原型类 `Product`，其中包含了产品的名称和价格属性，以及一个显示方法。然后我们有具体的原型类 `Laptop` 和 `Smartphone`，它们分别实现了抽象原型类的方法和构造函数来设置默认的名称和价格。
            //在客户端代码中，我们创建了原型对象 `laptop` 和 `smartphone`，然后通过克隆方法 `Clone()` 创建了它们的副本对象 `clonedLaptop` 和 `clonedSmartphone`。这样，我们可以通过原型对象的克隆来创建新的产品对象，而无需每次手动设置名称和价格。
            //通过原型模式，我们可以通过复制现有对象来创建新对象，避免了重复的对象创建过程，提高了性能和效率。在这个示例中，我们可以使用原型模式快速创建多个产品对象，而无需每次都手动设置它们的属性。
        }
    }
}