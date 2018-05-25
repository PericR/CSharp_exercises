using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11RandomMessage
{
    public static class RandomMessage
    {
        private static string[] laudatoryPhrases =
        {
            "The product is excellent.",
            "This is a great product.",
            "I use this product constantly.",
            "This is the best product from this category."
        };

        private static string[] laudatoryStories = 
        {
            "Now I feel better.",
            "I managed to change.",
            "It made some miracle.",
            "I can’t believe it, but now I am feeling great.",
            "You should try it, too. I am very satisfied."
        };

        private static string[] firstName = { "Dayan", "Stella", "Hellen", "Kate" };
        private static string[] lastName = { "Johnson", "Peterson", "Charls" };
        private static string[] cityes = { "London", "Paris", "Berlin", "New York", "Madrid" };

        public static string MakeRandomMessage()
        {
            Random rand = new Random();
            string message = laudatoryPhrases[rand.Next(0, 4)];
            message = message + " " + laudatoryStories[rand.Next(0, 5)];
            message = message + "--" + firstName[rand.Next(0, 4)];
            message = message + " " + lastName[rand.Next(0, 3)];
            message = message + ", " + cityes[rand.Next(0, 5)];

            return message;
        }
    }
}
