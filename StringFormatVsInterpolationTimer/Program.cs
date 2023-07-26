//Declaration of variables:
using System.Diagnostics;
using System.Text;

string result = String.Empty;
string OK = "OK";
string testowy = "testowy";
string napis = " napis";
StringBuilder sb = new(); 
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i < 10000; i++)
{
    //result += $"{i}"; //40 ms
    //result += i.ToString(); //33 ms
    sb.AppendLine(i.ToString()); // 0.3 ms

}
sb.ToString();
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
//Conclusion -> String interpolation is a little bit faster than String.Format