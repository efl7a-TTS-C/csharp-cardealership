using System;
using System.Collections.Generic;

public abstract class Department
{
	private string deptName;
	private int numEmployees;

	public Department()
	{
		this.deptName = "Generic";
		this.numEmployees = 0;
	}

	public Department(string name, int numEmployees)
	{
		this.deptName = name;
		this.numEmployees = numEmployees;
	}

	public static void printIsOpen(IList<Department> depts, DateTime today)
	{
		// Cycle through each department in provided List
		foreach (Department d in depts)
		{
			// Print out name of Dept and return if that Dept is open today
			Console.WriteLine(d.ToString() + " is open today?" + d.isOpenToday(today));
			// Use instanceof keyword to test if item in List is
			// of a certain object or data type
			if (d is ServiceDepartment)
			{
				Console.WriteLine(d.ToString() + " only closes on Sundays.");
			}
		}
	}

	public abstract bool isOpenToday(DateTime day);

	public override string ToString()
	{
		return this.deptName + " Department";
	}
}