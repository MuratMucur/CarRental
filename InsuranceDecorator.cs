namespace CarRental
{
    public class InsuranceDecorator : CarDecorator
    {
        Car car;
        public InsuranceDecorator(Car car)
        {
            this.car = car;
            Description = $"{car.Description},full insurance selected";
        }
        public override double GetCost()
        {
            return car.GetCost() + 75;
        }

        public override string GetDescription()
        {
            return $"{car.Description}, full insurance selected";
        }
    }
}
