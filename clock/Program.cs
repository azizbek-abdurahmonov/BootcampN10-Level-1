DateTime birthday = Convert.ToDateTime(Console.ReadLine());
while(true)
{
    var time = DateTime.Now - birthday;

    Console.WriteLine("Tug'ilganingizga aniq shuncha vaqt bo'ldi:");
    Console.WriteLine($"{(DateTime.Now.Year - birthday.Year)} Yil,\n{DateTime.Now.Month - birthday.Month} oy \n{DateTime.Now.Day - birthday.Day} kun\n{time.Hours} Soat\n{time.Minutes} Minut\n{time.Seconds} Sekund\n{time.Milliseconds} millisecond");
    Thread.Sleep(millisecondsTimeout: 1000);
    Console.Clear();
}