string hello = "Hello, world!";
string panic = "Dont`t panic!";

PrintSringFiveTimes(hello);
PrintSringFiveTimes(panic);
PrintSringFiveTimes("Mart");

static void PrintSringFiveTimes(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);
    }
}