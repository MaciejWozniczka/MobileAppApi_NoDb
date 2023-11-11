﻿using static MobileApp.Host.Vehicles.GetVehicles;

namespace MobileApp.Host.Users;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Country Country { get; set; }
    public string City { get; set; }
    public string Nationality { get; set; }
    public SexType Sex { get; set; }
    public List<string> Languages { get; set; }
    public string Picture { get; set; }
    public string Desciption { get; set; }
    public int PhoneNumber { get; set; }
    public string PhoneCountryCode { get; set; }
    public UserType UserType { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletingDate { get; set; }
    public List<VehiclesDto> VehiclesCreated { get; set; }
    public List<VehiclesDto> VehiclesAssigned { get; set; }
}