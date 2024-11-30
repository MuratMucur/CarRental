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

        public EconomyCar(string fuelconsumption,string carmodel, string transmission) : base(carmodel, transmission) 
        {
            this.fuelConsumption = fuelConsumption;
        }

        public override string ToString()
        {
            return $"Economy Car - Consumption:{fuelConsumption}, {base.ToString()}";
        }
        //override method
        public override double GetCost()
        {
            return 100;
        }


      

            
        
    }

}

