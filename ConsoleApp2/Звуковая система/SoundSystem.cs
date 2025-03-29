using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Звуковая_система
{
    internal class SoundSystem
    {
        public void On() => Console.WriteLine("Звуковая система включена");
        public void Off() => Console.WriteLine("Звуковая система выключена");
        public void SetMode(string mode) => Console.WriteLine($"Режим звука: {mode}");
    }
}
