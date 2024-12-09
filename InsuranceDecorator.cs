namespace CarRental
{
    public class InsuranceDecorator : CarDecorator
    {
        Car car;

        // Constructor
        public InsuranceDecorator(Car car)
        {
            this.car = car;
            Description = $"{car.Description},full insurance selected"; // Add insurance description
        }


        // Override method to add $75 for full insurance
        public override double GetCost()
        {
            return car.GetCost() + 75;
        }
        // Return the updated description
        public override string GetDescription()
        {
            return $"{car.Description}, full insurance selected";
        }
    }
}
