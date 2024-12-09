namespace CarRental
{
    public class CarBookerSingleton
    {
        public static readonly CarBookerSingleton Instance = new CarBookerSingleton();

        public static int economyCar = 7;
        public static int middleSizeCar = 7;
        public static int luxuryCar = 7;

        private CarBookerSingleton() { }

        public bool BookCar(CarType type) 
        {
            bool successfulBooking=false;
            switch (type)
            {
                case CarType.Economy:
                    if (economyCar > 0)
                    {
                        economyCar--;
                        successfulBooking = true;
                    }
                    break;
                case CarType.MiddleSize:
                    if (middleSizeCar > 0)
                    {
                        middleSizeCar--;
                        successfulBooking = true;
                    }
                    break;
                case CarType.Luxury:
                    if (luxuryCar > 0)
                    {
                        luxuryCar--;
                        successfulBooking = true;
                    }
                    break;

            }
            
            return successfulBooking;

        }
    }
}
