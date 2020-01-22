using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace FOCommon.Items
{

    public class ItemProtoCustomField
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public Byte Type { get; set; }
        public ItemProtoCustomField(string name, Utils.DataType type)
        {
            this.Name = name;
            this.Type = (Byte)type;
        }
    }

    // Updated 2011-05-07
    public class ItemProto : System.IComparable<ItemProto>
    {
        public ItemProto()
        {
            StartValue = new Int32[10];
            ChildPid   = new Int32[5];
            ChildLines = new String[5];
            New        = false;
        }

        public int CompareTo(ItemProto prot)
        {
            if (this.ProtoId < prot.ProtoId) return -1;
            if (this.ProtoId == prot.ProtoId) return 0;
            return 1;
        }

        // Extended editor data
        public bool New; // If created in editor in this session

        public Dictionary<string, ItemProtoCustomField> CustomFields = new Dictionary<string, ItemProtoCustomField>();
        public string FileName; // Which file it was loaded from
// ReSharper disable InconsistentNaming
        public UInt16 ProtoId               ;//  { get; set; }
        public string Name                  ;//  { get; set; } // FOOBJ.msg
        public string Description           ;//  { get; set; } // FOOBJ.msg
        public string ScriptModule          ;//  { get; set; }
        public string ScriptFunction        ;//  { get; set; }
        public int Type                     ;//{ get { return _Type;} set{ _Type=value; TypeString=Utils.GetKeyByValue(Data.ItemTypes, value); } }
        public string PicMap                ;//  { get; set; }
        public string PicInv                ;//  { get; set; }
        public uint Flags                   ;//  { get; set; }
        public bool Stackable               ;//  { get; set; }
        public bool Deteriorable            ;//  { get; set; }
        public bool GroundLevel             ;//  { get; set; }
        public int Corner                   ;//  { get; set; }
        public int Dir                      ;//  { get; set; }
        public Byte Slot                    ;//  { get; set; }
        public uint Weight                  ;//  { get; set; }
        public uint Volume                  ;//  { get; set; }
        public uint Cost                    ;//  { get; set; }
        public uint StartCount              ;//  { get; set; }
        public Byte SoundId                 ;//  { get; set; }
        public Byte Material                ;//  { get; set; }
        public Byte LightFlags              ;//  { get; set; }
        public Byte LightDistance           ;//  { get; set; }
        public SByte LightIntensity         ;//  { get; set; }
        public Int32 LightColor               ;//  { get; set; }
        public bool DisableEgg              ;//  { get; set; }
        public UInt16 AnimWaitBase          ;//  { get; set; }
        public UInt16 AnimWaitRndMin        ;//  { get; set; }
        public UInt16 AnimWaitRndMax        ;//  { get; set; }

        public Byte AnimStay_0              ;//  { get; set; }

        public Byte AnimStay_1              ;//  { get; set; }
        public Byte AnimShow_0              ;//  { get; set; }
        public Byte AnimShow_1              ;//  { get; set; }
        public Byte AnimHide_0              ;//  { get; set; }
        public Byte AnimHide_1              ;//  { get; set; }
        public Int16 OffsetX                ;//  { get; set; }
        public Int16 OffsetY                ;//  { get; set; }
        public Byte SpriteCut               ;//  { get; set; }
        public SByte DrawOrderOffsetHexY    ;//  { get; set; }
        public UInt16 RadioChannel          ;//  { get; set; }
        public UInt16 RadioFlags            ;//  { get; set; }
        public Byte RadioBroadcastSend      ;//  { get; set; }
        public Byte RadioBroadcastRecv      ;//  { get; set; }
        public Byte IndicatorStart          ;//  { get; set; }
        public Byte IndicatorMax            ;//  { get; set; }
        public uint HolodiskNum             ;//  { get; set; }
        public int[] StartValue             ;//  { get; set; }
        public String BlockLines            ;//  { get; set; }
        public Int32[] ChildPid             ;//  { get; set; }
        public String[] ChildLines          ;//  { get; set; }
        public bool Weapon_IsUnarmed        ;//  { get; set; }
        public int Weapon_UnarmedTree       ;//  { get; set; }
        public int Weapon_UnarmedPriority   ;//  { get; set; }
        public int Weapon_UnarmedMinAgility ;//  { get; set; }
        public int Weapon_UnarmedMinUnarmed ;//  { get; set; }
        public int Weapon_UnarmedMinLevel   ;//  { get; set; }
        public int Weapon_CriticalFailture  ; // Maybe deprecated
        public uint Weapon_Anim1            ;//  { get; set; }
        public uint Weapon_MaxAmmoCount     ;//  { get; set; }
        public int Weapon_Caliber           ;//  { get; set; }
        public UInt16 Weapon_DefaultAmmoPid ;//  { get; set; }
        public int Weapon_MinStrength       ;//  { get; set; }
        public int Weapon_Perk              ;//  { get; set; }
        public uint Weapon_ActiveUses       ;//  { get; set; }
        public int Weapon_Skill_0           ;//  { get; set; }
        public int Weapon_Skill_1           ;//  { get; set; }
        public int Weapon_Skill_2           ;//  { get; set; }
        public int Weapon_DmgType_0;
        public int Weapon_DmgType_1;
        public int Weapon_DmgType_2;
        public string Weapon_Anim2_0;
        public string Weapon_Anim2_1;
        public string Weapon_Anim2_2;
        public bool Weapon_Remove_0;
        public bool Weapon_Remove_1;
        public bool Weapon_Remove_2;
        public string Weapon_PicUse_0       ;//  { get; set; } // uint
        public string Weapon_PicUse_1       ;//  { get; set; } // uint
        public string Weapon_PicUse_2       ;//  { get; set; } // uint
        public int Weapon_DmgMin_0;
        public int Weapon_DmgMin_1;
        public int Weapon_DmgMin_2;
        public int Weapon_DmgMax_0;
        public int Weapon_DmgMax_1;
        public int Weapon_DmgMax_2;
        public int Weapon_FlyEffect_0;
        public int Weapon_FlyEffect_1;
        public int Weapon_FlyEffect_2;
        public uint Weapon_MaxDist_0        ;//  { get; set; }
        public uint Weapon_MaxDist_1        ;//  { get; set; }
        public uint Weapon_MaxDist_2        ;//  { get; set; }
        public uint Weapon_Round_0          ;//  { get; set; }
        public uint Weapon_Round_1          ;//  { get; set; }
        public uint Weapon_Round_2          ;//  { get; set; }
        public uint Weapon_ApCost_0         ;//  { get; set; }
        public uint Weapon_ApCost_1         ;//  { get; set; }
        public uint Weapon_ApCost_2         ;//  { get; set; }
        public bool Weapon_Aim_0            ;//  { get; set; }
        public bool Weapon_Aim_1            ;//  { get; set; }
        public bool Weapon_Aim_2            ;//  { get; set; }
        public Byte Weapon_SoundId_0        ;//  { get; set; }
        public Byte Weapon_SoundId_1        ;//  { get; set; }
        public Byte Weapon_SoundId_2        ;//  { get; set; }
        public int Ammo_Caliber             ;//  { get; set; }
        public int Ammo_AcMod;
        public int Ammo_DrMod;
        public bool Door_NoBlockMove        ;//  { get; set; }
        public bool Door_NoBlockShoot       ;//  { get; set; }
        public bool Door_NoBlockLight       ;//  { get; set; }
        public uint Container_Volume        ;//  { get; set; }
        public bool Container_Changeble     ;//  { get; set; }
        public bool Container_CannotPickUp  ;//  { get; set; }
        public bool Container_MagicHandsGrnd;//  { get; set; }
        public UInt16 Locker_Condition      ;//  { get; set; }
        public int Grid_Type                ;//  { get; set; }
        public uint Car_Speed               ;//  { get; set; }
        public uint Car_Passability         ;//  { get; set; }
        public uint Car_DeteriorationRate   ;//  { get; set; }
        public uint Car_CrittersCapacity    ;//  { get; set; }
        public uint Car_TankVolume          ;//  { get; set; }
        public uint Car_MaxDeterioration    ;//  { get; set; }
        public uint Car_FuelConsumption     ;//  { get; set; }
        public uint Car_Entrance            ;//  { get; set; }
        public uint Car_MovementType        ;//  { get; set; }
        public uint Armor_CrTypeMale        ;
        public uint Armor_CrTypeFemale      ;
        // ReSharper restore InconsistentNaming
    }
}

                 