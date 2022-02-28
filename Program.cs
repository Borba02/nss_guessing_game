using System;

int SecretNumber = 42;
int Chances = 4;

Main();


void Main()
{
    for (int i = 0; i < Chances; i++)
    {
        GuessTheNumber("Hey Kid, you wanna guess my secret number?");
        UserSays();
    }
}


void UserSays()
{
    string Answer = Console.ReadLine();

    int ParsedAnswer = int.Parse(Answer);

    if (ParsedAnswer == SecretNumber)
    {
        Console.WriteLine("GG: You guessed right! Here's some candy");
    }
    else
    {
        Console.WriteLine("GG: You guessed wrong! Here's some candy");
    }
}

void GuessTheNumber(string message)
{
    Console.WriteLine($"GG: {message}");
}

