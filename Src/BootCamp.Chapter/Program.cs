using BootCamp.Chapter.Items;
using System;
namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var Head = new Headpiece("Helmet", 10, 10, 10, 10);
            var Shoulder = new Shoulderpiece("ShoulderPads", 5, 5, 5, 5);
            var Chest = new Chestpiece("ChestPads", 50, 50, 50, 50);
            var Gloves = new Gloves("Plastic Glove", 2, 2, 2, 2);
            var Leg = new Legspiece("LegPads", 25, 25, 25, 25);
            var arm = new Armpiece("ArmPads", 5, 5, 5, 5);
           
            var Player1 = new Player(7);
            Player1.Equip(Head);
            Player1.Equip(Shoulder, true);
            Player1.Equip(arm, true);
            Player1.Equip(Chest);
            Player1.Equip(Gloves);
            Player1.Equip(Leg);
            Console.WriteLine($"Total Attack of Player1: {Player1.GetTotalttack()}");
            Console.WriteLine($"Total Defense of Player1: {Player1.GetTotalDefense()}");
            Player1.Equip(Shoulder, false);
            Player1.Equip(arm, false);
            Console.WriteLine($"Total Attack of Player1: {Player1.GetTotalttack()}");
            Console.WriteLine($"Total Defense of Player1: {Player1.GetTotalDefense()}");
        }
    }
}
