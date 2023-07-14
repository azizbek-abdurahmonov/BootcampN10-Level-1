var text = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. " +
    "Excepturi error dolore magnam ratione quasi voluptatum reiciendis tenetur cum. " +
    "Ut et, maxime iusto quibusdam aperiam perspiciatis perferendis amet debitis, " +
    "repellat natus sint aliquam minus! Voluptatum, libero praesentium cum ipsa, ducimus blanditiis, " +
    "necessitatibus dignissimos fugit commodi a officiis doloremque laboriosam! Nulla reiciendis, " +
    "ex praesentium aperiam veritatis sit laboriosam. Ratione soluta pariatur dolores rerum consequuntur. ";

var name = "AzIZbEk";
var capitalized = string.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
//Console.WriteLine(capitalized);


var words =  text.Split(' ');
var joinedString = string.Join(" ", words);
//Console.WriteLine(joinedString);

//Comparision and Equality
//for object
var objectA = (object)10;
var objectB = (object)10;

Console.WriteLine("OBJECT COMPARISION");
Console.WriteLine(objectA == objectB); // reference
Console.WriteLine(objectA.Equals(objectB)); //value
Console.WriteLine(object.Equals(objectA, objectB)); // value
Console.WriteLine(object.ReferenceEquals(objectA, objectB));
Console.WriteLine("----------------------------------------------");

var strA = "salom";
var strB = "SaLom";

Console.WriteLine(strA == strB); //value
Console.WriteLine(strA.Equals(strB)); //value
Console.WriteLine(string.Equals(strA, strB)); //value
Console.WriteLine(string.ReferenceEquals(strA, strB)); //reference

Console.WriteLine();

Console.WriteLine(strA.Equals(strB, StringComparison.OrdinalIgnoreCase));

var nameB = "{{firstname}}";
var username = "{{username}}";

var template = $"Dear {{firstname}},\nYour username is {{username}}";
var firsT = template.Replace("{{firstname}}", "Azizbek")
    .Replace("{{username}}", "abdura");

Console.WriteLine(firsT);