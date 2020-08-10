public class LeaseVehicleFactory
{
	public static Leaseable getLeaseableVehicleByVin(string VIN)
	{
		Leaseable leaseable = null;

		// these methods called haven't been created, using as an example
		string vehicleType = decodeVinForType(VIN);
		if (vehicleType.Equals("Car"))
		{
			leaseable = getCarDetails(VIN);
		}
		else if (vehicleType.Equals("LightTruck"))
		{
			leaseable = getTruckDetails(VIN);
		}

		return leaseable;
	}
}