namespace Prototype
{
    // Prototype
    public abstract class Product : ICloneable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract void Display();

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    // Concrete Prototype
    public class Laptop : Product
    {
        public Laptop()
        {
            Name = "Laptop";
            Price = 1000;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }
    }

    // Concrete Prototype
    public class Smartphone : Product
    {
        public Smartphone()
        {
            Name = "Smartphone";
            Price = 500;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }
    }
}
