using CSGO_External.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CSGO_External.Utils.Entitys;
using static CSGO_External.Utils.Entitys.Entity;

namespace CSGO_External.Utils
{
    class Read
    { 

        public static void Start()
        {
            while (true)
            {
                LocalPlayer.localBase = Program.Mem.ReadInt(Offsets.m_Local + Offsets.baseClient);
                LocalPlayer.glowBase = Program.Mem.ReadInt(Offsets.baseClient + Offsets.glowObject);
                LocalPlayer.localTeam = Program.Mem.ReadInt(LocalPlayer.localBase + Offsets.m_iTeamNum);
                LocalPlayer.forceJump = Offsets.baseClient + Offsets.dwForceJump;
                LocalPlayer.flags = Program.Mem.ReadInt(LocalPlayer.localBase + Offsets.m_fFlags);

                for (var i = 0; i < 64; i++)
                {
                    Entity.entityBase = Program.Mem.ReadInt(Offsets.baseClient + Offsets.dwEntityList + i * 0x10);
                    if (entityBase > 0)
                    {
                        Entity.dormant = Program.Mem.ReadInt(entityBase + 0xED);
                        Entity.glowIndex = Program.Mem.ReadInt(entityBase + Offsets.m_iGlowIndex);
                        Entity.m_VecOrigin = Program.Mem.ReadMemory<Vector3D>(entityBase + Offsets.m_vecOrigin);
                        Entity.m_VecMin = Program.Mem.ReadMemory<Vector3D>(entityBase + Offsets.m_vecMins);
                        Entity.m_VecMax = Program.Mem.ReadMemory<Vector3D>(entityBase + Offsets.m_vecMaxs);
                        Entity.entityTeam = Program.Mem.ReadInt(entityBase + Offsets.m_iTeamNum);
                        LocalPlayer.Arrays.ViewMatrix = Program.Mem.ReadMatrix<float>(Offsets.baseClient + Offsets.dwViewMatrix, 16);
                    }
                }
               // Thread.Sleep(10);
            }
        }   
    }
}
