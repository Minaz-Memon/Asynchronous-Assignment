// See https://aka.ms/new-console-template for more information
using System.Text;

var path="C:/Promact/Training/C-Sharp/AsyncAssgn/A.txt";

using var fs = new FileStream(path,FileMode.Open, FileAccess.Read);
using var sr = new StreamReader(fs, Encoding.UTF8);

string content = await sr.ReadToEndAsync();
System.Console.WriteLine(content);

var path1 = "C:/Promact/Training/C-Sharp/AsyncAssgn/B.txt";
await File.WriteAllTextAsync(path1,content);
System.Console.WriteLine(File.ReadAllText("B.txt"));