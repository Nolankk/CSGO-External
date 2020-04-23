using System;
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
        public static int baseEngine = Program.Mem.DllImageAddress("engine.dll");
        public static int glowObject = 0x528B880;
        public static int m_iGlowIndex = 0xA428;
        public static int m_iTeamNum = 0xF4;
        public static int dwEntityList = 0x4D43AB4;
        public static int m_vecOrigin = 0x138;
        public static int m_vecMins = 0x0320;
        public static int m_vecMaxs = 0x032C;
        public static int dwViewMatrix = 0x4D353F4;
        public static int m_iHealth = 0x100;
        public static int m_iCrosshairId = 0xB3D4;
        public static int dwForceAttack = 0x3175088;
        public static int dwClientState_ViewAngles = 0x4D88;
        public static int m_vecVelocity = 0x114;
        public static int dwMouseEnable = 0xD35728;
        public static int m_bSpotted = 0x93D;
    }
}
