namespace CalculatorApp
{
    public class Car: Vehicle
    {
        public Car(string make, string model, int year): base(make, model, year)   
        {
        }           

               public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }

                       public void StartEngine()
        {
            Console.WriteLine("Veron!! The Engine started!");
        }
                       
    }
}