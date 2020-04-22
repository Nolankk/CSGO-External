using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using ReadWriteMemory;
using CSGO_External.Utils;
using CSGO_External.Features;
using System.Security.Cryptography.X509Certificates;
using CSGO_External.Render;

namespace CSGO_External
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);
        public static ProcessMemory Mem;

        static void Main(string[] args)
        {
            
            Mem = new ProcessMemory("csgo");

            if (Mem.CheckProcess())
            {
                Mem.StartProcess();
            }

            Thread Updater = new Thread(Read.Start);
            Updater.Start();

            Thread Bunny = new Thread(BunnyHop.Start);
            Bunny.Start();

            Thread Glow = new Thread(Visuals.startGlow);
            Glow.Start();

            Thread Trigger = new Thread(TriggerBot.Start);
            Trigger.Start();
        }
    }
}
