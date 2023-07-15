string application = "{ApplicationDate} {ApplicationNumber} {OrganizationName} rektori " +
    "{Rektor}gaAbituriyent ${StudentName} danTel.: ${ StudentNumber}" +
    "ARIZA Men joriy yilda ${OrganizationName}ning ${Code}- ${ EduSpeciality}ta 'lim yo'nalishini " +
    "${ EduForm}ta 'lim shakli, ${EduLanguage} ta'lim tili bo'yicha ${OrderId} - OTM sifatida tanlab, " +
    "davlat test sinovida ishtirok etdim.Davlat test markazi tomonidan e'lon qilingan test natijasiga ko'ra " +
    "${Ball} ball to'pladim va to'lov-kontrakt asosidagi qabul chegarasiga " +
    "${DifferenceBall} ball yetmay qoldi .Shu munosabat bilan, meni qo'shimcha tarzda " +
    "${EduContractSumType} tabaqalashtirilgan to'lov-kontrakt asosida talabalikka qabul qilishingizni " +
    "hamda menga to`lov shartnomasini taqdim etishingizni so'rayman." +
    "Men Oliy ta'lim muassasasining ichki tartib qoidalari va kontraktni barcha shartlari bilan tanishib chiqdim " +
    "hamda tasdiqlangan o'quv rejasi bo'yicha belgilangan vaqtlarda darslarga qatnashishga, " +
    "belgilangan muddatlarda to'lov-kontrakt pulini to'lashga va to'lov hujjatlarini topshirishga " +
    "shaxsan o`zim mas'ulligimni tasdiqlayman.Abituriyent: ${ Abiturient}ID raqami: ${ AbiturientId}";

var date = DateTime.Now;
var changedInfo = application.Replace("{ApplicationDate}", $"{date}")
    .Replace("{ApplicationNumber}", $"{Guid.NewGuid()}")
    .Replace("{OrganizationName}", "Najot Ta'lim")
    .Replace("{Rektor}", "Adhamov Temur")
    .Replace("${StudentName}", "Abdurahmonov Azizbek")
    .Replace("${ StudentNumber}", "8679")
    .Replace("{Code}", "N10");
    

Console.WriteLine(changedInfo);