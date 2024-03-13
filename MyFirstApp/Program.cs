//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervutab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation

Console.WriteLine($"Hello, {userName}!");
