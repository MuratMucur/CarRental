namespace CarRental
{
    public class LuxuryCar : Car
    {

        private string fuelConsumption;
        public string FuelConsumption
        {

            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public LuxuryCar() : base()
        {
            Description += ": Luxury Car";
            fuelConsumption = "xx";
        }

        public LuxuryCar(string carmodel, string transmission, string fuelconsumption) : base(carmodel, transmission)
        {
            this.fuelConsumption = fuelconsumption;
        }

        public override string ToString()
        {
            return $"Luxury Car - {base.ToString()}, Consumption:{fuelConsumption}";
        }

     
        //override method
        public override double GetCost()
        {
            return 200;
        }
    }
}
