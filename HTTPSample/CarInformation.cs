namespace HTTPSample.Tools
{
    public class Car
    {
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Country { get; set; } = "";
        public eEngineType Engine { get; set; }
        public bool Turbo { get; set; }
        public string Traction { get; set; } = "";
    }

    public static class CarInformation
    {
        private static readonly List<Car> cars = new()
        {
            new Car { Name = "BMW M3", Brand = "BMW", Country = "Germany", Engine = eEngineType.Inline6, Turbo = true, Traction = "Rear wheel drive" },
            new Car { Name = "Chevrolet Camaro", Brand = "Chevrolet", Country = "USA", Engine = eEngineType.V8, Turbo = false, Traction = "Rear wheel drive" },
            new Car { Name = "Audi RS6", Brand = "Audi", Country = "Germany", Engine = eEngineType.V8, Turbo = true, Traction = "All wheel drive" },
            new Car { Name = "Honda Civic", Brand = "Honda", Country = "Japan", Engine = eEngineType.Inline4, Turbo = false, Traction = "Front wheel drive" },
            new Car { Name = "Subaru WRX", Brand = "Subaru", Country = "Japan", Engine = eEngineType.Boxer4, Turbo = true, Traction = "All wheel drive" },
            new Car { Name = "Volkswagen Golf GTI", Brand = "Volkswagen", Country = "Germany", Engine = eEngineType.Inline4, Turbo = true, Traction = "Front wheel drive" },
            new Car { Name = "Ford Mustang", Brand = "Ford", Country = "USA", Engine = eEngineType.V8, Turbo = false, Traction = "Rear wheel drive" },
            new Car { Name = "Toyota Supra", Brand = "Toyota", Country = "Japan", Engine = eEngineType.Inline6, Turbo = true, Traction = "Rear wheel drive" },
            new Car { Name = "Nissan GT-R", Brand = "Nissan", Country = "Japan", Engine = eEngineType.V6, Turbo = true, Traction = "All wheel drive" },
            new Car { Name = "Mercedes-AMG C63", Brand = "Mercedes-Benz", Country = "Germany", Engine = eEngineType.V8, Turbo = true, Traction = "Rear wheel drive" }
        };

        public static List<Car> GetAll() => cars;
    }
}
