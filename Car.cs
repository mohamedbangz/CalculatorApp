namespace CalculatorApp
{
    public class Car
    {
        public string? Make;
        public string? Model;
        public int Year;
        public Car(string make, string model, int year)
        {               
            Make = make;
            Model = model;
            Year = year;
        }   

               public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
    }
}