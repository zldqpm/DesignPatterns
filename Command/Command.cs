namespace Command
{
    // 命令接口
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // 具体命令实现类 - 创建订单命令
    public class CreateOrderCommand : ICommand
    {
        private readonly OrderService _orderService;
        private readonly Order _order;

        public CreateOrderCommand(OrderService orderService, Order order)
        {
            _orderService = orderService;
            _order = order;
        }

        public void Execute()
        {
            _orderService.CreateOrder(_order);
        }

        public void Undo()
        {
            _orderService.CancelOrder(_order);
        }
    }

    // 具体命令实现类 - 取消订单命令
    public class CancelOrderCommand : ICommand
    {
        private readonly OrderService _orderService;
        private readonly Order _order;

        public CancelOrderCommand(OrderService orderService, Order order)
        {
            _orderService = orderService;
            _order = order;
        }

        public void Execute()
        {
            _orderService.CancelOrder(_order);
        }

        public void Undo()
        {
            _orderService.CreateOrder(_order);
        }
    }

    // 订单类
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        // 其他订单属性...
    }

    // 订单服务类 - 接收者
    public class OrderService
    {
        public void CreateOrder(Order order)
        {
            Console.WriteLine($"Creating order: {order.OrderId}, Customer: {order.CustomerName}, Amount: {order.TotalAmount}");
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine($"Canceling order: {order.OrderId}, Customer: {order.CustomerName}, Amount: {order.TotalAmount}");
        }
    }

    // 调用者类
    public class OrderInvoker
    {
        private readonly ICommand _command;

        public OrderInvoker(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

        public void UndoCommand()
        {
            _command.Undo();
        }
    }
}
