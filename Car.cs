// Convention dictates that "implements" comes after "extends" if its present
public class Car : Vehicle, Leaseable, Discountable
{
	// Simple Car constructor inheriting all of the methods and properties of
	// Vehicle
	public Car(string VIN, double wholesaleCost, double retailPrice, int modelYear, string make, string model, string color, VehicleClassification vehicleClass) : base(VIN, wholesaleCost, retailPrice, modelYear, make, model, color, vehicleClass)
	{
	}

	public override double TargetMargin
	{
		get
		{
			return base.TargetMargin - 1000;
			// Use the getTargetMargin method as its defined in our superclass (Vehicle)
		}
	}

	// Implementing methods from ILeaseable
	public virtual bool Leaseable
	{
		get
		{
			return true;
		}
	}

	public virtual int LeaseTerm
	{
		get
		{
			return 24;
		}
	}

	public virtual int MaxMilesPerYear
	{
		get
		{
			return 15_000;
		}
	}

	// Implementing methods from IDiscountable
	public virtual float MaximumDiscountPct
	{
		get
		{
			return 18.5f;
		}
	}

	public virtual float PersonDiscount
	{
		get
		{
			return 12.5f;
		}
	}

	public virtual float CorporateDiscount
	{
		get
		{
			return 20.0f;
		}
	}

}