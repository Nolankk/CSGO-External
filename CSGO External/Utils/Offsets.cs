﻿using System;
using System.Collections.Generic;
using System.Text;
using ReadWriteMemory;
using CSGO_External;

namespace CSGO_External.Utils
{
    class Offsets
    {
        public static int m_Local = 0xD2FB84;
        public static int m_fFlags = 0x104;
        public static int dwForceJump = 0x51ED750;
        public static int baseClient = Program.Mem.DllImageAddress("client_panorama.dll");
        public static int glowObject = 0x528B880;
        public static int m_iGlowIndex = 0xA428;
        public static int m_iTeamNum = 0xF4;
        public static int dwEntityList = 0x4D43AB4;
        public static int m_vecOrigin = 0x138;
        public static int m_vecMins = 0x0320;
        public static int m_vecMaxs = 0x032C;
        public static int dwViewMatrix = 0x4D353F4;
    }
}