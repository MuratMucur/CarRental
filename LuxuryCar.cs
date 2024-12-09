namespace CarRental
{
    public class LuxuryCar : Car
    {

       
        public LuxuryCar() : base()
        {
            Description = ": Luxury Car";
          
        }

        public LuxuryCar(string carmodel, string transmission, string fuelconsumption) : base(carmodel, transmission, fuelconsumption)
        {
            Description = $"Luxury Car: {carmodel}, {transmission}, {fuelconsumption}";
        }


     
        //override method
        public override double GetCost()
        {
            return 200;
        }
    }
}
