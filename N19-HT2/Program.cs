using N19_HT2;

var values = new int[] { 5, 1, 7, 3, 12, 41, 51 };
Console.WriteLine(AggregationService.Sum(values));
Console.WriteLine(AggregationService.Average(values));
Console.WriteLine(AggregationService.Max(values));
Console.WriteLine(AggregationService.Min(values));


var n1 = 6;
Console.Write($"oldin: {n1}, ");
AggregationService.Increment(ref n1);
Console.WriteLine("Incrementdan keyin: " + n1);
AggregationService.Decrement(ref n1);
Console.WriteLine("Decrementdan keyin: " + n1);

var n2 = int.MaxValue;
Console.Write($"oldin: {n2}, ");
AggregationService.Increment(ref n2);
Console.WriteLine("Incrementdan keyin: " + n2);
AggregationService.Decrement(ref n2);
Console.WriteLine("Decrementdan keyin: " + n2);

var n3 = -10;
Console.Write($"oldin: {n3}, ");
AggregationService.Increment(ref n3);
Console.WriteLine("Incrementdan keyin: " + n3);
AggregationService.Decrement(ref n3);
Console.WriteLine("Decrementdan keyin: " + n3);

var n4 = int.MinValue;
Console.Write($"oldin: {n4}, ");
AggregationService.Increment(ref n4);
Console.WriteLine("Incrementdan keyin: " + n4);
AggregationService.Decrement(ref n4);
Console.WriteLine("Decrementdan keyin: " + n4);
