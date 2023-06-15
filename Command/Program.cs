using System;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命令模式!");
            //命令模式是一种行为设计模式，它将请求或操作封装成一个对象，从而允许根据不同的请求参数来参数化客户端对象，并将其与具体的接收者解耦。
            //这样可以实现请求的发送者和接收者之间的解耦，同时支持请求的排队、撤销和重做等操作
            //命令模式在以下场景中特别有用：
            //1.撤销/重做操作：命令模式可以将每个操作封装为一个命令对象，从而支持撤销和重做操作。通过保留命令历史记录，可以按顺序执行撤销操作或者重做操作。
            //2.队列请求处理：命令模式可以用于构建请求队列，将每个请求封装为一个命令对象并依次加入队列。然后，逐个执行队列中的命令，从而实现请求的排队和异步处理。
            //3.回调机制：命令模式可以将命令对象传递给其他对象，作为回调的一种方式。接收者可以根据需要执行命令，并在完成后调用回调函数通知发送者。
            //4.调用日志和跟踪：通过命令模式，可以记录每个命令的执行日志，包括命令的参数、执行时间等信息。这样可以实现系统的调用日志和跟踪功能。
            //一个常见的应用场景是图形用户界面（GUI）的交互操作，例如一个文本编辑器。用户在编辑器中进行的每个操作（如打开文件、保存文件、撤销操作、复制粘贴等）都可以被封装成一个具体的命令对象。通过命令模式，可以灵活地管理和执行这些命令，并支持撤销、重做等功能。
            //另一个例子是电商系统中的订单处理。每个订单操作（如创建订单、取消订单、确认订单等）可以被封装成一个命令对象。通过命令模式，可以实现订单的灵活处理和管理，支持撤销订单、查看订单历史等功能。
            //总结来说，命令模式适用于需要将请求发送者和接收者解耦、支持撤销 / 重做操作、队列请求处理以及回调等场景。它提供了更灵活的命令处理方式，并可以方便地扩展和维护代码。

            //使用命令模式处理电商系统中的订单操作
            // 创建订单服务和相关命令
            var orderService = new OrderService();
            var order = new Order { OrderId = 1, CustomerName = "John", TotalAmount = 100.0m };
            var createOrderCommand = new CreateOrderCommand(orderService, order);
            var cancelOrderCommand = new CancelOrderCommand(orderService, order);

            // 创建订单
            var createOrderInvoker = new OrderInvoker(createOrderCommand);
            createOrderInvoker.ExecuteCommand();

            // 取消订单
            var cancelOrderInvoker = new OrderInvoker(cancelOrderCommand);
            cancelOrderInvoker.ExecuteCommand();
            //在示例中，我们定义了 ICommand 接口作为命令的抽象，其中包含了 Execute() 和 Undo() 方法。CreateOrderCommand 和 CancelOrderCommand 分别是创建订单和取消订单的具体命令实现类，它们接收一个订单对象和一个订单服务对象作为参数。OrderService 是订单服务类，负责实际的订单操作。OrderInvoker 是调用者类，用于执行和撤销命令。
            //在应用程序的入口 Main 方法中，我们创建了一个订单对象和相关的命令对象，然后创建了调用者 OrderInvoker 并执行了创建订单命令。接着，我们撤销了命令，实际上执行了取消订单的操作。
            //通过命令模式，我们可以灵活地处理订单操作，将订单操作封装成命令对象，并实现撤销操作。这样可以简化订单处理的代码结构，并提供更灵活的操作方式。
            Console.ReadLine();
        }
    }
}