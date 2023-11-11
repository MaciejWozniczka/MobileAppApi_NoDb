namespace MobileApp.Host.VehicleTypes;

public class VehicleType : BaseModel
{
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Picture { get; set; }
}