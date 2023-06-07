using NextCodeChallnge;
Console.ForegroundColor = ConsoleColor.DarkGreen;


var fizzBuzz = new FizzBuzzSolution();

Console.WriteLine("----------------------------------FizzBuzz, first solution----------------------------------------");
Console.WriteLine(fizzBuzz.PrintFizzBuzz(0));
Console.WriteLine(fizzBuzz.PrintFizzBuzz(1));
Console.WriteLine(fizzBuzz.PrintFizzBuzz(2));
Console.WriteLine(fizzBuzz.PrintFizzBuzz(3));
Console.WriteLine(fizzBuzz.PrintFizzBuzz(5));
Console.WriteLine(fizzBuzz.PrintFizzBuzz(15));


Console.WriteLine("----------------------------------FizzBuzz, secound solution----------------------------------------");
Console.WriteLine(fizzBuzz.PrintFizzBuzz_SecondWay(0));
Console.WriteLine(fizzBuzz.PrintFizzBuzz_SecondWay(1));
Console.WriteLine(fizzBuzz.PrintFizzBuzz_SecondWay(2));
Console.WriteLine(fizzBuzz.PrintFizzBuzz_SecondWay(3));
Console.WriteLine(fizzBuzz.PrintFizzBuzz_SecondWay(5));
Console.WriteLine(fizzBuzz.PrintFizzBuzz_SecondWay(15));



var socialRecipient = new SocialRecipientSolution();
var message = "@User_One @UserABC! Have you seen this from @Userxyz?";
Console.WriteLine("------------------------------------------Social recipient, using regex--------------------------------");

Console.WriteLine(socialRecipient.GetRecipient_UsingRegx(message, 1));
Console.WriteLine(socialRecipient.GetRecipient_UsingRegx(message, 2));
Console.WriteLine(socialRecipient.GetRecipient_UsingRegx(message, 3));
Console.WriteLine(socialRecipient.GetRecipient_UsingRegx(message, 4));


Console.WriteLine("------------------------------------------Social recipient, using while--------------------------------");

Console.WriteLine(socialRecipient.GetRecipient_UsingWhile(message, 1));
Console.WriteLine(socialRecipient.GetRecipient_UsingWhile(message, 2));
Console.WriteLine(socialRecipient.GetRecipient_UsingWhile(message, 3));
Console.WriteLine(socialRecipient.GetRecipient_UsingWhile(message, 4));
