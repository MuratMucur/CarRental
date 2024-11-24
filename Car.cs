using System;

namespace CarRental
{
    public abstract class Car
    {
        private string carModel;
        private string carTransmission;

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }
        public string CarTransmission 
        {
            get { return carTransmission; }
            set { carTransmission = value; }
        }

        public Car()
        {
            carModel = "";
            carTransmission = "";

        }
        public Car(string carmodel, string cartransmission)
        {
            this.carModel=carmodel;
            this.carTransmission = cartransmission;
          
        }
        public override string ToString()
        {
            return $" Model:{carModel}, Race Time:{raceTime}"; ;
        }

        //fields
        private string description = "Car Type";

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
        Economy,
        MiddleSize,
        Luxury
    }

}
