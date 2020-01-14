using System;

namespace Exercise1_20
{
    class Exercise20
    {
        public static void exercise()
        {
            Console.WriteLine("You can pay with Apples, Bananas, Lemons and Grapefruits!");
            Console.WriteLine("(Lemon = 20$");
            Console.WriteLine("(Bananas = 5$");
            Console.WriteLine("(Apples = 1$");
            Console.WriteLine("(Grapefruits = 0.10$");
            Console.WriteLine("How much money would you like to pay overall? (Type the amount in $): ");
            int userInput = int.Parse(Console.ReadLine());
            int lemon = 75;
            int banana = 20;
            int apple = 5;
            int grapefruit = 1;

            /*
            if ((sum % 20 == 0) && (sum % 5 == 0) && (sum % 1 == 0) && (sum % 0.1 == 0))
            {
                int priceLemon = sum / lemon;
                Console.WriteLine("It costs " + priceLemon + " lemons!");

            } else if ((sum % 5 == 0) && (sum % 1 == 0) && (sum % 0.1 == 0))
            {
                int priceBanana = sum / banana;
            } else if ((sum % 1 == 0) && (sum % 0.1 == 0))
            {
                int priceApple = sum / apple;

            } else if (sum % 0.1 == 0)
            {
                int priceGrapefruit = sum / grapefruit;
            } */

            int priceLemon = userInput % lemon;
            int priceBanana = priceLemon % banana;
            int priceApple = priceBanana % apple;
            int priceGrapefruit = priceApple / grapefruit;

            Console.WriteLine("Pay me " + priceLemon + "!");
            Console.WriteLine("Pay me " + priceBanana + "!");
            Console.WriteLine("Pay me " + priceApple + "!");
            Console.WriteLine("Pay me " + priceGrapefruit + "!");



        }
    }
}
