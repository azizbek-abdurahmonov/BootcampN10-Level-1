// Eventlarni va ularni vaqtlarini alohida arraylarga saqlab olish
var dates = new DateTime[]
{
    new DateTime(2023, 01, 14),
    new DateTime(2023, 3, 8),
    new DateTime(2023, 3, 21),
    new DateTime(2023, 5, 9),
    new DateTime(2023, 12, 8),
    new DateTime(2023, 10, 1),
    new DateTime(2023, 9, 1),
    new DateTime(2023, 2, 9),
    new DateTime(2023, 1, 1),
    new DateTime(2023, 2, 14),

};

var names = new string[]
{
    "Day of the defenders of the native land",
    "Woman's Day",
    "Navruz",
    "Day of memory and honour",
    "Constitution Day",
    "Teachers and instructors' day",
    "Independence Day",
    "Alisher Navoi's birthday",
    "New Year",
    "Bobur's birthday"
};

while (true)
{
    Console.WriteLine("- Quyidaglardan bittasini tanlang\r\n  eventlarni saralash - 1\r\n  eventni nomi bo'yicha topish - 2\r\n  eventni vaqti bo'yicha topish - 3\r\n  kelayotgan eventlarni ko'rsatish - 4\r\n  o'tib ketgan eventlarni ko'rsatish - 5\r\n  kelayotgan eventlarni ko'rsatish ( yaqinligi bo'yicha ) - 6\r\n  o'tib ketgan eventlarni ko'rsatish ( yaqinligi bo'yicha ) - 7\r\n  dasturni yopish - 8");
    var res = Console.ReadLine();
    var amallar = "12345678";
    if (string.IsNullOrEmpty(res))
    {
        Console.WriteLine("Xato amal kiritildi!\nIltimos qaytadan uruning");

    }
    else if (!amallar.Contains(res))
    {
        Console.WriteLine("Bunday amal mavjud emas Iltimos qaytadan uruning");
    }else if(res == "8")
    {
        Console.WriteLine("Good Bye...");
        break;
    }
    else
    {
        switch (res)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Saralash turini tanlang \r\n event nomi bo'yicha - 1\r\n event vaqti bo'yicha - 2\r\n");
                res = Console.ReadLine();
                if (string.IsNullOrEmpty(res))
                {
                    Console.WriteLine("Hech narsa kiritilmadi!");
                    break;
                }
                switch (res)
                {
                    case "1":
                        Console.Clear();
                        for (int i = 0; i < names.Length; i++)
                        {
                            for (int j = 0; j < names.Length; j++)
                            {
                                if (names[i].CompareTo(names[j]) == -1)
                                {
                                    var temp = names[i];
                                    names[i] = names[j];
                                    names[j] = temp;

                                    var temp2 = dates[i];
                                    dates[i] = dates[j];
                                    dates[j] = temp2;
                                }
                            }
                        }

                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine($"{names[i]} - {dates[i].Date}");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Clear();
                        for (int i = 0; i < names.Length; i++)
                            for (int j = i + 1; j < names.Length; j++)
                                if (dates[i].DayOfYear > dates[j].DayOfYear)
                                {
                                    var temp = dates[i];
                                    dates[i] = dates[j];
                                    dates[j] = temp;

                                    var temp2 = names[i];
                                    names[i] = names[j];
                                    names[j] = temp2;
                                }
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine($"{names[i]} - {dates[i].Date}");
                        }
                        Console.WriteLine();
                        break;

                    default: Console.WriteLine("Bunday saralash mavjud emas!"); break;
                }
                break;

            case "2":
                Console.Clear();
                Console.WriteLine("Iltimos event nomini yoki nomidan parchani kiriting: ");
                res = Console.ReadLine();
                if (string.IsNullOrEmpty(res))
                {
                    Console.WriteLine("Hech narsa kiritilmadi!");
                    break;
                }
                Console.Clear();
                var count = 0;
                for (var i = 0; i < names.Length; i++)
                {
                    if (names[i].ToLower().Contains(res.ToLower()))
                    {
                        Console.WriteLine($"{names[i]} - {dates[i]}");
                        count++;
                    }
                }
                if (count == 0)
                    Console.WriteLine("Event topilmadi!");
                Console.WriteLine();
                break;

            case "3":
                Console.Clear();
                Console.WriteLine("Event sanasini to'liq yoki qisman [oy/kun/yil] ko'rinishida kiriting: ");
                res = Console.ReadLine();
                if (string.IsNullOrEmpty(res))
                {
                    Console.WriteLine("Hech narsa kiritilmadi!");
                    break;
                }

                count = 0;
                for (var i = 0; i < names.Length; i++)
                {
                    if (Convert.ToString(dates[i]).Contains(res))
                    {
                        Console.WriteLine($"{names[i]} - {dates[i]}");
                        count++;
                    }
                }

                if (count == 0)
                    Console.WriteLine("Hech qanday event topilmadi!");

                Console.WriteLine();
                break;

            case "4":
                Console.Clear();
                count = 0;
                for (var i = 0; i < names.Length; i++)
                {
                    if (dates[i].DayOfYear > DateTime.Now.DayOfYear)
                    {
                        Console.WriteLine($"{names[i]} - {dates[i]}");
                        count++;
                    }
                }

                if (count == 0)
                    Console.WriteLine("Hech qanday event topilmadi!");

                Console.WriteLine();

                break;

            case "5":
                Console.Clear();
                count = 0;
                for (var i = 0; i < names.Length; i++)
                {
                    if (dates[i].DayOfYear < DateTime.Now.DayOfYear)
                    {
                        Console.WriteLine($"{names[i]} - {dates[i]}");
                        count++;
                    }
                }

                if (count == 0)
                    Console.WriteLine("Hech qanday event topilmadi!");

                Console.WriteLine();
                break;

            case "6":
                Console.Clear();
                var nearNames = new string[1];
                var nearDates = new DateTime[1];

                var idx = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if (dates[i].DayOfYear > DateTime.Now.DayOfYear)
                    {
                        nearDates[idx] = dates[i];
                        nearNames[idx] = names[i];
                        idx++;
                        Array.Resize(ref nearDates, nearDates.Length + 1);
                        Array.Resize(ref nearNames, nearNames.Length + 1);

                    }
                }
                Array.Resize(ref nearDates, nearDates.Length - 1);
                Array.Resize(ref nearNames, nearNames.Length - 1);

                for (var i = 0; i < nearNames.Length; i++)
                {
                    for (int j = i + 1; j < nearNames.Length; j++)
                    {
                        if (nearDates[i].DayOfYear > nearDates[j].DayOfYear)
                        {
                            var temp = nearDates[i];
                            nearDates[i] = nearDates[j];
                            nearDates[j] = temp;

                            var temp2 = nearNames[i];
                            nearNames[i] = nearNames[j];
                            nearNames[j] = temp2;
                        }
                    }
                }

                for (int i = 0; i < nearDates.Length; i++)
                {
                    Console.WriteLine($"{nearNames[i]} - {nearDates[i]}");
                }

                Console.WriteLine();

                break;

            case "7":
                Console.Clear();
                var nearNames2 = new string[1];
                var nearDates2 = new DateTime[1];

                idx = 0;
                for (int i = 0; i < names.Length; i++)
                {
                    if (dates[i].DayOfYear < DateTime.Now.DayOfYear)
                    {
                        nearDates2[idx] = dates[i];
                        nearNames2[idx] = names[i];
                        idx++;
                        Array.Resize(ref nearDates2, nearDates2.Length + 1);
                        Array.Resize(ref nearNames2, nearNames2.Length + 1);

                    }
                }
                Array.Resize(ref nearDates2, nearDates2.Length - 1);
                Array.Resize(ref nearNames2, nearNames2.Length - 1);

                for (var i = 0; i < nearNames2.Length; i++)
                {
                    for (int j = i + 1; j < nearNames2.Length; j++)
                    {
                        if (nearDates2[i].DayOfYear < nearDates2[j].DayOfYear)
                        {
                            var temp = nearDates2[i];
                            nearDates2[i] = nearDates2[j];
                            nearDates2[j] = temp;

                            var temp2 = nearNames2[i];
                            nearNames2[i] = nearNames2[j];
                            nearNames2[j] = temp2;
                        }
                    }
                }

                for (int i = 0; i < nearDates2.Length; i++)
                {
                    Console.WriteLine($"{nearNames2[i]} - {nearDates2[i]}");
                }

                Console.WriteLine();

                break;

        }
    }

}

