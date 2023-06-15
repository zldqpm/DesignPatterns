namespace SimpleFactory
{
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画一个圆形.");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画一个正方形.");
        }
    }

    public class ShapeFactory
    {
        public IShape CreateShape(string type)
        {
            switch (type)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                default:
                    throw new ArgumentException("没有该类型.");
            }
        }
    }

    public class Client
    {
        private readonly ShapeFactory shapeFactory;

        public Client(ShapeFactory factory)
        {
            shapeFactory = factory;
        }

        public void DrawShape(string type)
        {
            IShape shape = shapeFactory.CreateShape(type);
            shape.Draw();
        }
    }
}
