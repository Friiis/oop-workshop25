using System;
using Domain;
namespace Presentation;

    class LogIn
    {
        //


        public User SelectUser(User[] userOptions)
        {
            Console.WriteLine("Select User type:");
            for (int i = 0; i < userOptions.Length; i++)
            {
                Console.WriteLine((i) + ") " + userOptions[i].GetType());
            }

            while(true)
            {
                string? userInput = Console.ReadLine();
                if (userInput == null || userInput.Length > 1)
                {
                    continue;
                }

                if (int.TryParse(userInput, out int selection))
                {
                    if (selection >= userInput.Length || selection < 0)
                    {
                        continue;
                    }

                    return userOptions[selection];

                }

            }






        }

    }