using N17_HT1;

var management = new CarRentalManagement();
CarRental bmw1 = new Bmw("BMW-HT1");
CarRental bmw2 = new Bmw("BMW-HT2");
CarRental bmw3 = new Bmw("BMW-HT3");

CarRental audi1 = new Audi("Audi-HT1");
CarRental audi2 = new Audi("Audi-HT2");
CarRental audi3 = new Audi("Audi-HT3");

management.Add(bmw1);
management.Add(bmw2);
management.Add(bmw3);
management.Add(audi1);
management.Add(audi2);
management.Add(audi3);



var rent1 = management.Rent("BMW");
await Task.Delay(1000 * 5);
management.Return(rent1);

var rent2 = management.Rent("BMW");
await Task.Delay(1000 * 6);
management.Return(rent2);

var rent3 = management.Rent("AUDI");
await Task.Delay(1000 * 4);
management.Return(rent3);

var rent4 = management.Rent("BMW");
await Task.Delay(1000 * 3);
management.Return(rent4);

management.CalculateBalance();