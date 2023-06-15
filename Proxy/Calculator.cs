namespace Proxy
{
    // 目标接口
    public interface ICalculator
    {
        int Calculate(int number);
    }

    // 目标对象
    public class Calculator : ICalculator
    {
        public int Calculate(int number)
        {
            Console.WriteLine("缓存中...");
            return number * number;
        }
    }

    // 代理对象
    public class CalculatorProxy : ICalculator
    {
        private Calculator calculator;
        private Dictionary<int, int> cache;

        public CalculatorProxy()
        {
            calculator = new Calculator();
            cache = new Dictionary<int, int>();
        }

        public int Calculate(int number)
        {
            if (cache.ContainsKey(number))
            {
                Console.WriteLine("结果来自缓存数据.");
                return cache[number];
            }
            else
            {
                int result = calculator.Calculate(number);
                cache[number] = result;
                Console.WriteLine("将结果添加到缓存.");
                return result;
            }
        }
    }
}
