//    Vehicle
//       |      |      |
//       |      |      |
//      Car   Truck   SUV
//       |
//       |
//   HybridCar

public class HybridCar : Car
{
	private int batteryLife, MPG;
	private string chargerType;

	public HybridCar(string VIN, double wholesaleCost, double retailPrice, int modelYear, string make, string model, string color, int batteryLife, int MPG, string chargerType, VehicleClassification vehicleClass) : base(VIN, wholesaleCost, retailPrice, modelYear, make, model, color, vehicleClass)
	{
		this.batteryLife = batteryLife;
		this.MPG = MPG;
		this.chargerType = chargerType;
	}

	// Getters
	public virtual int BatteryLife
	{
		get
		{
			return this.batteryLife;
		}
		set
		{
			this.batteryLife = value;
		}
	}

	public virtual int Mpg
	{
		get
		{
			return this.MPG;
		}
		set
		{
			this.MPG = value;
		}
	}

	public virtual string ChargerType
	{
		get
		{
			return this.chargerType;
		}
		set
		{
			this.chargerType = value;
		}
	}



}