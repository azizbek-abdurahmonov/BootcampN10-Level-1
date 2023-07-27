DateTime birinchiSana = new DateTime(2023, 7, 27);
DateTime ikkinchiSana = new DateTime(2023, 7, 30);
TimeSpan farq = ikkinchiSana - birinchiSana;
Console.WriteLine("Ikki sana orasidagi farq: " + farq.TotalMinutes + " kun");
