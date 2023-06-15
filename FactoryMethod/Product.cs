namespace FactoryMethod
{
    public abstract class Product
    {
        public abstract void Show();
    }

    public class Book : Product
    {
        public override void Show()
        {
            Console.WriteLine("我是书.");
        }
    }

    public class Toy : Product
    {
        public override void Show()
        {
            Console.WriteLine("我是玩具.");
        }
    }

    public abstract class ProductFactory
    {
        public abstract Product CreateProduct();
    }

    public class BookFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new Book();
        }
    }

    public class ToyFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new Toy();
        }
    }

    public class Client
    {
        private readonly ProductFactory productFactory;

        public Client(ProductFactory factory)
        {
            productFactory = factory;
        }

        public void ShowProduct()
        {
            Product product = productFactory.CreateProduct();
            product.Show();
        }
    }
}
