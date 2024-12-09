namespace CarRental
{
    public class MiddleSizeCar : Car
    {


        // Constructor
        public MiddleSizeCar() : base()
        {
            Description += ": Middle Size Car";
            
        }

        public MiddleSizeCar(string carmodel, string transmission, string fuelconsumption) : base(carmodel, transmission, fuelconsumption)
        {
            Description = $"Middle Size Car: {carmodel}, {transmission}, {fuelconsumption}";
        }
    
       

        //override method
        public override double GetCost()
        {
            return 150;
        }
    }
}
