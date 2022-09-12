// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, who are you?");
// string name = Console.ReadLine();
// Console.WriteLine("Hello, " + name + " how are you?");
// string feeling = Console.ReadLine();
// if (feeling.Contains("good"))
// {
//     Console.WriteLine("Good " + feeling);
// }
// else Console.WriteLine("Umama");

bool play = false;

Console.WriteLine("Hello, let's have a quick meet");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
if (name.Contains("Sicco"))
{
    for (int i = 0; i < 4; i++)
    {
        System.Threading.Thread.Sleep(1300);
        Console.WriteLine("You have no power here!!!");
    }

    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("ERROR, FATAL CRASH");
    return;
}
else if (name.Contains("Tim"))
{
    Console.WriteLine("You challanged Faker to a 1v1");
    for (int i = 0; i < 4; i++)
    {
        System.Threading.Thread.Sleep(1300);
        Console.WriteLine("GG EZ, Bttr luk nxt time boyt");
    }
    Console.WriteLine("You died");
    return;
}
else Console.WriteLine("Hello, " + name + "!");
Console.WriteLine("Are you in for a mathquizeroonie?");
string answer0 = Console.ReadLine();

if (answer0.Contains("no"))
{
    Console.WriteLine("Your answer was: " + answer0);
    Console.WriteLine("Bye bish");
    return;
}
else if (answer0 == ("yes"))
{
    play = true;
    Console.WriteLine("Perfect, your answer was: " + answer0 + "! Lets get this party started ");
}
else
{
    Console.WriteLine("twat");
    return;
}

if(play = true)
{
    Console.WriteLine("Question 1:");
    Console.WriteLine("What is 1+0?");
    string answer1 = Console.ReadLine();

    if (answer1 == ("1"))
    {
        Console.WriteLine("You are correct!");
    }
    else
    {
        Console.WriteLine("You should work on ur math bro");
    }

    Console.WriteLine("Question 2:");
    Console.WriteLine("What is 2+2?");
    string answer2 = Console.ReadLine();

    if (answer2 == ("fish"))
    {
        Console.WriteLine("You are correct!");
    }
    else if (answer2 == ("4"))
    {
        Console.WriteLine("WRONG");
        Console.WriteLine("Think outside the box man");
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    Console.WriteLine("Quetsion 3:");
    Console.WriteLine("What is 3+3?");
    string answer3 = Console.ReadLine();

    if (answer3 == ("8"))
    {
        Console.WriteLine("You are correct!");
    }
    else if(answer3 == ("6"))
    {
        Console.WriteLine("WRONG");
        Console.WriteLine("Com'on I told you to think outside the box");
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    Console.WriteLine("Question 4:");
    Console.WriteLine("What is 1+1?");
    string answer4 = Console.ReadLine();

    if (answer4 == ("triangle"))
    {
        Console.WriteLine("You are correct!");
    }
    else if (answer4 == ("2"))
    {
        Console.WriteLine("WRONG");
        Console.WriteLine("You should know by now...");
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    Console.WriteLine("Question 5:");
    Console.WriteLine("What is 2+2?");
    string answer5 = Console.ReadLine();

    if (answer5 == ("4"))
    {
        Console.WriteLine("You are correct!");
    }
    else if (answer5 == ("fish"))
    {
        Console.WriteLine("WRONG");
        Console.WriteLine("Thought you had this one...");
    }
    else
    {
        Console.WriteLine("WRONG");
    }

    Console.WriteLine("I hope you had fun solving this small quiz " + name);
    Console.WriteLine("I will forever be your friend " + ":)");
}