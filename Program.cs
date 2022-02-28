using System;
Random randomNumber = new Random();
int secretNumber = randomNumber.Next(1, 3);
int chances = 4;
int answerCheck = 0;

Main();


void Main()
{
    for (int i = 0; i < chances; i++)
    {
        GuessTheNumber("Hey, you wanna guess the secret number? (1-100)");
        UserSays();
        Console.WriteLine($"You have guessed ({i + 1}) times");
        if (secretNumber == answerCheck)
        {
            i = chances;
        }
        else
        {
            Console.WriteLine($"You have ({chances - 1 - i}) guesses remaining!");
        }
    }
}


void UserSays()
{
    int UserAnswer = int.Parse(Console.ReadLine());

    answerCheck = UserAnswer;

    if (UserAnswer == secretNumber)
    {
        Console.WriteLine("GG: You guessed right!");
    }
    else
    {
        if (secretNumber > UserAnswer)
            Console.WriteLine("GG: You guessed too low!");
        else
        {
            Console.WriteLine("GG: You guessed too high!");
        }

    }

}

void GuessTheNumber(string message)
{
    Console.WriteLine("'''''''''''''''''''''''''''''");
    Console.WriteLine($"GG: {message}");
}


