namespace CarRental
{
    public class MiddleSizeCar : Car
    {
        //Constructor
        public MiddleSizeCar() 
        {
            Description += ":Middle Size Car";
        }

        //override method
        public override double GetCost()
        {
            return 150;
        }
    }
}
