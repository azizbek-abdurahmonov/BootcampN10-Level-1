////N10 task 1
//Console.Write("Enter your age: ");
//var age = Convert.ToInt32(Console.ReadLine());

//try
//{
//    var res = age switch
//    {
//        < 18 => throw new ArgumentOutOfRangeException("Sorry you're too young"),
//        > 90 => throw new ArgumentOutOfRangeException("Sorry you are too old"),
//        _ => "Valid age",
//    };
//    Console.WriteLine(res);
//}
//catch (ArgumentOutOfRangeException exception)
//{
//    Console.WriteLine(exception.Message.ToString());
//}




//// N10 Task 2

//var rd = new Random();
//var randomNumber = rd.Next(1, 11);

//while (true)
//{
//    try
//    {
//        Console.WriteLine("Enter a number: ");
//        var number = Console.ReadLine();
//        if (int.TryParse(number, out int num))
//        {
//            if (num == randomNumber)
//            {
//                Console.WriteLine("Congrat's");
//                break;

//            }
//            else
//                throw new ArgumentOutOfRangeException("Xato", "You couldn't guess");
//        }
//        else
//        {
//            throw new FormatException("Not a numer");
//        }

//    }
//    catch (ArgumentOutOfRangeException exception)
//    {
//        Console.WriteLine(exception.Message);
//    }
//    catch (FormatException exception)
//    {
//        Console.WriteLine(exception.Message);
//    }

//}