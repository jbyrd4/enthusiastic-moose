using System;
using System.Collections.Generic;


Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    var CanadaQuestion = new List<string>()
            {
                "Is Canada real?",
                "Really? It seems very unlikely.",
                "I  K N E W  IT !!!"
            };

    var EnthusiasticQuestion = new List<string>()
            {
                "Are you enthusiastic?",
                "Yay!",
                "You should try it!"
            };

    var LoveCSharpQuestion = new List<string>()
            {
                "Do you love C# yet?",
                "Good job sucking up to your instructor!",
                "You will...oh, yes, you will..."
            };

    var SecretQuestion = new List<string>()
            {
                "Do you want to know a secret?",
                "ME TOO!!! I love secrets...tell me one!",
                "Oh, no...secrets are the best, I love to share them!"
            };

    AskQuestion(CanadaQuestion[0], CanadaQuestion[1], CanadaQuestion[2]);
    AskQuestion(EnthusiasticQuestion[0], EnthusiasticQuestion[1], EnthusiasticQuestion[2]);
    AskQuestion(LoveCSharpQuestion[0], LoveCSharpQuestion[1], LoveCSharpQuestion[2]);
    AskQuestion(SecretQuestion[0], SecretQuestion[1], SecretQuestion[2]);

}


void AskQuestion(string question, string yes, string no)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(yes);
    }
    else
    {
        MooseSays(no);
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N: ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}