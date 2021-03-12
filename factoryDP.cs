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

     //add this class(this belongs to Tax)
        public void calculateAmount(double salary)
        {
            Console.WriteLine(amount*salary);
        }
}


 /*
    public abstract  class AbstractClass
    {
        protected double amount;
        public abstract void getAmount();

        //add this class
        public void calculateAmount(double salary)
        {
            Console.WriteLine(amount*salary);
        }
    }
    */
   
    class Slap1 : AbstractClass
    {
        public override void getAmount()
        {
            this.amount = 0.05;
        }
    }

    class Slap2 : AbstractClass
    {
        public override void getAmount()
        {
           
            this.amount = 0.10;
        }
    }

    class Slap3 : AbstractClass
    {
        public override void getAmount()
        {
           
            this.amount = 0.15;
        }
    }

    class Slap4 : AbstractClass
    {
        public override void getAmount()
        {
           
            this.amount = 0.20;
        }
    }
    class Slap5 : AbstractClass
    {
        public override void getAmount()
        {
          
            this.amount = 0.25;
        }
    }

