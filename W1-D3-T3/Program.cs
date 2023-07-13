using System.Xml;

var username = "Max";
var password = 12324;

var template = "Dear {0}\nWe would like to inform you, that your password was changed.\nYour new password is {1}\n\nSincrely\nABC Team";
var FormattedTemplate = String.Format(template, username, password);

Console.WriteLine(FormattedTemplate);