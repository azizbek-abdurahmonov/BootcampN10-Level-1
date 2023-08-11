var aggregator = null as ICollectionAggregator;
aggregator = new CollectionAggregator();

var listA = new List<int>
{
    1, 2, 3
};

var listB = new List<int>
{
    2, 4, 5
};

Console.WriteLine("Concat result: ");
aggregator.Concat(listA, listB).ToList().ForEach(Console.WriteLine);

Console.WriteLine("Intersect result: ");
aggregator.Intersect(listA, listB).ToList().ForEach(Console.WriteLine);

Console.WriteLine("Except result: ");
aggregator.Except(listA, listB).ToList().ForEach(Console.WriteLine);

Console.WriteLine("Union result: ");
aggregator.Union(listA, listB).ToList().ForEach(Console.WriteLine);


public interface ICollectionAggregator
{
    List<T> Concat<T>(in List<T> listA, in List<T> listB);
    List<T> Intersect<T>(in List<T> listA, in List<T> listB);
    List<T> Except<T>(in List<T> listA, in List<T> listB);
    List<T> Union<T>(in List<T> listA, in List<T> listB);

}

public class CollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        list.AddRange(listA);
        list.AddRange(listB);

        return list;
    }

    public List<T> Except<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();

        foreach (var item in listA)
            if (!(listB.Contains(item)))
                list.Add(item);
        return list;
    }

    public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();

        foreach (var item in listA)
            if (listB.Contains(item))
                list.Add(item);

        return list;

    }

    public List<T> Union<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();

        foreach (var item in Concat(listA, listB))
            if (!list.Contains(item))
                list.Add(item);

        return list;
    }
}