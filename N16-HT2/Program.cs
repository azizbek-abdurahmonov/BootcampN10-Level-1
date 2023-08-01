using N16_HT2;

var smartHome = new SmartHomeService();
smartHome.Add(new Temperature(20, 22));
smartHome.Add(new Temperature(20, 23));
smartHome.Add(new Temperature(20, 21));
smartHome.Add(new Temperature(20, 20));

smartHome.Add(new Temperature(25, 21));
smartHome.Add(new Temperature(25, 22));
smartHome.Add(new Temperature(25, 23));

smartHome.DisplayHomeTemperature();
