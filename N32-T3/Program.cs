var service = ProductService.GetInstance();

var obj1 = service.Add("Nimadir", "qanaqadir");
var obj2 = service.Add("Nimadir2", "qanaqadir2");
service.Clone(obj1.Id);
service.Display();