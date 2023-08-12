var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 665, 13, 65, 1, 6, 24, 13, 65 };

// var result = numbers.Take(5); // birinchi 5 ta elementni olib beradi


// var result = numbers.Skip(12); // birinchi 12 ta elementni olib tashlaydi



result.ToList().ForEach(Console.WriteLine);