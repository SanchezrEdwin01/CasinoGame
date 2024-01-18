//Casino Game this is a jack game made in c#
//author: Edwin Sanchez, email: sanchez797.edwin@gmail.com, github user: SanchezrEdwin01

var tokensAvailables = 0;
var firstChoiceString = "";
var firstChoice = 0;
var whileCorrect = false;
var wannaContinuePlay = true;

while (wannaContinuePlay)
{
    Console.WriteLine("Welcone to 21 game");
    Console.WriteLine("You´re gonna need some tokens for playing");

    while (!whileCorrect)
    {
        Console.WriteLine("Do you wanna buy some tokens? \n Press 1 for going store and buy tickes or press 0 for exit");
        firstChoiceString = Console.ReadLine();

        if (firstChoiceString == "1" || firstChoiceString == "0")
        {
            whileCorrect = true;
            firstChoice = int.Parse(firstChoiceString);
        }
        else
        {
            whileCorrect = false;
            Console.WriteLine("That´s not an option, choose again");
        }
    }

    if (firstChoice == 1)
    {

    }
    else
    {
        wannaContinuePlay = false;
    }

    //tokensAvailables =
}

