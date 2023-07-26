var cars = new List<Car>();
cars.Add(new Car { name = "Malibu", brand = "GM" });
cars.Add(new Car { name = "Captiva", brand = "GM" });
cars.Add(new Car { name = "Supra", brand = "AJA" });
cars.Add(new Car { name = "BMW", brand = "REC" });
cars.Add(new Car { name = "Nexia", brand = "SAUB" });
cars.Add(new Car { name = "Nexia 2", brand = "GM" });
cars.Add(new Car { name = "Malibu", brand = "GM" });
cars.Add(new Car { name = "Malibu", brand = "GM" });
cars.Add(new Car { name = "SportCar", brand = "SNA" });
cars.Add(new Car { name = "Malibu", brand = "GM" });

var info = new Dictionary<Car, int>();
for (var i = 0; i < cars.Count; i++)
{
    var count = 0;
    for (var j = 0; j < cars.Count; j++)
    {
        if (cars[i].GetHashCode() == cars[j].GetHashCode())
        {
            count++;
        }
    }
    if (!info.ContainsKey(cars[i]))
    {
        info.Add(cars[i], count);
    }
}



foreach (var car in info)
{
    if (car.Value > 0)
        Console.WriteLine($"{car.Key.name} - {car.Value}");
}

public class Car
{
    public string name;
    public string brand;

    public override bool Equals(object? obj)
    {
        if (obj is Car car)
        {
            return car.GetHashCode() == obj.GetHashCode() ? true : false;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return this.name.GetHashCode() + this.brand.GetHashCode();
    }
}