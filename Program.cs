using System;

Main();


void Main()
{
    GuessTheNumber("Hey Kid, you wanna guess my secret number?");
    UserSays();

}


void UserSays()
{
    string Answer = Console.ReadLine();

    int ParsedAnswer = int.Parse(Answer);

    Console.WriteLine($"GG: Your guess is {ParsedAnswer}");
}

void GuessTheNumber(string message)
{
    Console.WriteLine($"GG: {message}");
}