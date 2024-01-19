//Casino Game this is a jack game made in c#
//author: Edwin Sanchez, email: sanchez797.edwin@gmail.com, github user: SanchezrEdwin01

using System.Text.RegularExpressions;

var tokensAvailables = 0;
var tokensAvailablesStr = "";
var firstChoiceString = "";
var firstChoice = 0;
var whileCorrect = false;
var wannaContinuePlay = true;
var wannaContinue = true;
var userAnswer = "";
const String OnlyNumbers = @"^\d+$";
var userCard = 0;
var totalusersCards = 0;
var totalDealer = 0;

while (wannaContinuePlay)
{
    Console.WriteLine("Welcone to 21 game");
    Console.WriteLine("You´re gonna need some tokens for playing");
    whileCorrect = false;

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
        whileCorrect = false;

        while (!whileCorrect)
        {
            Console.WriteLine("How mamy tokens do you want? You´re gonna need one token for each game");
            tokensAvailablesStr = Console.ReadLine();

            Regex regex = new Regex(OnlyNumbers);

            Match match = regex.Match(tokensAvailablesStr);

            if (match.Success)
            {
                whileCorrect = true;
                tokensAvailables = int.Parse(tokensAvailablesStr);
            }
            else
            {
                Console.WriteLine("Thast´s not a number, choose again");
            }
        }

        for (int i = 0; i < tokensAvailables; i++)
        {
            whileCorrect = false;

            while (!whileCorrect)
            {
                Console.WriteLine($"Welecome to 21, your tokens availables: {tokensAvailables}");

                Console.WriteLine("Do you want to start a game? yes/no");

                userAnswer = Console.ReadLine().ToLower().Replace(" ", "");

                if (userAnswer == "yes" || userAnswer == "no")
                {
                    whileCorrect = true;
                }
                else
                {
                    Console.WriteLine("That´s not an option, please choose againg");
                }
            }

            if (userAnswer == "yes")
            {
                Random random = new Random();

                while (wannaContinue)
                {
                    userCard = random.Next(0, 11);
                    whileCorrect = false;

                    Console.WriteLine($"Here´s your card, your car is {userCard}");
                    totalusersCards = totalusersCards + userCard;

                    while (!whileCorrect)
                    {
                        Console.WriteLine("Do you want another card? yes/no");

                        userAnswer = Console.ReadLine().ToLower().Replace(" ", "");

                        if (userAnswer == "yes" || userAnswer == "no")
                        {
                            whileCorrect = true;
                        }
                        else
                        {
                            whileCorrect = false;
                        }
                    }

                    if (userAnswer == "yes")
                    {
                        wannaContinue = true;
                    }
                    else
                    {
                        totalDealer = random.Next(15, 24);
                        Console.WriteLine($"Your total is {totalusersCards} and the dealer´s total is {totalDealer}");

                        if ((totalusersCards > totalDealer && totalusersCards <= 21) || totalDealer > 21 && totalusersCards < 21)
                        {
                            Console.WriteLine("You won, bravooooooooo!");
                        }
                        else
                        {
                            Console.WriteLine("La casa siempre gana");
                        }
                        break;
                    }
                }

            }
        }

    }
    else
    {
        wannaContinuePlay = false;
    }

    //tokensAvailables =
}

