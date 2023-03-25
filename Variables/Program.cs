using System.Xml;

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument(); // C# 3 and later
XmlDocument xml2 = new XmlDocument(); // all C# versions

// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");