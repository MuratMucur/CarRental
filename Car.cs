using System;

namespace CarRental
{
    public abstract class Car
    {
        private string carModel;
        private string carTransmission;
        private string fuelConsumption;
        private DateTime? startDate;
        private DateTime? endDate;
        public string FuelConsumption
        {

            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }



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
        public DateTime StartDate
        {
            get { return (DateTime)startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return (DateTime)endDate; }
            set { endDate = value; }
        }

        public Car()
        {
            carModel = "";
            carTransmission = "";
            fuelConsumption = "";
            startDate = null;
            endDate = null;
        }
        public Car(string carmodel, string cartransmission, string fuelconsumption)
        {
            this.carModel = carmodel;
            this.carTransmission = cartransmission;
            this.fuelConsumption=fuelconsumption;
            startDate = null;
            endDate = null;


        }
        public override string ToString()
        {
            return $" Model:{carModel}, Transmission:{carTransmission}, Fuel Consumption:{fuelConsumption}";
        }

        //fields
        private string description = "Car Type:";

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
