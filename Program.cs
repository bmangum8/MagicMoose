using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Magic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

MooseSays("What is your question?");
UserAsks();
}




//void means method will not return anything
//string sets a const and says the value will be in the form of a string
void MooseSays(string message)
{
    //We add an @ in front of the string to allow for a multi-line string.
    //$ enables string interpolation
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
}



void UserAsks()
{
    Console.WriteLine("Type your question here: ");
    string answer = Console.ReadLine().ToLower();

    if ((answer.StartsWith("will")) || (answer.StartsWith("do")) || (answer.StartsWith("does")))
    {
        MooseSays("This is my answer");
    }
    else
    {
        MooseSays("Can you ask me a different question?");
    }
}







/*
public class RandomNumberGenerator {
   public static void Main() {
      Random r = new Random();
      int genRand= r.Next(10,50);
      Console.WriteLine("Random Number = "+genRand);
   }
}
*/


