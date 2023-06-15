namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("责任链模式!");
            //责任链模式是一种行为型设计模式，它允许你将请求沿着处理链进行传递，直到有一个处理者能够处理该请求为止。这样可以避免请求发送者和接收者之间的直接耦合，并允许多个对象都有机会处理请求。

            //责任链模式使用场景：
            //1.处理请求的对象存在多个，并且需要按照一定的顺序进行处理。
            //2.请求的处理者可能会动态变化，需要灵活地增加、删除或者重新排序处理者。
            //3.请求的发送者不需要知道具体的处理者，只需要将请求发送给第一个处理者，然后让处理者自行决定是否处理或者转发请求。

            //责任链模式适用于以下场景：
            //1.处理对象存在多个，且需要按照一定顺序进行处理。每个处理对象可以处理请求，或者将请求传递给下一个处理对象。
            //2.需要动态地指定处理对象的顺序或者增加新的处理对象，而不影响客户端的代码。
            //3.发送者和接收者之间的关系需要解耦，发送者不需要知道哪个具体的对象将处理请求。

            //举例应用场景：
            //1.HTTP 请求处理：在 Web 开发中，可以使用责任链模式处理 HTTP 请求。每个处理对象代表一个中间件，负责处理特定的请求或者将请求传递给下一个中间件，最终到达处理器。
            //2.审批流程：在企业应用中，常常存在审批流程，例如请假审批、报销审批等。不同级别的主管、经理、领导都可以作为责任链的处理对象，依次处理审批请求。
            //3.日志记录：在日志记录中，可以使用责任链模式将日志消息传递给不同的处理者，例如输出到控制台、写入文件、发送到远程服务器等。
            //总的来说，责任链模式适用于需要动态地组织处理对象，并根据具体情况决定由哪个对象来处理请求的场景。它能够提高代码的可扩展性和灵活性，并且降低了发送者和接收者之间的耦合度。

            //下面是一个示例，演示如何使用责任链模式来处理请假申请
            LeaveHandler supervisor = new Supervisor();
            LeaveHandler manager = new Manager();
            LeaveHandler hr = new HR();

            supervisor.SetNextHandler(manager);
            manager.SetNextHandler(hr);

            LeaveRequest request1 = new LeaveRequest(1);
            LeaveRequest request2 = new LeaveRequest(4);
            LeaveRequest request3 = new LeaveRequest(10);
            supervisor.HandleRequest(request1);
            supervisor.HandleRequest(request2);
            supervisor.HandleRequest(request3);
            //在上述示例中，我们定义了一个抽象处理者 LeaveHandler，其中包含一个指向下一个处理者的引用。具体处理者 Supervisor、Manager 和 HR 分别实现了抽象处理者，并在 HandleRequest 方法中处理或者转发请求。
            //在客户端代码中，我们创建了一个责任链，并设置了处理者的顺序。然后，我们创建了不同天数的请假申请，并通过责任链将请求发送给第一个处理者。每个处理者根据自己的能力判断是否能够处理该请求，如果能够处理，则进行处理并结束请求链；如果不能处理，则将请求传递给下一个处理者。
            //通过这种方式，可以实现一个灵活的请求处理链，根据具体情况将请求发送给合适的处理者。这样可以避免请求发送者和接收者之间的直接耦合，并能够动态调整和扩展处理者的顺序和数量。


            // 创建审批处理器
            var managerHandler = new ManagerApprovalHandler();
            var directorHandler = new DirectorApprovalHandler();
            var ceoHandler = new CEOApprovalHandler();

            // 设置处理器的顺序
            managerHandler.SetNextHandler(directorHandler);
            directorHandler.SetNextHandler(ceoHandler);

            // 创建审批请求
            var request4 = new ApprovalRequest { Requester = "John", Amount = 800 };
            var request5 = new ApprovalRequest { Requester = "Alice", Amount = 3000 };
            var request6 = new ApprovalRequest { Requester = "Bob", Amount = 15000 };

            // 处理审批请求
            managerHandler.HandleRequest(request4);
            managerHandler.HandleRequest(request5);
            managerHandler.HandleRequest(request6);
            Console.ReadLine();
        }
    }
}