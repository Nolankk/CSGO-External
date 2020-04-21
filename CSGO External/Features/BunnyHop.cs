using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using CSGO_External.Utils;
using CSGO_External;
using ReadWriteMemory;
using static CSGO_External.Utils.Entitys;

namespace CSGO_External.Features
{
    class BunnyHop
    {
       
        public static void Start()
        {
            while (true)
            {
                Random rand = new Random();

                int delay = 0;
                int count = 0;

                // 257 is standing on the ground, and 263 is crouching on the ground.
                if (Program.GetAsyncKeyState(32) > 0 && LocalPlayer.flags == 257 || LocalPlayer.flags == 263) //Program.GetAsyncKeyState(32) > 0
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
                    Program.Mem.WriteInt(LocalPlayer.forceJump, 1);
                    Thread.Sleep(delay);
                    Program.Mem.WriteInt(LocalPlayer.forceJump, 0);
                }
                Thread.Sleep(1);
            }
        }
    }
}
