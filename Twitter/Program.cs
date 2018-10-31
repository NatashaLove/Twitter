using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = null;
            Console.WriteLine("Hello, write your message (140 characters):");
            message= Console.ReadLine();

            while (message.Length>140)
            {
                Console.WriteLine("Your message is too long, try again.");
                message = Console.ReadLine();
            }
           
            {
                Console.WriteLine("Your message is:");
                Console.WriteLine(message);
            }
            Console.ReadLine();

        }
    }
}
