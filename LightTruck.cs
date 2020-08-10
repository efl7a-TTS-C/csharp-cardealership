public class LightTruck : Vehicle
{
	private long towingCapacity, grossCombinedWeight, truckWeight;
	private bool is4wd;

	// Constructor with both inherited properties and new properites
	public LightTruck(string VIN, double wholesaleCost, double retailPrice, int modelYear, string make, string model, string color, long towingCapacity, long truckWeight, bool is4wd, VehicleClassification vehicleClass) : base(VIN, wholesaleCost, retailPrice, modelYear, make, model, color, vehicleClass)
	{
		this.towingCapacity = towingCapacity;
		this.truckWeight = truckWeight;
		this.is4wd = is4wd;
		this.grossCombinedWeight = this.towingCapacity + this.truckWeight;

		if (this.is4wd == true)
		{
			// Create new TransferCase object if LightTruck is 4WD
			// and store object in variable xferCase
			this.xferCase = new TransferCase(this);
		}
	}

	// Getters
	public virtual long TowingCapacity
	{
		get
		{
			return this.towingCapacity;
		}
		set
		{
			this.towingCapacity = value;
		}
	}

	public virtual long TruckWeight
	{
		get
		{
			return this.truckWeight;
		}
		set
		{
			this.truckWeight = value;
		}
	}

	public virtual long GrossCombinedWeight
	{
		get
		{
			return this.grossCombinedWeight;
		}
		set
		{
			this.grossCombinedWeight = value;
		}
	}

	public virtual bool Is4wd
	{
		get
		{
			return this.is4wd;
		}
		set
		{
			this.is4wd = value;
		}
	}



	// Method to automatically calculate GCW if no params given
	public virtual void setGrossCombinedWeight()
	{
		this.grossCombinedWeight = this.truckWeight + this.towingCapacity;
	}



	public override string ToString()
	{
		// Get the string output from our "default" superclass method
		// Example: 2018 Kia Sorrento
		// and store that in a variable for us to use
		string str = base.ToString();
		// If 4WD, signify that in return string
		if (is4wd)
		{
			str += ", (4 WD)"; // appends string to end of our str variable
		}
		return str;
	}

	public class TransferCase
	{
		private readonly LightTruck outerInstance;

		internal int numGears;

		public TransferCase(LightTruck outerInstance)
		{
			this.outerInstance = outerInstance;
			this.numGears = 4;
		}

		public TransferCase(LightTruck outerInstance, int gears)
		{
			this.outerInstance = outerInstance;
			this.numGears = gears;
		}

		public virtual int NumGears
		{
			get
			{
				return this.numGears;
			}
		}

	}

	public TransferCase xferCase;
}