namespace CarRental
{
    public class ChildSeatDecorator : CarDecorator
    {
        Car car;

        // Constructor 
        public ChildSeatDecorator(Car car)
        {
            this.car = car;
            Description = $"{car.Description}, Child seat included"; // child seat description
        }

        // Override method to add $20 euro
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
