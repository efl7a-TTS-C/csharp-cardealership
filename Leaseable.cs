// Interfaces normally follow a naming convention similar to classes
// but they end in '-ible' or '-able'
// Usually adjective because we usually interfaces to provide additional capabilities

internal interface Leaseable
{
	bool Leaseable {get;}

	int LeaseTerm {get;}

	int MaxMilesPerYear {get;}

//JAVA TO C# CONVERTER TODO TASK: There is no equivalent in C# to Java default interface methods unless the C# 2019 extended interface option is selected:
//	default float getMileablePenalty()
//	{
//		return 500.0f;
//	}
}