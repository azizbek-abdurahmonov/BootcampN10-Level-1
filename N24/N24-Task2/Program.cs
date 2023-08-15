using N24_Task2;

var service = new MovieService();

service.Add("Kino 1", "Gishtmat", 35);
service.Add("Kino 2", "Toshmat", 50);
service.Add("Kino 1", "Qodirali", 78);
service.Add("Kino 4", "Tursunxon", 95);

service.GetByMovie().ForEach(Console.WriteLine);