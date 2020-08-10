using System;

public class FinanceDepartment : Department
{
	public FinanceDepartment() : base("Finance", 10)
	{
	}

	public override bool isOpenToday(DateTime day)
	{
		// Return false if it is Saturday or Sunday
		if (day.DayOfWeek.Equals(DayOfWeek.Sunday) || day.DayOfWeek.Equals(DayOfWeek.Saturday))
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}