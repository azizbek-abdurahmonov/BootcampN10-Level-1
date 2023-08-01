var temp = new TemperatureSensorService();
temp.Temperature = "45";
temp.Temperature = "55";
temp.Temperature = "15";
temp.Temperature = "18";
temp.Temperature = "-5";

temp.Display();





public class TemperatureSensorService
{
    List<string> temperatures = new List<string>();

    private string _temperature;
    public string Temperature
    {
        set => temperatures.Add(value);
    }

    public void Display()
    {
        foreach(var item in temperatures)
        {
            Console.WriteLine($"{item} C");
        }
    }
}