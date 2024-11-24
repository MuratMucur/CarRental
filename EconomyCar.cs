namespace CarRental
{
    public class EconomyCar : Car
    {
        //Constructor
        public EconomyCar()
        {
            Description += ": Economy";

        }

        //override method
        public override double GetCost()
        {
            return 100;
        }


        Car car1 = new Car("eee", "dd");
        
    }

}

