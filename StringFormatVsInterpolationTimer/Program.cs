//Declaration of variables:
using System.Diagnostics;

string result = String.Empty;
string OK = "OK";
string testowy = "testowy";
string napis = " napis";
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i < 100000000; i++)
{
    //result = $"{OK}{testowy}{napis}";
    result = String.Format(OK, testowy, napis);
}
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
//Conclusion -> String interpolation is a little bit faster than String.Format