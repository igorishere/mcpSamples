using System.ComponentModel;
using ModelContextProtocol.Server;

namespace HTTPSample.Tools;

[McpServerToolType]
public class CarTools
{
    [McpServerTool, Description("Get a list of all cars")]
    public IEnumerable<Car> GetAllCars()
    {
        return CarInformation.GetAll();
    }

    [McpServerTool, Description("Get cars engine")]
    public IEnumerable<Car> GetCarsEngine(
        [Description("Type of car engine. Allowed types: V6,V8, Inline4, Inline6 ")] eEngineType engineType
    )
    {
        return CarInformation.GetAll().Where(car => car.Engine == engineType);
    }

    [McpServerTool, Description("Get cars by brand")]
    public IEnumerable<Car> GetCarsByBrand(
        [Description("Brand of the car. Allowed brands: Toyota, Ford, Honda, Chevrolet, BMW, Audi, Mercedes-Benz, Volkswagen, Nissan, Hyundai")] string brand
    )
    {
        return CarInformation.GetAll().Where(car => car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase));
    }
}
