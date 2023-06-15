namespace Strategy
{
    // 支付策略接口
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    // 支付宝支付策略
    public class AliPayStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"使用支付宝支付：{amount}元");
        }
    }

    // 微信支付策略
    public class WeChatPayStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"使用微信支付：{amount}元");
        }
    }

    // 银行卡支付策略
    public class CardPayStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"使用银行卡支付：{amount}元");
        }
    }

    // 上下文类
    public class PaymentContext
    {
        private IPaymentStrategy strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Pay(decimal amount)
        {
            strategy.Pay(amount);
        }
    }
}
