internal interface Discountable
{
	// In interfaces, methods are by default public and abstract
	// so those keywords aren't needed
	float MaximumDiscountPct {get;}

	float PersonDiscount {get;}

	float CorporateDiscount {get;}
}