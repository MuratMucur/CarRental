namespace CarRental
{
    public class LuxuryCar : Car
    {
       //Constructor
        public LuxuryCar() 
        {
            Description += ":Luxury Car";

        }
        //override method
        public override double GetCost()
        {
            return 200;
        }
    }
}
