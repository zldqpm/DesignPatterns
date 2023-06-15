namespace Mediator
{
    // 抽象中介者
    public interface IMediator
    {
        void Notify(Order order, string message);
    }

    // 具体中介者
    public class OrderMediator : IMediator
    {
        public void Notify(Order order, string message)
        {
            Console.WriteLine($"Order ID: {order.OrderId}, Message: {message}");
        }
    }

    // 抽象同事类
    public abstract class Order
    {
        protected IMediator _mediator;
        public int OrderId { get; set; }
        public abstract void Process();
    }

    // 具体同事类
    public class OnlineOrder : Order
    {
        public OnlineOrder(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override void Process()
        {
            Console.WriteLine($"Processing online order {OrderId}");
            _mediator.Notify(this, "Online order processed successfully");
        }
    }

    // 具体同事类
    public class PhoneOrder : Order
    {
        public PhoneOrder(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override void Process()
        {
            Console.WriteLine($"Processing phone order {OrderId}");
            _mediator.Notify(this, "Phone order processed successfully");
        }
    }
}
