
using Week5Final;

List<Car> cars = new List<Car>();

while (true)
{
    Console.WriteLine("Do you want to add a car ? (y/n):");
    string answer = Console.ReadLine().ToLower();
    if (answer == "y")
    {
        Car car = new Car();
        
        Console.Write("Enter Serial Number:");
        car.SerialNumber = Console.ReadLine().ToLower();
        
        Console.Write("Enter Brand:");
        car.Brand = Console.ReadLine().ToLower();
        
        Console.Write("Enter Model:");
        car.Model = Console.ReadLine().ToLower();
        
        Console.Write("Enter Color:");
        car.Color = Console.ReadLine().ToLower();
        
        askdoor: Console.Write("Enter Door Count (2 or 4): ");
        try
        {
            car.DoorCount = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Enter an integer!!");
            goto askdoor;

        }
        
        
        cars.Add(car);
        
    }

    else
    {
        Console.WriteLine("Have a nice day! Bye!");
        break;
    }
        

    
}

foreach (var car in cars)
{
    car.ToString();
}