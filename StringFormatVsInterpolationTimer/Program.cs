//Declaration of variables:
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

string result = String.Empty;
string OK = "OK";
string testowy = "testowy";
string napis = " napis";
StringBuilder sb = new(); 
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i < 5000000; i++)
{
    result += $"{i}"; // ?? longer than minute
   // result += i.ToString(); //?? longer than minute
   // result = String.Format(result, i); // 150ms
   // sb.Append(i.ToString()); // 180 ms

}
//sb.ToString();
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
//Conclusion -> String interpolation is a little bit faster than String.Format