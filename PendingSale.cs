// Limit our generic class to only be used by Vehicle or those derived from it
// This kind of restriction is called "bounded type"
public class PendingSale<E> where E : Vehicle
{
	private E someVehicle;

	public PendingSale(E someVehicle)
	{
		this.someVehicle = someVehicle;
	}

	public virtual E SomeVehicle
	{
		get
		{
			return this.someVehicle;
		}
	}

	public virtual void doSomePaperwork()
	{
		// Do something here
	}
}