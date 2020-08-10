// Our first Factory! Depending on name of the Department given, creates a new instance of that department
public class DepartmentFactory
{
	public static Department CreateDepartment(DepartmentNames name)
	{
		Department d = null;

		if (name == null)
		{
			return null;
		}

		switch (name)
		{
			case DepartmentNames.SERVICE:
				d = new ServiceDepartment();
				break;
			case DepartmentNames.SALES:
				d = new SalesDepartment();
				break;
			case DepartmentNames.FINANCE:
				d = new FinanceDepartment();
				break;
			default:
			break;
		}

		return d;
	}
}