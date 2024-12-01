namespace CarRental
{
    public class MiddleSizeCar : Car
    {

        private string fuelConsumption;
        public string FuelConsumption
        {

            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public MiddleSizeCar() : base()
        {
            Description += ": Middle Size";
            fuelConsumption = "";
        }

        public MiddleSizeCar(string carmodel, string transmission, string fuelconsumption) : base(carmodel, transmission)
        {
            this.fuelConsumption = fuelconsumption;
        }
        public override string ToString()
        {
            return $"Middle Size Car - {base.ToString()}, Consumption:{fuelConsumption}";
        }


        
       

        //override method
        public override double GetCost()
        {
            return 150;
        }
    }
}
