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
	protected int Beds;
        protected double ratePDay;
        public abstract void GetRate();

        public void GetBill(double hours) {
            Console.WriteLine(hours*ratePDay*Beds);
        }

        //add this class
        public void calculateAmount(double salary)
        {
            Console.WriteLine(amount * salary);
        }
}

//tax
/*
public abstract  class AbstractClass
{
   protected double amount;
   public abstract void getAmount();

  
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
//tax


class DoubleBedRoom : AbstractClass
    {
        
        public override void GetRate() {
            ratePDay = 1000;
            Beds = 2;
        }

        
    }

    class SingleBedRoom : AbstractClass
    {
        public override void GetRate()
        {
            ratePDay = 800;
            Beds = 1;
        }
    }

    class TripleBedRoom : AbstractClass
    {
        public override void GetRate()
        {
            ratePDay = 1100;
            Beds = 3;
        }
    }

    class GetRoomFactory
    {
        public AbstractClass GetRoom(string RoomType) {
            switch (RoomType) {
                case "SINGLE":
                    return new SingleBedRoom();
                case "DOUBLE":
                    return new DoubleBedRoom();
                case "TRIPLE":
                    return new TripleBedRoom();
                default:
                    return null;
            }
        }

    }

class VehicleClass : AbstractClass
{
    public double amount = 50;
    public double getAmount()
    {
        return amount;
    }
}

class Jeep : VehicleClass
{
    public double amount = 100;
}
class Ambassador : VehicleClass
{
    public double amount = 110;
}