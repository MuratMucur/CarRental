namespace CarRental
{
    public abstract class Car
    {
        //fields
        private string description = "Car Rental";

        //properties
        public string Description { 
        get { return description; }
        set { description = value; }

        }
        public abstract double GetCost();

    }
    public abstract class CarDecorator : Car
    {
        public abstract string GetDescription();

    }
    public enum CarType
    {
        CityCar,
        MiddleSize,
        Luxury
    }

}
