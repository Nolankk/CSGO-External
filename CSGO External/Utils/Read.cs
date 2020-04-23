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
                LocalPlayer.viewAngles = Program.Mem.ReadMemory<Vector3D>(Offsets.baseEngine + Offsets.dwClientState_ViewAngles);
                LocalPlayer.velocity = Program.Mem.ReadInt(LocalPlayer.localBase + Offsets.m_vecVelocity);
                LocalPlayer.mouseEnabled = Program.Mem.ReadByte(Offsets.baseClient + Offsets.dwMouseEnable);
                Program.Mem.WriteFloat(LocalPlayer.localBase + Offsets.m_flFlashDuration, 0.0F);
                Thread.Sleep(10);
            }
        }   
    }
}
