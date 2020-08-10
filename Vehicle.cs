using System;

public class Vehicle
{
	// Class properties (notice they're private, so we'll need getters/setters)
	private string VIN, make, model, color;
	private double wholesaleCost, retailPrice;
	private int modelYear;
	private VehicleClassification vehicleClass;

	// Our constructor with all properties given
	public Vehicle(string VIN, double wholesaleCost, double retailPrice, int modelYear, string make, string model, string color, VehicleClassification vehicleClass)
	{
		this.VIN = VIN;
		this.wholesaleCost = wholesaleCost;
		this.retailPrice = retailPrice;
		this.modelYear = modelYear;
		this.make = make;
		this.model = model;
		this.color = color;
		this.vehicleClass = vehicleClass;
	}

	// Getters
	public virtual string Vin
	{
		get
		{
			return VIN;
		}
		set
		{
			this.VIN = value;
		}
	}

	public virtual double WholesaleCost
	{
		get
		{
			return wholesaleCost;
		}
		set
		{
			this.wholesaleCost = value;
		}
	}

	public virtual double RetailPrice
	{
		get
		{
			return retailPrice;
		}
		set
		{
			this.retailPrice = value;
		}
	}

	public virtual int ModelYear
	{
		get
		{
			return modelYear;
		}
		set
		{
			this.modelYear = value;
		}
	}

	public virtual string Make
	{
		get
		{
			return make;
		}
		set
		{
			this.make = value;
		}
	}

	public virtual string Model
	{
		get
		{
			return model;
		}
		set
		{
			this.model = value;
		}
	}

	public virtual string Color
	{
		get
		{
			return color;
		}
		set
		{
			this.color = value;
		}
	}

	public virtual VehicleClassification VehicleClass
	{
		get
		{
			return vehicleClass;
		}
		set
		{
			this.vehicleClass = value;
		}
	}









	public override string ToString()
	{
		return this.ModelYear + " " + this.Make + " " + this.Model;
		// 2018 Kia Sorrento
	}

	public virtual double TargetMargin
	{
		get
		{
			return this.retailPrice - this.wholesaleCost;
		}
	}

	public virtual void printVehicleType()
	{
		string type = "NOT SET";
		switch (this.vehicleClass)
		{
			case VehicleClassification.NEW:
				type = "New Car";
				break;
			case VehicleClassification.USED:
				type = "Used Car";
				break;
			case VehicleClassification.OFF_LEASE:
				type = "Leased Car";
				break;
			case VehicleClassification.SHUTTLE:
				type = "Dealer Shuttle";
				break;
			case VehicleClassification.LOANER:
				type = "Dealer Service Loaner";
				break;
			case VehicleClassification.PARTS_RUNNER:
				type = "Parts Runner";
				break;
			default:
				break;
		}
		Console.WriteLine("This car type is: " + type);
	}
}