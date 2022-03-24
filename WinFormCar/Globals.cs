namespace WinFormCar
{
    public static class Globals

    {
        public static List<Car> cars = new List<Car>();


        public static void addTestCars ()
        {
            cars.Add(new Car(0, "Green", 10));
            cars.Add(new Car(1, "Blue", 20));
            cars.Add(new Car(2, "Red", 30));
        }

    }

    
}
