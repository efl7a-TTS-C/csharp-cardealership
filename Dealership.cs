using System;
using System.Collections.Generic;

public class Dealership
{
	public static void Main(string[] args)
	{

		// LightTruck lt = new LightTruck("234JLKD234", 48000.00, 62000.00, 2019,
		// "Chevrolet", "Silverado", "Silver",
		// 10000L, 90000L, true, VehicleClassification.NEW);

		// if (lt.getIs4wd()) {
		// int gears = lt.xferCase.getNumGears();
		// System.out.println("Number of Gears: " + gears);
		// }
		// lt.printVehicleType();

		// Leaseable lease = new Car("52430899FD", 33000.00, 42000.00, 2019,
		// "Chevrolet", "Impala", "White",
		// VehicleClassification.NEW);

		// System.out.println("Number of months to lease: " + lease.getLeaseTerm());

		// Instanciate new object for each Department
		// ServiceDepartment sd = new ServiceDepartment();
		// FinanceDepartment fd = new FinanceDepartment();
		// SalesDepartment sales = new SalesDepartment();

		// Have Factory create new departments for us
		Department sd = DepartmentFactory.CreateDepartment(DepartmentNames.SERVICE);
		Department fd = DepartmentFactory.CreateDepartment(DepartmentNames.FINANCE);
		Department sales = DepartmentFactory.CreateDepartment(DepartmentNames.SALES);

		// Add our departments to a List
		IList<Department> depts = new List<Department>();
		depts.Add(sd);
		depts.Add(fd);
		depts.Add(sales);

		Department.printIsOpen(depts, DateTime.Now);

		// Won't work, but example of calling on our Factory
		Leaseable l = LeaseVehicleFactory.getLeaseableVehicleByVin("234JK234");
	}
}