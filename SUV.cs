public class SUV : Vehicle
{
	// Simple SUV constructor inheriting all of the methods and properties of
	// Vehicle
	public SUV(string VIN, double wholesaleCost, double retailPrice, int modelYear, string make, string model, string color, VehicleClassification vehicleClass) : base(VIN, wholesaleCost, retailPrice, modelYear, make, model, color, vehicleClass)
	{
	}
}