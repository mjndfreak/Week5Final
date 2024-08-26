namespace Week5Final;

public class Car
{
    public Car()
    {
        ProductionDate = DateTime.Today;
    }

    public DateTime ProductionDate { get; set; }
    public string SerialNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    private int _doorCount;
    public int DoorCount
    {
        get
        {
            return _doorCount;
        }
        set
        {
           set: if (value == 2 || value == 4)
                _doorCount = value;
            else
            {
                Console.WriteLine("2 or 4");
                goto set;
            }
        }
    }

    public override string ToString()
    {
        return ProductionDate + " " + SerialNumber + " " + Model;

    }
} 