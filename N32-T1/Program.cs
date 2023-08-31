using System.Threading.Channels;
using N32_T1;

var o1 = new ShortenedLink("abdurahmonov", "abdura");
var o2 = new ShortenedLink("abdurahmonov", "abdura");

Console.WriteLine(o1.Equals(o2));