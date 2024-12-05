namespace CarRental
{
    public class ChildSeatDecorator : CarDecorator
    {
        Car car;
        public ChildSeatDecorator(Car car)
        {
            this.car = car;
            Description = $"{car.Description}, Child seat included";
        }

        public override double GetCost()
        {
            return car.GetCost() + 20;
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
