namespace CarRental
{
    public class EconomyCar : Car
    {


        //Constructor
        public EconomyCar(): base()
        {
            Description = "Economy car";
          
        }

        public EconomyCar(string carmodel, string transmission, string fuelconsumption) : base(carmodel, transmission,fuelconsumption) 
        {
            Description = $"Economy Car: {carmodel}, {transmission}, {fuelconsumption}";
        }

        //override method
        public override double GetCost()
        {
            return 100;
        }


      

            
        
    }

}

