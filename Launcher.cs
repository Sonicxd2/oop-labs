using System;

namespace OOP
{
    public class Launcher
    {
        static void Main(string[] args)
        {
            INIConfig config = new INIConfig("test.ini");
            var s = config.get("_", "1873021582");
            Console.Out.WriteLine(s);
            
            INIConfig d = new INIConfig("ad.ini");
            Console.WriteLine(d.get("C", "C"));
        }
    }
}