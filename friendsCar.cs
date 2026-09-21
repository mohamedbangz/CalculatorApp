namespace CalculatorApp
{
    public class FriendsCar: Vehicle
    {
        

        public FriendsCar(string make, string model, int year): base(make, model, year)   
        {
        }

        public void Honk()
        {
            Console.WriteLine("peeeee peeeeee!");
             
        }
                       public void StartEngine()
        {
            Console.WriteLine("Veron!! The Engine started!");
        }
    }
}

