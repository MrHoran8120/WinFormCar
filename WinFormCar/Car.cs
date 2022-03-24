namespace WinFormCar
{
    public class Car
    {
        public int vin;
        public string colour;
        public int odo;

        public Car(int _vin,string _colour, int _odo)
        {
            this.vin = _vin;
            this.colour = _colour;
            this.odo = _odo;

        }
        public string reportMe()
        {
            return "My Vin is  " + vin + ", colour is " + colour + " odo " + odo;
        }
    }
}
