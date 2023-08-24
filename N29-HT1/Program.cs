var usernameList = new List<string>
{
    "Azizbek",
    "Behruz",
    "BlaBlabla",
};

var tasks = usernameList.Select(username => Task.Run(() =>
{
    File.Create($"{username}.txt");
    Console.WriteLine($"{username} uchun fayl yaratildi");
}));

Task.WhenAll(tasks).Wait();