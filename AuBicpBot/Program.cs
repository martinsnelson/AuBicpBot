using System;
using AuBicpBot.Controllers;

namespace AuBicpBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.Engage(args);
        }

        static class Startup
        {
            static public void Engage(string[] args)
            {
                new AuBicpBotController(args);
            }
        }
    }
}
