﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using CSGO_External.Structs;
using System.Xml;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using CSGO_External.Utils;
using static CSGO_External.Utils.Entitys;
using static CSGO_External.Utils.Entitys.Entity;

namespace CSGO_External.Render
{
    class Visuals
    {
        public static void startGlow()
        {
            while (true)
            {
                for (var i = 0; i < 64; i++)
                {
                    int curEnt = Program.Mem.ReadInt(Offsets.baseClient + Offsets.dwEntityList + i * 0x10);
                    int entTeam = Program.Mem.ReadInt(curEnt + 0xF0);
                    int dormantt = Program.Mem.ReadInt(curEnt + 0xED);

                    if (curEnt == 0)
                       continue;

                    if (curEnt == LocalPlayer.localBase)
                        continue;

                    if (LocalPlayer.localTeam == entTeam)
                        continue;

                    if (dormantt == 1)
                       continue;

                    GlowStruct Enemy = new GlowStruct()
                    {
                        r = 1,
                        g = 0,
                        b = 0,
                    };

                    Program.Mem.WriteFloat(LocalPlayer.glowBase + (glowIndex * 0x38 + 0x4), Enemy.r);
                    Program.Mem.WriteFloat(LocalPlayer.glowBase + (glowIndex * 0x38 + 0x8), Enemy.g);
                    Program.Mem.WriteFloat(LocalPlayer.glowBase + (glowIndex * 0x38 + 0xC), Enemy.b);
                    Program.Mem.WriteFloat(LocalPlayer.glowBase + (glowIndex * 0x38 + 0x10), 1.0f);
                    Program.Mem.WriteByte(LocalPlayer.glowBase + (glowIndex * 0x38 + 0x24), 1);
                }
                Thread.Sleep(1);
            }
        }
        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
        }
    }
}