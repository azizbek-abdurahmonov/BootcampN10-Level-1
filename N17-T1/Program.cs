using N17_T1;

var service = new EmailTemplateService();
service.Add("Account Registration", "Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi");
service.Add("Account Blocked", "Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi");


Console.WriteLine(service.GetRegistrationTemplate("Habiba", "sattorovahabiba00@gmail.com"));