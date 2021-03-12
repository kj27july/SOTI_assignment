using System;

public class FactoryDP
{
	public getClass(string type)
	{
        switch (type)
        {
            case "Tax": return new Tax();
                break;
        }
	}
}

abstract class AbstractClass
{
    protected double amount = 0;
    public abstract getAmount();
}

