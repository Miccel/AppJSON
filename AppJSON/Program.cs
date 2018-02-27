using System;
using System.Collections.Generic;
using AppJSON.ExtendedMethods;
using AppJSON.Components;

namespace AppJSON
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Generatore Universale file JSON by Michele \"Miccel\" Maresca");
            JSON json;
            Card c1 = new Card("Due di Bastoni", 2, 0);
            json = new JSON("card.json", c1);
            json.Read();
            json.PrintJSON();
            Console.ReadLine();
        }
    }
}
