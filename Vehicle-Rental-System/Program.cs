using Vehicle_Rental_System;

string vehicleBrand = Console.ReadLine()!;
string vehicleModel = Console.ReadLine()!;
decimal vehicleValue = decimal.Parse(Console.ReadLine()!);
string vehicleType = Console.ReadLine()!;
IVehicle vehicle;
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
        Console.WriteLine("Invalid vehicle type");
        return;
        //vehicle = new Invalide or write a line wVehicleType();      //Either just write an error message to the console and exit the app or make a class which implements IVehicle to display an error when calling CalculateRentalPrice?
}

int rentalPeriod = int.Parse(Console.ReadLine()!);
Console.WriteLine(vehicle.CalculateRentalPrice(rentalPeriod));
