string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fish", "hamsters" };
string[] caracters = { "Peter", "Stephanie" };

PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(caracters);
static void PrintArrayElements(string[] someArry)
{
    for (int i = 0; i < someArry.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {someArry[i]}");
    }
}