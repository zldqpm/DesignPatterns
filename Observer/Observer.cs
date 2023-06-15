namespace Observer
{
    // 主题接口
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string message);
    }

    // 观察者接口
    public interface IObserver
    {
        void Update(string message);
    }

    // 具体主题
    public class OrderSubject : ISubject
    {
        private List<IObserver> observers;

        public OrderSubject()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public void PlaceOrder()
        {
            // 下单逻辑
            Console.WriteLine("下单成功！");
            NotifyObservers("您的订单已经成功下单，请及时支付。");
        }
    }

    // 具体观察者
    public class UserObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("用户收到通知：" + message);
        }
    }

    public class WarehouseObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("仓库收到通知：" + message);
        }
    }

    public class FinanceObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("财务部收到通知：" + message);
        }
    }

}
