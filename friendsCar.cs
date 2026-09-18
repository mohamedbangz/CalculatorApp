
    public class friendsCar
    {
        public string? Make;
        public string? Model;
        public int Year;

        public friendsCar(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }   

        public void Honk()
        {
            Console.WriteLine("peeeee peeeeee!");
             
        }
    }
