namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("装饰器模式!");
            //装饰器模式（Decorator Pattern）是一种结构型设计模式，它允许在不修改现有对象结构的情况下，动态地将新功能附加到对象上。装饰器模式通过创建一个包装器类，包装原始对象，从而实现对对象的增强功能。
            //使用装饰器模式可以实现以下目标：
            //1.在不修改现有对象的代码的情况下，给对象添加新的功能或行为。
            //2.遵循开闭原则，即对扩展开放，对修改关闭。
            //装饰器模式在以下场景中特别有用：
            //1.动态添加功能：当我们需要在不修改现有代码的情况下，动态地给对象添加新的功能时，可以使用装饰器模式。装饰器模式允许我们通过包装原始对象来添加额外的功能，而不会对原始对象产生影响。
            //2.多层次的功能组合：当我们需要按照不同的方式组合对象的功能时，装饰器模式可以提供一种灵活的方式来实现多层次的功能组合。我们可以根据需求按顺序应用不同的装饰器，从而实现各种组合方式。
            //3.透明性：装饰器模式可以保持对象接口的一致性，使得使用装饰器包装后的对象对外部代码来说是透明的。外部代码可以像使用原始对象一样使用装饰器包装后的对象，而不需要关心具体的装饰器实现。



            //以下是一个示例场景，演示装饰器模式的应用：
            //假设我们有一个购物车系统，需要给购物车中的商品添加优惠券和礼品包装的功能。这些功能可以根据用户的需求进行动态添加，而不需要修改购物车系统的代码。
            // 创建基础购物车
            IShoppingCart shoppingCart = new ShoppingCart();
            // 应用装饰器
            shoppingCart = new CouponDecorator(shoppingCart, 10.0m);
            shoppingCart = new GiftWrapDecorator(shoppingCart);
            // 添加商品
            shoppingCart.AddItem("Product 1", 20.0m);
            shoppingCart.AddItem("Product 2", 30.0m);
            // 计算总价
            decimal totalPrice = shoppingCart.GetTotalPrice();
            Console.WriteLine($"Total Price: {totalPrice}");
            //在上述示例中，我们定义了一个 IShoppingCart 接口和其基本实现 ShoppingCart，用于表示购物车系统。然后，我们创建了两个装饰器 CouponDecorator 和 GiftWrapDecorator，分别用于应用优惠券和礼品包装的功能。
            //在客户端代码中，我们首先创建了基本的购物车对象 ShoppingCart，然后通过装饰器 CouponDecorator 和 GiftWrapDecorator 对其进行包装。最后，我们向购物车中添加商品，并计算总价。
            //通过使用装饰器模式，我们可以在不修改购物车系统代码的情况下，为购物车对象动态地添加优惠券和礼品包装的功能，实现了灵活的功能扩展。
            Console.ReadLine();

        }
    }
}