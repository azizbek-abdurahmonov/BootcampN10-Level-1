using N6_Task1;
using System.Net.Http.Headers;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  Age = 18,  EduType = "DotNET", Payment = 2_000_000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  Age = 20,  EduType = "Python", Payment = 2_500_00 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2_000_000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  Age = 16,  EduType = "SMM", Payment = 1_500_000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  Age = 17,  EduType = "Dizayn", Payment = 1_000_000 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  Age = 23,  EduType = "SMM", Payment = 1_500_000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  Age = 22,  EduType = "Dizayn", Payment = 1_000_000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  Age = 21,  EduType = "DotNET", Payment = 2_000_000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  Age = 19,  EduType = "Python", Payment = 2_500_000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  Age = 20,  EduType = "Dizayn", Payment = 1_000_000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  Age = 19,  EduType = "Python", Payment = 2_500_000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  Age = 16,  EduType = "DotNET", Payment = 2_000_000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  Age = 24,  EduType = "DotNET", Payment = 2_000_000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  Age = 21,  EduType = "Python", Payment = 2_500_000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  Age = 25,  EduType = "SMM", Payment = 1_500_000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  Age = 16,  EduType = "Dizayn", Payment = 1_000_000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  Age = 23,  EduType = "DotNET", Payment = 2_000_000 },
};
menu:
while (true)
{
    Console.WriteLine("1 - talabalar ro'yhati\n2 - to'lovlar");
    var chose = Console.ReadKey().KeyChar;
    switch (chose)
    {
        case '1':
            Console.Clear();
            var tanlov = "1 - DotNET\n2 - SMM\n3 - Python\n4 - Dizayn";
            Console.WriteLine(tanlov);
            while (true)
            {

                var choose = Console.ReadKey().KeyChar;

                switch (choose)
                {
                    case '1':
                        Console.Clear();
                        foreach (var item in student)
                        {
                            if (item.EduType.ToLower() == "dotnet")
                                Console.WriteLine($"{item.FullName} - {item.Age} - {item.EduType}");
                        }
                        Console.WriteLine("\n0 - ortga");
                        break;
                    case '2':
                        Console.Clear();
                        foreach (var item in student)
                            if (item.EduType.ToLower() == "smm")
                                Console.WriteLine($"{item.FullName} - {item.Age} - {item.EduType}");
                        Console.WriteLine("\n0 - ortga");

                        break;
                    case '3':
                        Console.Clear();
                        foreach (var item in student)
                            if (item.EduType.ToLower() == "python")
                                Console.WriteLine($"{item.FullName} - {item.Age} - {item.EduType}");
                        Console.WriteLine("\n0 - ortga");

                        break;
                    case '4':
                        Console.Clear();
                        foreach (var item in student)
                            if (item.EduType.ToLower() == "dizayn")
                                Console.WriteLine($"{item.FullName} - {item.Age} - {item.EduType}");
                        Console.WriteLine("\n0 - ortga");

                        break;
                    case '0':
                        Console.Clear();
                        goto menu;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Xato amal kiritildi!");
                        break;

                }
            }
        default: Console.Clear(); Console.WriteLine("Noto'g'ri amal!"); break;
    }
}
