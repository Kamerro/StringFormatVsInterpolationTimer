//Declaration of variables:
string result = String.Empty;
string OK = "OK";
string testowy = "testowy";
string napis = " napis";
DateTime now;
DateTime then;
TimeSpan span;

now = DateTime.Now;
for (int i = 0; i < 100000000; i++)
{
    result = $"{OK}{testowy}{napis}";
    //result = String.Format(OK, testowy, napis);
}
then = DateTime.Now;
span = then - now;
Console.WriteLine(span);
//Conclusion -> String interpolation is a little bit faster than String.Format