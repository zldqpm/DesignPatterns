namespace Builder
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Engine: {Engine}");
        }
    }

    // Builder
    public abstract class CarBuilder
    {
        protected Car car;

        public void CreateCar()
        {
            car = new Car();
        }

        public abstract void SetBrand();
        public abstract void SetColor();
        public abstract void SetEngine();

        public Car GetCar()
        {
            return car;
        }
    }

    // Concrete Builder
    public class SportsCarBuilder : CarBuilder
    {
        public override void SetBrand()
        {
            car.Brand = "Ferrari";
        }

        public override void SetColor()
        {
            car.Color = "Red";
        }

        public override void SetEngine()
        {
            car.Engine = "V8";
        }
    }

    // Concrete Builder
    public class SUVBuilder : CarBuilder
    {
        public override void SetBrand()
        {
            car.Brand = "Tesla";
        }

        public override void SetColor()
        {
            car.Color = "Black";
        }

        public override void SetEngine()
        {
            car.Engine = "Electric";
        }
    }

    // Director
    public class CarDirector
    {
        private readonly CarBuilder carBuilder;

        public CarDirector(CarBuilder builder)
        {
            carBuilder = builder;
        }

        public void ConstructCar()
        {
            carBuilder.CreateCar();
            carBuilder.SetBrand();
            carBuilder.SetColor();
            carBuilder.SetEngine();
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }
    }

}
