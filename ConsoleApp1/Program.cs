using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\nThe Fortune Teller\n");
            Console.WriteLine("\n\nPress enter to begin\n\n");
            Console.WriteLine("\nHow old are you?\n");
            string Age = Console.ReadLine();
            int Agenum = Convert.ToInt32(Age);

            Console.WriteLine("\nWhat's your First Name?\n");
            string First = Console.ReadLine();
            Console.WriteLine("\nAndddd your Last Name?\n");
            string Last = Console.ReadLine();


            Console.WriteLine("\nfavoriteeee color???\n");
            Console.WriteLine("\n 1-black, 2- indigo, 3- blue, 4-red, 5-orange 6-yellow");
            string Roy = Console.ReadLine();
            int RoyNum = Convert.ToInt32(Roy);

            Console.WriteLine("\nwhat month where you born in? \n");
            Console.WriteLine(" in 00 format please, exp. 01 is Janurary");
            String date = Console.ReadLine();
            int datenum = Convert.ToInt32(date);

            string ageGroup = "";
            string colorGroup = "";
            string month = "";

            Console.WriteLine("\nAlrightyyyy.... Downloading infooooo.....\n");
            Console.ReadLine();
            Console.WriteLine("\ni got it, i got it, calm down.\n");
            Console.WriteLine("\nPress enter to begin.\n");
            Console.ReadLine();


            Console.Clear();
            Console.WriteLine("\nso to begin, your readings are telling me youre a ....\n");
            Console.ReadLine();
            Console.WriteLine("\nbitch lol just playing dude dont get defensive :p\n");


            if (Agenum >= 20 && Agenum <= 26)
            {
                ageGroup = " broke Gen-Z's who 'talk a lot and don't get anything because they're broke";
            }
            else if (Agenum >= 40)
            {

                ageGroup = " rich boomer";
            }
            else if (Agenum >= 27 && Agenum <= 39)
            {
                ageGroup = " just as broke millennial";
            }
            else
            {
                ageGroup = " cracked, ya supergenius.";
            }
            if (datenum == 11)
            {
                month = " a turkey";
            }
            else if (datenum >= 04 && datenum <= 07)
            {
                month = " hot, and hot-headed";
            }
            else if (datenum >= 08 && datenum <= 10)
            {
                month = " cozy but spooky";
            }
            else
            {
                month = " cold hearted, like the weather outside";
            }
            if (RoyNum <= 3)
            {
                colorGroup = " deep and mysterious";
            }
            else if (RoyNum == 4 && RoyNum == 5)
            {
                colorGroup = " bright and peachy";
            }
            else
            {
                colorGroup = " Open but down-to-earth";
            }

            Console.Clear();

            Console.WriteLine("well well " + (First) + " " + (Last));
            Console.ReadLine();


            Console.WriteLine("\n\n I know that you're " + ageGroup + "\n");
            Console.ReadLine();

            Console.WriteLine("\n\n Basing my info on when you were born, " + month + "\n");
            Console.ReadLine();

            Console.WriteLine("\n\n and lastly you're " + colorGroup + "\n");
            Console.ReadLine();

            Console.WriteLine(" I know my predictions are always 100% spot on, thank you come again.");
        }
    }
}
