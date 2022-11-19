// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while (true)
{
    var key = Console.ReadKey();

    Console.WriteLine(key.Key);
    Console.WriteLine(key.KeyChar);
    Console.WriteLine(key.Modifiers);
}


