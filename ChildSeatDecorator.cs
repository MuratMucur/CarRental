namespace CarRental
{
    public class ChildSeatDecorator : Car
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
    }
}
