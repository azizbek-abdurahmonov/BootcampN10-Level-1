using N20_HT1;

//Online market kartasi va provideri
var MarketCard = new KapitalUzcard("8600123456789012", "UzBank", 0);
var provider = new PaymePaymentProvider();

var OnlineMarket = new OnlineMarket(provider, MarketCard);

//Marketga productlar qo'shish
OnlineMarket.Add(new Product("Lenovo", 1_500_000));
OnlineMarket.Add(new Product("HP-Pavilion", 2_250_000));
OnlineMarket.Add(new Product("HP-Victus", 2_500_000));

//foydalanuvchining shaxsiy kartasi
var MyPersonalCard = new KapitalUzcard("86001111222233334444", "UzBankN1", 50_000_000);


//Productlar sotib olish
Console.WriteLine(
    OnlineMarket.Buy("Lenovo", 10, MyPersonalCard)
    ? "Lenovo - muvaffaqiyatli sotib olindi"
    : "Mahsulot topilmadi yoki Balansingizda yetarli mablag' mavjud emas");

Console.WriteLine(
    OnlineMarket.Buy("Toshiba", 10, MyPersonalCard)
    ? "Toshiba - muvaffaqiyatli sotib olindi"
    : "Mahsulot topilmadi yoki Balansingizda yetarli mablag' mavjud emas");

Console.WriteLine($"Kartangizdagi qoldiq: {MyPersonalCard.Balance}");