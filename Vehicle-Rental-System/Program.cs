string vehicleBrand = Console.ReadLine()!;
string vehicleModel = Console.ReadLine()!;
decimal vehicleValue = decimal.Parse(Console.ReadLine()!);
string vehicleType = Console.ReadLine()!;
Vehicle vehicle;
switch (vehicleType)
{
    case "car":
        int safetyRating = int.Parse(Console.ReadLine()!);
        vehicle = new Car(vehicleBrand, vehicleModel, vehicleValue, safetyRating);
        break;
    case "motorcycle":
        int riderAge = int.Parse(Console.ReadLine()!);
        vehicle = new Motorcycle(vehicleBrand, vehicleModel, vehicleValue, riderAge);
        break;
    case "cargo van":
        int driverExperience = int.Parse(Console.ReadLine()!);
        vehicle = new CargoVan(vehicleBrand, vehicleModel, vehicleValue, driverExperience);
        break;
    default:
        break;
}

int rentalPeriod = int.Parse(Console.ReadLine()!);
Console.WriteLine(vehicle.CalculateRentalPrice(rentalPeriod));
