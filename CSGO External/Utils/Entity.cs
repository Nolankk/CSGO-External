using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGO_External.Structs;

namespace CSGO_External.Utils
{
    class Entitys
    {
        public struct Entity
        {
            public static int m_iID;
            public static int entityBase;
            public static int dormant;
            public static int m_iHealth;
            public static int entityTeam;
            public static int glowIndex;

            public static Vector3D m_VecOrigin;
            public static Vector3D m_VecMin;
            public static Vector3D m_VecMax;
        };

        public struct Weapon
        {
            public int m_iBase;
            public int m_iXuIDLow;
            public int m_iTexture;
            public int m_iItemDefinitionIndex;
        };

        public struct LocalPlayer
        {
            public static int localBase;
            public static int localTeam;
            public static int m_iClientState;
            public static int forceJump;
            public static int glowBase;
            public static int flags;
            public static QAngle m_angEyeAngles;
            public static Vector3D m_VecOrigin;

            internal class Arrays
            {
                public static float[] ViewMatrix = new float[16];
            }
        }
    }   
}
