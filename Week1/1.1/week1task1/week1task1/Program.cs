using System;

namespace week1task1
{
    class Program
    {
        static void Main(string[] args)
        {
            message[] message = new message[5];
            message[0] = new message("Welcome back oh great educator!");
            message[1] = new message("What a lovely name");
            message[2] = new message("Great name");
            message[3] = new message("This name is God!");
            message[4] = new message("That is a silly name");

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            if (name.ToLower() == "shamara")
            {
                message[0].print(); //calls the print function in the Message Class
            }
            else if (name.ToLower() == "john")
            {
                message[1].print();
            }
            else if (name.ToLower() == "keane")
            {
                message[2].print();
            }
            else if (name.ToLower() == "gam")
            {
                message[3].print();
            }
            else
            {
                message[4].print();
            }
        }
    }
}
