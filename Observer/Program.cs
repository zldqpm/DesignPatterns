namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("观察者模式!");
            //观察者模式（Observer Pattern）是一种行为设计模式，用于在对象之间定义一种一对多的依赖关系，当一个对象的状态发生变化时，它的所有依赖对象都会自动收到通知并进行相应的更新。

            //观察者模式由以下几个角色组成：
            //-Subject（主题）：它是被观察的对象，它维护一组观察者对象，并提供方法用于添加、删除和通知观察者。
            //-Observer（观察者）：它定义了一个更新的接口，当主题的状态发生变化时，它会接收到通知并进行相应的处理。
            //-ConcreteSubject（具体主题）：它是具体的被观察对象，它包含了需要观察的状态，并在状态发生变化时通知观察者。
            //-ConcreteObserver（具体观察者）：它是具体的观察者对象，实现了更新的接口，并定义了自己的更新逻辑。

            //观察者模式的使用场景包括：
            //1.当一个对象的改变需要同时改变其他对象，且不希望知道具体有多少对象需要改变时，可以使用观察者模式。
            //2.当一个对象必须通知其他对象，但又不希望与被通知对象形成紧耦合关系时，可以使用观察者模式。
            //3.当系统中的某些对象之间存在一对多的关系，一个对象的状态改变会影响其他对象时，可以使用观察者模式。


            //观察者模式适用于以下场景：
            //1.当一个对象的状态变化需要通知其他对象，并且对象之间的关系是一对多的关系时，可以使用观察者模式。这样，在对象状态变化时，所有的观察者都会收到相应的通知。
            //2.当一个对象的改变需要同时改变其他对象，但又不希望对象之间紧密耦合时，可以使用观察者模式。通过将观察者与被观察者解耦，可以提高代码的可维护性和灵活性。
            //3.当系统需要动态地将一个对象的变化通知给其他对象，且不知道具体有多少对象需要接收通知时，可以使用观察者模式。这样可以方便地添加或移除观察者，而无需修改被观察者的代码。
            //举例应用场景可以是一个消息通知系统。假设有一个在线购物平台，当用户下单成功后，需要通知用户、仓库管理系统和财务系统。这种情况下，可以使用观察者模式来实现通知的功能。
            OrderSubject orderSubject = new OrderSubject();
            UserObserver userObserver = new UserObserver();
            WarehouseObserver warehouseObserver = new WarehouseObserver();
            FinanceObserver financeObserver = new FinanceObserver();

            // 注册观察者
            orderSubject.RegisterObserver(userObserver);
            orderSubject.RegisterObserver(warehouseObserver);
            orderSubject.RegisterObserver(financeObserver);

            // 下单
            orderSubject.PlaceOrder();
            Console.ReadLine();
            //在上述示例中，`OrderSubject` 是具体主题类，实现了 `ISubject` 接口，并负责维护观察者列表和通知观察者的逻辑。`UserObserver`、`WarehouseObserver` 和 `FinanceObserver` 都是具体观察者类，实现了 `IObserver` 接口，并定义了自己的更新逻辑。在主程序中，我们创建了一个订单主题对象，并注册了三个观察者对象，当订单下单成功后，所有观察者都会收到相应的通知并执行自己的更新逻辑。
            //这样，通过观察者模式，订单下单成功后，用户、仓库和财务部都能及时收到相应的通知，实现了对象之间的解耦和灵活性。
        }
    }
}