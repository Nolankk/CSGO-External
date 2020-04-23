using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSGO_External.Utils;
using SlimDX.DirectInput;
using static CSGO_External.Utils.Entitys;

namespace CSGO_External.Features
{
    class TriggerBot
    {
        public static void Start()
        {
            while (true)
            {
                int playerInCrosshair = Program.Mem.ReadInt(LocalPlayer.localBase + Offsets.m_iCrosshairId);

                if (playerInCrosshair > 0 && playerInCrosshair < 65)
                {
                    int curEnt = Program.Mem.ReadInt(Offsets.baseClient + Offsets.dwEntityList + (playerInCrosshair - 1) * 0x10);
                    int entHealth = Program.Mem.ReadInt(curEnt + Offsets.m_iHealth);
                    int entTeam = Program.Mem.ReadInt(curEnt + Offsets.m_iTeamNum);

                    if ((entTeam != LocalPlayer.localTeam) && (entTeam > 1) && (entHealth > 0) && Convert.ToBoolean((long)Program.GetAsyncKeyState(6)))
                    {
                        Program.Mem.WriteInt(Offsets.baseClient + Offsets.dwForceAttack, 1);
                        Thread.Sleep(1);
                        Program.Mem.WriteInt(Offsets.baseClient + Offsets.dwForceAttack, 4);
                    }
                }
                Thread.Sleep(5);
            }
        }
    }
}
