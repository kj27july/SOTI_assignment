using System;

public class FactoryDP
{
	public getClass(string type)
	{
        switch (type)
        {
            case "Vehicle": return new VehicleClass();
            case "": return new Tax();
                break;
        }
	}
}

abstract class AbstractClass
{
    protected double amount = 0;
    public abstract getAmount();
}

class VehicleClass : AbstractClass
{
    public double amount = 50;
    public double getAmount()
    {
        return amount;
    }
}