using static MobileApp.Host.Vehicles.GetVehicles;

namespace MobileApp.Host.Categories;

public class Category : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public List<VehicleType> VehicleTypes { get; set; }
    public List<VehiclesDto> Vehicles { get; set; }
}