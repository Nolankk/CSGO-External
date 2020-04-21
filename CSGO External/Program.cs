using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using ReadWriteMemory;

namespace CSGO_External
{
    class Program
    {
        public static int m_Local = 0xD2FB84;
        public static int m_fFlags = 0x104;
        public static int dwForceJump = 0x51ED750;
        public static int baseClient;

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int vKey);

        static void Main(string[] args)
        {
            ProcessMemory Mem = new ProcessMemory("csgo");
            Random rand = new Random();

            if (Mem.CheckProcess())
            {
                Mem.StartProcess();
            }

            baseClient = Mem.DllImageAddress("client_panorama.dll");
            int forceJump = baseClient + dwForceJump;
            int localBase = Mem.ReadInt(m_Local + baseClient);

            int delay = 0;
            int count = 0;

            while (true)
            {
                int flags = Mem.ReadInt(localBase + m_fFlags);

                // 257 is standing on the ground, and 263 is crouching on the ground.
                if (GetAsyncKeyState(32) > 0 && flags == 257 || flags == 263)
                {
                    count++;

                    if (count > rand.Next(3, 5)) //Hops before change of delay
                    {
                        delay = rand.Next(14, 16); //Random delays to make us mess up sometimes
                        count = 0;
                    }
                    else
                    {
                        delay = 10;
                    }

                    Thread.Sleep(delay);
                    Mem.WriteInt(forceJump, 1);
                    Thread.Sleep(delay);
                    Mem.WriteInt(forceJump, 0);
                }
                Thread.Sleep(1);
            }
        }
    }
}
