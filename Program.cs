using System;
using System.Collections.Generic;

//Get User Input and read it: Welcome the user to the game. Make all input idiot, fucking proof. Even a child should be able to play this.
//Print Greeting to the user using their input.

//Have the user consent to the terms of the game, and if they do not consent, ask again. And Again. And Again. There is no escape, sorry bud.

//Set a random number using a random number dingseboms, and the user should guess it. 
//if the person is within 50+/- of the correct answer, give the player a new chance. 
//If the person is not within 50 of the correct answer, do pelt that user down as if it were thrown to the ground. And obviously, end the game.
//if the person is correct, end the game and congratulate the player. 





namespace macroHardest
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = GetUserInput();
            getConsent(userName);
            buttWopen();
        }

        static string GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Hey! Welcome to buttwipe throwing services! Write down yo name, lad or lass... ");
                string? userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Hello, " + userInput);
                    return userInput;
                }
                else
                {
                    Console.WriteLine("You need to type in your name, ye buttwipe.");
                }
            }
        }

        static void getConsent(string userName)
        {
            while (true)
            {
                Console.WriteLine("Do you consent to have a buttwipe being thrown at you? ");
                string? buttWipe = Console.ReadLine();
                if (!string.IsNullOrEmpty(buttWipe))
                {
                    string buttWiped = buttWipe.ToLower();
                    if (buttWiped == "yes" || buttWiped == "y" || buttWiped == "ye")
                    {
                        Console.WriteLine("You sir, or miss are a sigma! Let the betas play too!");
                        return;
                    }
                    else if (buttWiped == "leave" || buttWiped == "leav" || buttWiped == "leve" || buttWiped == "lev")
                    {
                        Console.WriteLine($"Shit {userName}, you suck...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You are a buttwipe. Really out here sayin' \"" + buttWiped + "\"! At this point, just leave yikes. Or be a real riska.");
                    }
                }
                else
                {
                    Console.WriteLine("Input cannot be shit, like you. Just try again, breh.");
                }
            }
        }

        static void buttWopen()
        {
            Random rnd = new Random();
            int userGottaGuess = rnd.Next(1, 1025);
            Console.WriteLine("Guess a number between 1 and 1024. There is a chance you will get a buttwipe thrown at you.");
            Console.WriteLine(userGottaGuess); // Can hide this behind a comment. I keep this on to make it easier to troubleshoot.
            int neededToGuess = Convert.ToInt32(Console.ReadLine());
            List<string> weirdoButtWipes = new List<string>
            {
                "a 68 year old drunkard", "a 3 year old toddler who just ate tacos", "a 12 year old who just ate a whole bag of sugar", "an idiot who just had a spicy chicken meal", "diarrhoea-attacked person", "me"
            };
            int weirdoButtWipesRandomized = rnd.Next(0, weirdoButtWipes.Count);

            if (userGottaGuess == neededToGuess)
            {
                Console.WriteLine("You are absolutely right, you won the game. Congratulations!");
            }
            else if (neededToGuess >= userGottaGuess - 50 && neededToGuess <= userGottaGuess + 50)
            {
                Console.WriteLine("Sheit. Success-ish. You won't get pelted down... For now!");
            }
            else
            {
                Console.WriteLine("You were pelted with the nastiest buttwipe from a: " + weirdoButtWipes[weirdoButtWipesRandomized]);
            }
        }
    }
}
