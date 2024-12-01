namespace CarRental
{
    public class EconomyCar : Car
    {

        private string fuelConsumption;
        public string FuelConsumption
        {

            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }


        //Constructor
        public EconomyCar(): base()
        {
            Description += ": Economy";
            fuelConsumption = "";
        }

        public EconomyCar(string carmodel, string transmission, string fuelconsumption) : base(carmodel, transmission) 
        {
            this.fuelConsumption = fuelconsumption;
        }

        public override string ToString()
        {
            return $"Economy Car - {base.ToString()}, Consumption:{fuelConsumption}";
        }
        //override method
        public override double GetCost()
        {
            return 100;
        }


      

            
        
    }

}

