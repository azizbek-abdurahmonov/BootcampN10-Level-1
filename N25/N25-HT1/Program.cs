using N25_HT1.Services;
using N25_HT1.Models;
using Monitor = N25_HT1.Models.Monitor;

var productService = new ProductService();
var paymentService = new PaymentService();

var orderService = new OrderService(productService, paymentService);

//add monitors
var m1 = new Monitor("Monitor-1 pro", "ajoyib monitor", false, 1_500_000, 20, 144); ;
productService.Add(m1);

var m2 = new Monitor("Monitor-2 pro", "ajoyib monitor 2 ", false, 1_750_000, 18, 120); ;
productService.Add(m2);

var m3 = new Monitor("Monitor-3 pro", "ajoyib monitor - 3", false, 1_000_000, 10, 144); ;
productService.Add(m1);

var m4 = new Monitor("Monitor-4 pro", "ajoyib monitor - 4 ", false, 1_050_000, 18, 120); ;
productService.Add(m2);

// add laptops
var l1 = new Laptop("HP", "ajoyib", false, 5_000_000, "ryzen", "amd");
productService.Add(l1);

var l2 = new Laptop("HP-2", "ajoyib2", false, 6_000_000, "intel", "core");
productService.Add(l2);

var l3 = new Laptop("Victus", "ajoyib3", false, 7_000_000, "ryzen5", "amd");
productService.Add(l3);

// add chairs
var ch1 = new Chair("chair1", "ajoyib-chair1", false, 200_000, 10, "nimadir");
productService.Add(ch1);

var ch2 = new Chair("chair2", "ajoyib-chair2", false, 200_000, 13, "nimadir");
productService.Add(ch2);
var ch3 = new Chair("chair3", "ajoyib-chair1", false, 400_000, 15, "nimadir");
productService.Add(ch3);

Console.WriteLine("Hozirda mavjud tiplar: ");
productService.GetFilterData().ProductTypes.ForEach(Console.WriteLine);

var myCard = new DebitCard { CardNumber = "860000000000", Balance = 10_000_000 };

Console.WriteLine("balance: " + myCard.Balance);

if (orderService.Order(ch1.Id, myCard))
    Console.WriteLine("Sotib olindi");
else
{
    Console.WriteLine("Xatolik");
}

Console.WriteLine("balance: " + myCard.Balance);
