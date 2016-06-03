﻿using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost.Characters;
using Server.Net;
using System.Net;

namespace Server.Packet
{
    public static class GamePacket
    {
        public static void Game_Log_Ack(Client c, int characterID, string[] IP)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.GAMELOG))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(characterID);
                plew.WriteInt(ServerConstants.CLIENT_VERSION);
                plew.WriteInt(14199);
                plew.WriteInt(12615854); // TimeLogin
                plew.WriteByte(byte.Parse(IP[0]));
                plew.WriteByte(byte.Parse(IP[1]));
                plew.WriteByte(byte.Parse(IP[2]));
                plew.WriteByte(byte.Parse(IP[3]));
                plew.WriteLong(c.SessionID); // Key

                c.Send(plew);
            }
        }

        public static void getNotice(Client c, byte type, string message)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.NOTICE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteByte(type);
                plew.WriteString(message, 67);

                c.Send(plew);
            }
        }

        public static void FW_DISCOUNTFACTION(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.FW_DISCOUNTFACTION))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("00 00 00 00 64 00 00 00 00 00 00 00 64 00 00 00 00 70 40 00 E8 03 D2 A8 74 A9 00 00 84 D1");

                c.Send(plew);
            }
        }

        public static void getQuickSlot(Client c, CharacterKeyMap keymaps)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.QUICKSLOTALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // Z
                plew.WriteInt(keymaps.SkillID("Z")); // 技能ID
                plew.WriteShort(keymaps.Type("Z")); // 技能類型
                plew.WriteShort(keymaps.Slot("Z")); // 技能欄位

                // X
                plew.WriteInt(keymaps.SkillID("X")); // 技能ID
                plew.WriteShort(keymaps.Type("X")); // 技能類型
                plew.WriteShort(keymaps.Slot("X")); // 技能欄位

                // C
                plew.WriteInt(keymaps.SkillID("C")); // 技能ID
                plew.WriteShort(keymaps.Type("C")); // 技能類型
                plew.WriteShort(keymaps.Slot("C")); // 技能欄位

                // V
                plew.WriteInt(keymaps.SkillID("V")); // 技能ID
                plew.WriteShort(keymaps.Type("V")); // 技能類型
                plew.WriteShort(keymaps.Slot("V")); // 技能欄位


                // B
                plew.WriteInt(keymaps.SkillID("B")); // 技能ID
                plew.WriteShort(keymaps.Type("B")); // 技能類型
                plew.WriteShort(keymaps.Slot("B")); // 技能欄位

                // N
                plew.WriteInt(keymaps.SkillID("N")); // 技能ID
                plew.WriteShort(keymaps.Type("N")); // 技能類型
                plew.WriteShort(keymaps.Slot("N")); // 技能欄位

                // ============================================

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位


                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // ============================================

                // Insert
                plew.WriteInt(keymaps.SkillID("Insert")); // 技能ID
                plew.WriteShort(keymaps.Type("Insert")); // 技能類型
                plew.WriteShort(keymaps.Slot("Insert")); // 技能欄位

                // Home
                plew.WriteInt(keymaps.SkillID("Home")); // 技能ID
                plew.WriteShort(keymaps.Type("Home")); // 技能類型
                plew.WriteShort(keymaps.Slot("Home")); // 技能欄位

                // PageUp
                plew.WriteInt(keymaps.SkillID("PageUp")); // 技能ID
                plew.WriteShort(keymaps.Type("PageUp")); // 技能類型
                plew.WriteShort(keymaps.Slot("PageUp")); // 技能欄位

                // Delete
                plew.WriteInt(keymaps.SkillID("Delete")); // 技能ID
                plew.WriteShort(keymaps.Type("Delete")); // 技能類型
                plew.WriteShort(keymaps.Slot("Delete")); // 技能欄位


                // End
                plew.WriteInt(keymaps.SkillID("End")); // 技能ID
                plew.WriteShort(keymaps.Type("End")); // 技能類型
                plew.WriteShort(keymaps.Slot("End")); // 技能欄位

                // PageDown
                plew.WriteInt(keymaps.SkillID("PageDown")); // 技能ID
                plew.WriteShort(keymaps.Type("PageDown")); // 技能類型
                plew.WriteShort(keymaps.Slot("PageDown")); // 技能欄位

                // ============================================

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位


                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位

                // 
                plew.WriteInt(-1); // 技能ID
                plew.WriteShort(-1); // 技能類型
                plew.WriteShort(-1); // 技能欄位
                c.Send(plew);
            }
        }
    }
}
