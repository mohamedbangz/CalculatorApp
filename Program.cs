using System;
namespace CalculatorApp
{
class Program
   {
    
     static void Main(string[] args)
        {
            // the garage to hold multiple cars
            List<Car> myGarage = new List<Car>();
            myGarage.Add(new Car("Toyota", "Camry", 2020));
            myGarage.Add(new Car("Chevrolet", "Impala", 2019));
            myGarage.Add(new Car("Ford", "Mustang", 2021));
            myGarage.Add(new Car("Honda", "Civic", 2022));
            // loop through the garage and display each car's details
  
            Console.WriteLine("==My Garage:==");
            foreach (Car car in myGarage)
            {
                Console.WriteLine($"I drive a: {car.Year} {car.Make} {car.Model}");
                car.Honk();
            }

            // Create an instance of the Car class
            Car myCar = new Car(    
                make: "Toyota",
                model: "Camry",
                year: 2020);
             // Set properties of the Car instance
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2020;  

            //use it properties and call itmethods
            Console.WriteLine($" i drive a:{myCar.Year} {myCar.Make} {myCar.Model}");
            myCar.Honk();

             friendsCar friendsCar = new friendsCar(    
                make: "Chevrolet",
                model: "Impala",
                year: 2019);
            //use it properties and call itmethods  
            Console.WriteLine($"My friend drives a:{friendsCar.Year} {friendsCar.Make} {friendsCar.Model}");
            friendsCar.Honk();

             bool runningstate = true;
            do
            {
             Console.WriteLine("\nchoose a mode:");
             Console.WriteLine("1.  Standard Math(+,-,*,/  )");
             Console.WriteLine("2.  Add multiple numbers(using itiration)");
             Console.WriteLine("3.  Exit");
             Console.Write("Enter your choice(1,2, or3): ");
                string choice = Console.ReadLine()??"";
                if (choice == "1")
                {
                    RunBasicMath();
                }
                else if (choice == "2")
                {
                     
                    AddMultipleNumbers();
                }
                else if (choice == "3")
                {
                    runningstate = false;
                    Console.WriteLine("Exiting the application. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");

                }

               // KEEP RUNNING UNTIL RUNNINGSTATE IS FALSE 
            } while (runningstate);
        
        }  // THE METHOD FOR BASIC MATH OPERATIONS  
        static void RunBasicMath()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation (+, -, *, /):");
            string operation = Console.ReadLine()??"";
            double result = 0;
            bool validOperation = true;

            if (operation == "+")
            {
                
                    result = num1 + num2;
            }
            else if (operation == "-")
            {
                    result = num1 - num2;
                    
         }
            else if (operation == "*")
            {                                           

                        result = num1 * num2;
            }

            else if (operation == "/")
            {
                
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                validOperation = false;
            }

             if (validOperation)
                    {
                        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");


                    }      

            }

   // the second method for adding multiple numbers using iteration
           static void AddMultipleNumbers()
            {
                Console.WriteLine("Enter the number of values you want to add:");
                int count = Convert.ToInt32(Console.ReadLine());
                double sum = 0;

                for (int i = 1; i <= count; i++)
                {
                  Console.Write($"Enter number {i}: ");
                   double number = Convert.ToDouble(Console.ReadLine());
                   sum += number;
               }

            Console.WriteLine($"The sum of the entered numbers is: {sum}");

            // while loop is good when you want to keep running until a certain condition is met, like user input or a specific event. In this case, the while loop is used to keep the calculator running until the user chooses to exit. 
            Console.Write("Do you want to add more numbers? (y/n): ");
                string choice = Console.ReadLine()??"n"; // Default to "n" if null
                while (choice.ToLower() == "y" )
               {
    
                Console.WriteLine("Enter the number of values you want to add:");
                double bonusNum= Convert.ToDouble(Console.ReadLine());
                sum = sum + bonusNum;
                 Console.WriteLine($"The new sum of the entered numbers is: {sum}");    
                
                Console.Write("Do you want to add more numbers? (y/n): ");
                choice = Console.ReadLine();
           }
             Console.WriteLine($"The final sum of the entered numbers is: {sum}"); 
        }
    }
}

   




 