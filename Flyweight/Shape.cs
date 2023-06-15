namespace Flyweight
{
    // 享元接口
    public interface IShape
    {
        void Draw(int x, int y);
    }

    // 具体享元类：圆形
    public class Circle : IShape
    {
        private string color;

        public Circle(string color)
        {
            this.color = color;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a {color} circle at position ({x}, {y})");
        }
    }

    // 图形工厂
    public class ShapeFactory
    {
        private Dictionary<string, IShape> shapeCache = new Dictionary<string, IShape>();

        public IShape GetCircle(string color)
        {
            if (!shapeCache.ContainsKey(color))
            {
                shapeCache[color] = new Circle(color);
            }

            return shapeCache[color];
        }
    }
}
