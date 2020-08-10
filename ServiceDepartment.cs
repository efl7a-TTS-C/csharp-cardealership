using System;

public class ServiceDepartment : Department
{
	// Constructor with deptName and numEmployees given
	public ServiceDepartment() : base("Service", 20)
	{
	}

	// Create "association" between Vehicle and ServiceDepartment
	// Very loose, lifetime of objects are independent of one another
	public virtual bool changeEngineOil(Vehicle v)
	{
		// Because ServiceDepartment doesn't "own" the lifetime of the object its
		// good practice to ensure a valid object has been passed in
		if (v != null)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	public override bool isOpenToday(DateTime day)
	{
		// SUNDAY is an example of an enumeration
		if (day.DayOfWeek.Equals(DayOfWeek.Sunday))
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}