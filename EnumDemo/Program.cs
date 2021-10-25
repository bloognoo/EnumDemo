using System;

namespace EnumDemo
{
    internal class Program
    {
        enum Stuff
        {
            ThingA=0, // this is important 
            ThingB,
            ThingC,
            ThingD
        }
        
        public static void Main(string[] args)
        {
            var rand = new Random();
            var stuffCount = Enum.GetNames(typeof(Stuff)).Length;
            var thingInt = rand.Next(stuffCount);
            var thingStr = (Stuff)thingInt;

            Console.WriteLine("Thing Is : {0}",thingInt);
            Console.WriteLine("Thing is also : {0}",thingStr);
        }
    }
}