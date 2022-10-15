using CommandDesignPattern.Classes;
using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            room.SetCommand(new OpenCloseCurtainsCommand(room.GetCurtains()));
            room.ExecuteCommand();
            Console.WriteLine(room.CurtainsOpen());

            Console.WriteLine("==========================================");

            FloorLamp lamp = new FloorLamp();
            lamp.SetCommand(new SwitchLightsCommand(lamp.GetLight()));
            lamp.ExecuteCommand();
            Console.WriteLine(lamp.IsLightOn());
        }
    }
}
