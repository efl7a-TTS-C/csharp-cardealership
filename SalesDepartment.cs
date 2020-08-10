using System;

public class SalesDepartment : Department
{
	public SalesDepartment() : base("Sales", 50)
	{
	}

	public override bool isOpenToday(DateTime day)
	{
		// Return true because SalesDepartment is open 7 days a week
		return true;
	}
}