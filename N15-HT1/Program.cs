using N15_HT1;

//var weather = new WeatherReport();
//weather.Add(new DateOnly(2023, 7, 29), "Quyoshli");
//weather.Add(new DateOnly(2023, 7, 29), "Juda sovuq");
//weather.Add(new DateOnly(2023, 7, 30), "Yomg'irli");
//weather.Add(new DateOnly(2023, 8, 29), "Ochiq");
//weather.Add(new DateOnly(2023, 7, 28), "anomal issiq");
//weather.Add(new DateOnly(2023, 7, 31), "anomal sovuq");

//Console.WriteLine(weather.Get(new DateOnly(2023, 7, 30)));



//var weatherB = new ValidatedWeahterReport();
//weatherB.Add(new DateOnly(2023, 7, 29), "Quyoshli");
//weatherB.Add(new DateOnly(2023, 7, 29), "Juda sovuq");
//weatherB.Add(new DateOnly(2023, 7, 30), "Yomg'irli");
//weatherB.Add(new DateOnly(2023, 8, 29), "Ochiq");
//weatherB.Add(new DateOnly(2023, 7, 28), "anomal issiq");
//weatherB.Add(new DateOnly(2023, 7, 31), "anomal sovuq");

//Console.WriteLine(weatherB.Get(new DateOnly(2023, 7, 29)));
//Console.WriteLine(weatherB.Get(new DateOnly(2024, 7, 29)));

var weatherC = new UltimateWeatherReport();
weatherC.Add(new DateOnly(2023, 7, 25), "Quyoshli");
weatherC.Add(new DateOnly(2023, 7, 27), "Yomg'irli");
weatherC.Add(new DateOnly(2023, 7, 26), "Juda sovuq");
weatherC.Add(new DateOnly(2023, 7, 28), "Ochiq");
weatherC.Add(new DateOnly(2023, 7, 30), "anomal sovuq");
weatherC.Add(new DateOnly(2023, 7, 29), "anomal issiq");
//25, 26, 27, 28, 29, 30

//foreach(var weather in weatherC.Get(new DateOnly(2023, 7, 26), 4))
//{
//    Console.WriteLine(weather.Key + " " + weather.Value);
//}


foreach (var weather in weatherC.Get(2))
{
    Console.WriteLine(weather.Key + " " + weather.Value);
}
