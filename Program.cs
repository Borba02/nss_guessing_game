using System;
Random RandomNumber = new Random();
int SecretNumber = RandomNumber.Next(1, 100);
int Chances = 4;
int AnswerCheck = 0;

Main();


void Main()
{
    for (int i = 0; i < Chances; i++)
    {
        GuessTheNumber("Hey Kid, you wanna guess my secret number?");
        UserSays();
        Console.WriteLine($"You have ({i + 1}) times");
        if (SecretNumber == AnswerCheck)
        {
            i = Chances;
        }
        Console.WriteLine($"You have ({Chances - 1 - i}) guesses remaining!");
    }
}


void UserSays()
{
    int Answer = int.Parse(Console.ReadLine());

    AnswerCheck = Answer;

    if (Answer == SecretNumber)
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

