using N28_HT2.Models;

var clonableList = new ClonableList<StorageFile>
{
    new StorageFile("first", "first desc", 105),
    new StorageFile("second", "second desc", 156),
    new StorageFile("thrist", "thrist desc", 45),
};

var clonedList = (ClonableList<StorageFile>)clonableList.Clone();

//update
var firstItem = clonableList.First();
firstItem.Description = "Other description ";

// clone listni elementlarini chiqarish
clonedList.ForEach(Console.WriteLine);
