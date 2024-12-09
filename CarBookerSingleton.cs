namespace CarRental
{
    public class CarBookerSingleton
    {
        public static readonly CarBookerSingleton Instance = new CarBookerSingleton();

        public static int economyCar = 6; // Number of available economy cars
        public static int middleSizeCar = 7; // Number of available middle size cars
        public static int luxuryCar = 4; // Number of available luxury cars

        private CarBookerSingleton() { }

        // Method to book a car based on the selected type
        public bool BookCar(CarType type) 
        {
            bool successfulBooking=false;
            switch (type)
            {
                case CarType.Economy:
                    if (economyCar > 0) // Check if any economy cars are available
                    {
                        economyCar--;
                        successfulBooking = true;
                    }
                    break;
                case CarType.MiddleSize:
                    if (middleSizeCar > 0) // Check if any middle size cars are available
                    {
                        middleSizeCar--;
                        successfulBooking = true;
                    }
                    break;
                case CarType.Luxury:
                    if (luxuryCar > 0) // Check if any luxury cars are available
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
